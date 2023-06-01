using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic
{
    public class EmployeeService
    {
        public static void AddEmployee(string firstName, string lastName, string pesel, string dateOfBirth,  string correspondenceAddress, string email, string phoneNumber,
            EnumSex sex, string username, string password, EnumEmployeeRoles role, int idSpecialization, bool isActive)
        {

            EmployeeModel employee = new EmployeeModel(firstName, lastName, pesel, dateOfBirth, correspondenceAddress, email, phoneNumber,
            sex, role, idSpecialization, isActive);

            using AppDbContext context = new AppDbContext();

            context.DbEmployees.Add(employee);
            context.SaveChanges();
        }

        public static bool AddEmployee(EmployeeModel newEmployee)
        {
            
            try
            {
                using AppDbContext context = new AppDbContext();
                
                context.DbEmployees.Add(newEmployee);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }

        public static List<EmployeeModel> GetEmployeesData()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            using (var db = new AppDbContext())
            {
                employees = db.DbEmployees.ToList();
            }
            return employees;
        }

        public static List<EmployeeModel> GetDoctors()
        {
            List<EmployeeModel> doctors = new List<EmployeeModel>();
            List<EmployeeModel> employees = GetEmployeesData();
            
            foreach (EmployeeModel employee in employees) 
            {
                if (employee.Role == EnumEmployeeRoles.MedicalDoctor)
                {
                    doctors.Add(employee);
                }                
            }            
            return doctors;
        }
        
        public static EmployeeModel GetEmployeeByUserId(UserModel user)
        {
            List<EmployeeModel> employees = GetEmployeesData();

            foreach(EmployeeModel employee in employees)
            {
                if (employee.IdEmployee == user.IdEmployee)
                {
                    return employee;
                }
            }
            return null;
        }


        //Validation upon addit Employee
        //Validate PESEL input
        public static (string, bool) validatePESEL(string input, DateTime selectedDate, int currentIndex)
        {
            if (input.Length != 11)
            {
                return ("PESEL should be 11 digits long", false);

            }

            string firstSix = input.Substring(0, 6);
            string lastChar = input[input.Length - 1].ToString();


            string formatedDate = selectedDate.ToString("dd/MM/yy");
            string rawDate = formatedDate.Replace(".", "");
            rawDate = rawDate.Replace("/", "");
            

            if (!long.TryParse(input, out long result))
            {
                return ("PESEL can only contain digits", false);
            }

            if (firstSix != rawDate)
            {
                return ("PESEL doesn't fit the date of birth", false);
            }

            if (currentIndex == 0 &&  int.Parse(lastChar)% 2 == 0)
            {
                return ("PESEL doesn't fit the sex", false);
            }

            if (currentIndex == 1 && int.Parse(lastChar) % 2 == 1)
            {
                return ("PESEL doesn't fit the sex", false);
            }


            return ("Success",true);
        }

        //Validate Email input
        public static (string, bool) validateEmail(string input, string name)
        {
            int atIndex = input.IndexOf('@');
            int dotIndex = input.LastIndexOf('.');
            List<string> domainList = new List<string> { ".com", ".org", ".net" };


            if (input.Length > 0)
            {
                if (input.Count(c => c == '@') != 1)
                {
                    return ("E-mail has to contain one '@' sign", false);
                }

                if (!input.Contains("."))
                {
                    return ("E-mail has to contain at least one '.' sign", false);
                }


                if (atIndex < 1 || atIndex == input.Length - 1)
                {
                    return ("The '@' sign has to have characers in front and behind of it", false);
                }


                if (dotIndex < atIndex + 2 || dotIndex == input.Length - 1)
                {
                    return ("The last '.' sign has to have characters behind and after it,\nand it has to be after the '@' sign", false);
                }

                if (!input.Contains(name.ToLower()))
                {
                    return ("E-mail needs to contain the recipient's name", false);
                }

                foreach(string domain in domainList)
                {
                    if (input.EndsWith(domain))
                    {
                        break;
                    }
                    return ("E-mail needs to contain a valid top-level domain", false);
                }
            }

            return ("Success", true);
        }

        public static EmployeeModel GetEmployeeByID(int EmployeeID)
        {
            EmployeeModel employee = new EmployeeModel();

            List<EmployeeModel> employees = GetEmployeesData();

            foreach (EmployeeModel employeeModel in employees)
            {
                if (employeeModel.IdEmployee == EmployeeID)
                {
                    employee = employeeModel;
                }
            }

            if (employee == null)
            {
                throw new Exception("Employee don't found in database.");
            }

            return employee;
        }
        //Validate Phone Number input
        public static (string, bool) validatePhone(string input)
        {
            if (input.Length > 0)
            {
                if (input.Length != 9)
                {
                    return ("Phone number has to be 9 digits long", false);
                }
            


                if (!long.TryParse(input, out long result))
                {
                    return ("Phone number can only contain digits", false);
                }
            }
            return ("Success", true);
        }

        public static string GetEmployeeInfoById(int id)
        {
            EmployeeModel employee = GetEmployeeByID(id);
            return employee.FirstName + employee.LastName;
        }
    }

}
