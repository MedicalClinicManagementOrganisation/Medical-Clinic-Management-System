using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System.Text.RegularExpressions;

namespace Console_Management_of_medical_clinic.Logic
{
	public class PatientService
    {
        public List<Patient> GetPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.ToList();
            }
        }

        public static List<Patient> GetPatientDataStatic()
        {
            List<Patient> patients;
            using (AppDbContext db = new AppDbContext())
            {
                patients = db.Patients.ToList();
            }
            return patients;
        }

        public static List<int> GetPatientIds()
        {
            List<int> patientIds = new List<int>();
            List<Patient> patients = GetPatientDataStatic();

            foreach (Patient patient in patients)
            {
                patientIds.Add(patient.PatientId);
            }
            return patientIds;
        }

        public List<Patient> FilterPatient(string searchedText, string PESEL)
		{
			List<Patient> filteredPatients = GetPatientDataStatic();

            if (!string.IsNullOrEmpty(searchedText))
            {
				searchedText = searchedText.ToLower();

                filteredPatients =
                    filteredPatients
                    .Where(
                        p =>
                        (p.FirstName + " " + p.LastName)
                            .ToLower()
                            .Contains(searchedText)
                        )
                    .ToList();
			}    

            if (!string.IsNullOrEmpty(PESEL))
            {
                filteredPatients =
                    filteredPatients
                    .Where(
                        p =>
                        p.PESEL.Contains(PESEL)
                        )
                    .ToList();
			}

			return filteredPatients;
		}

        public static List<Patient> GetPatientsData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.ToList();
            }
        }

        public static Patient GetPatientById(int id)
        {
            return GetPatientsData().FirstOrDefault(patient => patient.PatientId == id);
        }

        public static string GetPatientInfoById(int id)
        {
            Patient patient = GetPatientById(id);
            if (patient != null)
            {
                return patient.FirstName.ToString() + " " + patient.LastName.ToString();
            }
            return null;
        }

        public bool IsValidName(string patientName, out string errorMessage)
        {
            // White space checking
            if (string.IsNullOrWhiteSpace(patientName)) 
            {
                errorMessage = "This field cannot be left empty";
                return false; 
            }

            // Length checking
            if (patientName.Length > 60) 
            {
                errorMessage = "It cannot be longer than 60 signs";
                return false; 
            }

            // Characters checking
            // Only letters, spaces and dashes
            bool onlyLetters = Regex.IsMatch(patientName, @"^[A-ZĄĆĘŁŃÓŚŹŻa-ząćęłńóśźż -]+$");

            if (!onlyLetters) 
            {
                errorMessage = "Name should be letters only";
                return false;
            }

            errorMessage = "";
            return true;
        }

        public bool IsValidDate(DateTime date, out string errorMessage)
        {
            // Checking if earlier than tommorow
            if (date > DateTime.Now) 
            {
                errorMessage = "Birth date cannot be in the future";
                return false; 
            }

            errorMessage = "";
            return true;
        }

        public bool IsValidPESEL(string pesel, DateTime birthdate, EnumSex sex, out string errorMessage)
        {
			// Length checking
			int length = pesel.Length;

			if (length != 11)
			{
				if (length == 0)
				{
                    errorMessage = "PESEL cannot be empty. It should 11 digits.";
				}
				else if (length < 11)
				{
                    errorMessage = "Given PESEL is too short. It should have 11 digits.";
				}
				else
				{
                    errorMessage = "Given PESEL is too long. It should have 11 digits.";
				}

				return false;
			}

            // Characters checking
            // Only digits
            bool onlyDigits = Regex.IsMatch(pesel, @"^\d+$");

            if (!onlyDigits ) 
            {
                errorMessage = "PESEL cannot contain letters or special characters";
                return false;
            }

			// Birth date checking
			string dateOfBirth = birthdate.ToString("yy/MM/dd");
            dateOfBirth = dateOfBirth.Replace(".", "");

            // For people born in 2000 and later
            if (birthdate.Year >= 2000)
            {
                int thirdDigitValue = int.Parse(dateOfBirth.Substring(2, 1));
                thirdDigitValue += 2;
                dateOfBirth = dateOfBirth.Remove(2, 1).Insert(2, thirdDigitValue.ToString());
			}

            string pattern = $@"^{dateOfBirth}\d*";
            bool isMatch = Regex.IsMatch(pesel, pattern);

            if (!isMatch) 
            {
                errorMessage = "PESEL or birth date are incorrect. They don't match.";
                return false;
            }

            // Gender checking
            // Male: only odd numbers
            // Female: 0 or even numbers
            int genderNumber = (int)pesel[9];

            if (sex == EnumSex.Male && genderNumber % 2 == 0) 
            {
                errorMessage = "PESEL or gender are incorrect. They don't match.";
                return false;
            }
            else if (sex == EnumSex.Female && genderNumber % 2 != 0 || genderNumber == 0) 
            {
				errorMessage = "PESEL or gender are incorrect. They don't match.";
				return false;
            }

            // Last digit checking
            // Rules for that https://obywatel.gov.pl/pl/dokumenty-i-dane-osobowe/czym-jest-numer-pesel
            // Example: for PESEL starting as 0207080362x, x = 8
			int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
			int sum = 0;
            int lastNumber = int.Parse(pesel[10].ToString());

			for (int i = 0; i < 10; i++)
			{
				int digit = int.Parse(pesel[i].ToString());
				sum += ((digit * weights[i]) % 10);
			}

			int controlNumber = (10 - (sum % 10)) % 10;

            if (controlNumber != lastNumber)
            {
                errorMessage = $"Control number in PESEL is incorrect. It should be {controlNumber} at the end.";
                return false;
            }

			// Uniqueness checking
			using (AppDbContext context = new())
            {
                bool patientExist = context.Patients.Any(p => p.PESEL == pesel);

                if (patientExist) 
                {
                    errorMessage = "PESEL is not unique. Patient with given PESEL already exist";
                    return false;
                }
            }

            errorMessage = "";
            return true;
        }
    }
}
