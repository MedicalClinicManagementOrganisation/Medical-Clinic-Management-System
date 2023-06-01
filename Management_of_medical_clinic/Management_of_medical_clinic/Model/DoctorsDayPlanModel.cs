using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Migrations;


namespace Console_Management_of_medical_clinic.Model
{
    public class DoctorsDayPlanModel
    {
        [Key] public int IdDoctorsDayPlan { get; set; }
        public int IdOfTerm { get; set; }
        public int IdDay { get; set; }
        public EnumAppointmentStatus Status { get; set; } = EnumAppointmentStatus.Inactive;
        public decimal? Cost { get; set; } = 100;
        //Relationships
        [ForeignKey("CalendarModel")] public int? IdCalendar { get; set; }
        public CalendarModel CalendarModel { get; set; }
        [ForeignKey("EmployeeModel")] public int? IdEmployee { get; set; }
        public EmployeeModel EmployeeModel { get; set; }
        [ForeignKey("OfficeModel")] public int? IdOffice { get; set; }
        public OfficeModel OfficeModel { get; set; }
        [ForeignKey("Patient")] public int? PatientId { get; set; }
        public Patient? Patient { get; set; }


        public DoctorsDayPlanModel() { }

        public DoctorsDayPlanModel(int idOfTerm, EnumAppointmentStatus status)
        {
            IdOfTerm = idOfTerm;
            Status = status;
        }

        public DoctorsDayPlanModel(int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, EnumAppointmentStatus status)
        {
            IdOfTerm = idOfTerm;
            IdDay = idDay;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            Status = status;
        }

        public DoctorsDayPlanModel(int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, int patientId, EnumAppointmentStatus status)
        {
            IdOfTerm = idOfTerm;
            IdDay = idDay;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            PatientId = patientId;
            Status = status;
        }

        public DoctorsDayPlanModel(int idDoctorsDayPlan, int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, int patientId, EnumAppointmentStatus status)
        {
            IdDoctorsDayPlan = idDoctorsDayPlan;
            IdOfTerm = idOfTerm;
            IdDay = idDay;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            PatientId = patientId;
            Status = status;
        }

        public override string ToString()
        {
            return CalendarService.GetDateByIdCalendar((int)IdCalendar, IdDay).ToShortDateString() + " " + AppointmentService.GetTermByTermId(IdOfTerm).ToString() + "  (Cost: " + Cost + ")";

        }

        public object[] appointmentData => new object[] {
            PatientService.GetPatientById((int)PatientId).ToString(),
            PatientService.GetPatientById((int)PatientId).PESEL,
            EmployeeService.GetEmployeeByID((int)IdEmployee).ToString(),
            SpecializationService.GetSpecializationById((int)EmployeeService.GetEmployeeByID((int)IdEmployee).IdSpecialization).Name,
            CalendarService.GetDateByIdCalendar((int)IdCalendar,IdDay).ToShortDateString(),
            DoctorsPlanService.GetTermDescription((EnumTerms)IdOfTerm),
            OfficeService.GetOfficeById((int)IdOffice).Number,
            Cost.ToString()
        };


        public static void RemoveDoctorsDayPlanModel(AppDbContext context)
        {
            List<DoctorsDayPlanModel> doctorsDayPlanModels = CalendarAppointmentService.GetAppointmentsWithPatients();

            foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
            {
                DateTime date = CalendarService.GetDateByIdCalendar((int)doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdDay);

                if (doctorsDayPlanModel.Status == EnumAppointmentStatus.Overdue || date < DateTime.Now.Date)
                {
                    context.DbDoctorsDayPlan.Remove(doctorsDayPlanModel);
                    context.SaveChanges();
                }
            }
        }

        public object[] appointmentDoctorData => new object[] {
            PatientService.GetPatientById((int)PatientId).PatientId,
            PatientService.GetPatientById((int)PatientId).LastName,
            PatientService.GetPatientById((int)PatientId).FirstName,
            PatientService.GetPatientById((int)PatientId).PESEL,
            CalendarService.GetDateByIdCalendar((int)IdCalendar,IdDay).ToShortDateString(),
            DoctorsPlanService.GetTermDescription((EnumTerms)IdOfTerm),
            OfficeService.GetOfficeById((int)IdOffice).Number,
            Cost.ToString()
        };


    }
}
