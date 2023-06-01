using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class CalendarAppointmentService
    {
        //public static Patient GetPatientDataByIdPatient(AppointmentModel appointment)?
        public static Patient GetPatientDataByIdPatient(DoctorsDayPlanModel appointment)
        {
            Patient? result = null;

            if (appointment.PatientId == null)
            {
                throw new Exception("PatientId = null");
            }

            using (AppDbContext context = new AppDbContext())
            {
                foreach (Patient patient in context.Patients)
                {
                    if (patient.PatientId == appointment.PatientId)
                    {
                        result = patient;
                    }
                }
            }

            if (result == null)
            {
                throw new Exception("Patient not found in database");
            }

            return result;
        }

        public static List<DoctorsDayPlanModel> GetAppointmentsWithPatients()
        {
            List<DoctorsDayPlanModel> appointments = GetAppointmentsData();
            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.PatientId != null)
                {
                    result.Add(appointment);
                }
            }

            return result;
        }

        public static List<DoctorsDayPlanModel> GetScheduledAppointments()
        {
            List<DoctorsDayPlanModel> appointments = GetAppointmentsData();
            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.Status == Data.Enums.EnumAppointmentStatus.Scheduled)
                {
                    result.Add(appointment);
                }
            }

            return result;
        }

        public static string GetLastNameAndNameOfEmployeeByAppointment(DoctorsDayPlanModel DoctorsDayPlanModel)
        {
            if (DoctorsDayPlanModel.IdEmployee == null)
            {
                throw new Exception("IdEmployee = null");
            }

            string result = string.Empty;

            int id = (int)DoctorsDayPlanModel.IdEmployee;

            using (AppDbContext context = new AppDbContext())
            {
                foreach (EmployeeModel employeeModel in context.DbEmployees)
                {
                    if (employeeModel.IdEmployee == id)
                    {
                        result = employeeModel.FirstName + " " + employeeModel.LastName;
                    }
                }
            }

            if (result == string.Empty)
            {
                throw new Exception("Employee not found in database");
            }

            return result;
        }

        public static List<DoctorsDayPlanModel> GetAppointmentsData()
        {
            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            using (AppDbContext context = new AppDbContext())
            {
                result = context.DbDoctorsDayPlan
                    .Select(a => new DoctorsDayPlanModel
                    {
                        IdDoctorsDayPlan = a.IdDoctorsDayPlan,
                        IdOfTerm = a.IdOfTerm,
                        Cost = a.Cost,
                        Status = a.Status,
                        IdCalendar = a.IdCalendar,
                        IdEmployee = a.IdEmployee,
                        PatientId = a.PatientId ?? null,
                        IdOffice = a.IdOffice,
                        IdDay = a.IdDay
                    })
                    .ToList();
            }

            return result;
        }

        public static List<DoctorsDayPlanModel> appointmentInSelectedDate(List<DoctorsDayPlanModel> ListIn, DateTime selectedDate, int idCalendar)
        {
            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            int idDay = selectedDate.Day;

            foreach (DoctorsDayPlanModel appointment in ListIn)
            {
                if (appointment.IdCalendar == idCalendar && appointment.IdDay == idDay)
                {
                    result.Add(appointment);
                }
            }

            return result;
        }

        public static List<DoctorsDayPlanModel> SortByDoctorLastName(List<DoctorsDayPlanModel> appointments)
        {
            return appointments.OrderBy(a => EmployeeService.GetEmployeeByID((int)a.IdEmployee).LastName).ToList();
        }

        public static List<DoctorsDayPlanModel> SortByTerm(List<DoctorsDayPlanModel> appointments)
        {
            return appointments.OrderBy(a => a.IdOfTerm).ToList();
        }

        public static List<DoctorsDayPlanModel> SortByPatientLastName(List<DoctorsDayPlanModel> appointments) //finish
        {
            return appointments.OrderBy(a => PatientService.GetPatientById((int)a.PatientId).LastName).ToList();
        }
    }
}
