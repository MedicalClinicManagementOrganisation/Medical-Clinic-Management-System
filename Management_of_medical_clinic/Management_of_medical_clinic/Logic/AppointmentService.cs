using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class AppointmentService
    {
        public static void AddAppointment(DoctorsDayPlanModel DoctorsDayPlanModel)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Add(DoctorsDayPlanModel);
                context.SaveChanges();
            }
        }
        /*
        public static void DoctorModifiesAppointment(int idappointment, int office, int term, int day)
        {
            var context = new AppDbContext();
            var appontment = context.DbAppointments.Find(idappointment);

            appontment.IdTerm = term;
            appontment.IdOffice = office;
            appontment.IdDay = day;

            context.SaveChanges();
        }
           */

        public static int GetIdOfTerm(string selectedTime)
        {

            string[] timeParts = selectedTime.Split(':');
            int hour = int.Parse(timeParts[0]);
            int minute = int.Parse(timeParts[1]);
            int selectedTimeInMinutes = (hour * 60) + minute;


            if (selectedTimeInMinutes < 420 || selectedTimeInMinutes >= 1200 
                || (selectedTimeInMinutes >= 660 && selectedTimeInMinutes < 680) 
                || (selectedTimeInMinutes >= 980 && selectedTimeInMinutes < 1000))
            {

                return -1;
            }
            else
            {
                int IdOfTerm = ((selectedTimeInMinutes - 420) / 20) + 1;
                return IdOfTerm;
            }
        }

        public static string GetTermByTermId(int IdOfTerm)
        {
            int minutesFromOpening = (IdOfTerm) * 20;
            int hour = minutesFromOpening / 60 + 7;
            int minute = minutesFromOpening % 60;
            return $"{hour:00}:{minute:00}";
        }

        public static List<DoctorsDayPlanModel> CheckAppointmentsAndReturnList(DateTime selectedDate, int idCalendar = 1)
        { 
            int idDay = selectedDate.Day;
            
            int IdOfTerm = GetIdOfTerm(selectedDate.ToString("HH:mm"));
            
            List<DoctorsDayPlanModel> appointments = new List<DoctorsDayPlanModel>();

            using(AppDbContext context = new AppDbContext())
            {
                foreach (DoctorsDayPlanModel appointment in context.DbDoctorsDayPlan)
                {
                    if (appointment.IdDay == idDay && appointment.IdCalendar == idCalendar)
                    {
                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }

        public static List<DoctorsDayPlanModel> GetAllAppointments()
        {
            using (AppDbContext context = new())
            {
                return context.DbDoctorsDayPlan.ToList();
            }
        }

        public static List<DoctorsDayPlanModel> GetAppointmentsForDoctorInChosenMonth(DateTime date, EmployeeModel employee)
        {
            List<DoctorsDayPlanModel> list = new List<DoctorsDayPlanModel>();
            int id_cal = CalendarService.GetCalendarIdByDate(date.ToString("d"));
            List<DoctorsDayPlanModel> allAppointments = GetAllAppointments();
            foreach (DoctorsDayPlanModel app in allAppointments)
            {
                if (id_cal == app.IdCalendar && employee.IdEmployee == app.IdEmployee && app.PatientId != null)
                { 
                    list.Add(app);
                }
            }return list;
        }

        public static void DoctorModifiesAppointment(int idappointment, int office, int term, int day)
        {
            var context = new AppDbContext();
            var appontment = context.DbAppointments.Find(idappointment);

            appontment.IdTerm = term;
            appontment.IdOffice = office;
            appontment.IdDay = day;

            context.SaveChanges();
        }

        // Validation when rescheduling
        public (bool, string) CanReschedule(DoctorsDayPlanModel appointmentRescheduled, DoctorsDayPlanModel termToReschedule)
        {

			// Rescheduling on the same term of appointment
			if (termToReschedule.IdDoctorsDayPlan == appointmentRescheduled.IdDoctorsDayPlan)
			{
				return (false, "It's the same term of appointment");
			}

            // Check if taken
			using (AppDbContext context = new())
            {
                bool conflict =
                    context.DbDoctorsDayPlan
                    .Any(
                    a =>
                    a.CalendarModel.IdCalendar == termToReschedule.IdCalendar &&
                    a.IdDay == termToReschedule.IdDay &&
                    a.IdOfTerm == termToReschedule.IdOfTerm &&
                    a.PatientId != null);

                if (conflict)
                {
                    return (false, "The term to reschedule appointment is already taken");
				}
            }

            // Check if the day from the past
            int today = DateTime.Today.Day;

            if (termToReschedule.IdDay < today)
                return (false, "The appointment cannot be rescheduled to the past");

            // Check if an hour from the past
            bool isTheSameDay = (termToReschedule.IdDay == today);
            bool isPastHour = (termToReschedule.IdOfTerm < appointmentRescheduled.IdOfTerm);

            if (isTheSameDay && isPastHour)
                return (false, "The appointment cannot be rescheduled to the past");

            // Success
			return (true, "Appointment rescheduled succesfully");
        }
    }
}
