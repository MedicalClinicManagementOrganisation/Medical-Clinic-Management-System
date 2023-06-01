using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic.Interfaces;
using Console_Management_of_medical_clinic.Model;
using Org.BouncyCastle.Asn1.X509;

namespace Console_Management_of_medical_clinic.Logic
{
	public class CalendarService : ICalendarFilterSort
	{
		public static string LastErrorMessage { get; private set; }
		public static void AddCalendar(CalendarModel calendarModel)
		{
			using (AppDbContext context = new AppDbContext())
			{
				context.DbCalendars.Add(calendarModel);
				context.SaveChanges();
			}
		}

		public List<CalendarModel> GetAll()
		{
			using (AppDbContext context = new())
			{
				return context.DbCalendars.ToList();
			}
		}

		public static List<CalendarModel> GetCalendarData()
		{
			List<CalendarModel> calendars = new List<CalendarModel>();
			using (var db = new AppDbContext())
			{
				calendars = db.DbCalendars.ToList();
			}
			return calendars;
		}

		public static int GetCalendarIdByDate(string selectedDate)
		{
			List<CalendarModel> calendars = GetCalendarData();
			string CurrentDateReference = selectedDate.Remove(0, 3).Replace(".", "-");
			foreach (CalendarModel calendar in calendars)
			{
				if (calendar.DateReference == CurrentDateReference)
				{
					return calendar.IdCalendar;
				}
			}
			return -1;
		}


		public static List<int> GetCalendarIds()
		{
			List<int> calendarIds = new List<int>();
			List<CalendarModel> calendars = GetCalendarData();

			foreach (CalendarModel calendar in calendars)
			{
				calendarIds.Add(calendar.IdCalendar);
			}
			return calendarIds;
		}
		public static bool checkIfCalendarExistsCalendarAdd(string selectedDate)    //only for Calendar adding, need to be edited
		{
			List<CalendarModel> calendars = GetCalendarData();
			string CurrentDateReference = selectedDate.Remove(0, 3).Replace(".", "-");

			foreach (CalendarModel calendar in calendars)
			{
				if (calendar.DateReference == selectedDate)
				{
					return true;
				}
			}
			return false;
		}

		public static bool checkIfCalendarExists(string selectedDate)
		{
			List<CalendarModel> calendars = GetCalendarData();
			string CurrentDateReference = selectedDate.Remove(0, 3).Replace(".", "-");

			foreach (CalendarModel calendar in calendars)
			{
				if (calendar.DateReference == CurrentDateReference)
				{
					return true;
				}
			}
			return false;
		}

		public static CalendarModel GetCalendarById(int id)
		{
			return GetCalendarData().FirstOrDefault(calendar => calendar.IdCalendar == id);
		}

		public List<CalendarModel> Filter(string dateReference, string activityStatus)
		{
			List<CalendarModel> filteredCalendars = GetAll();

			dateReference = dateReference.ToLower().Trim();

			// Filtering by date reference
			// Consider improving it by normalizing input or create a mask for a field where it will be written
			if (!string.IsNullOrEmpty(dateReference))
			{
				filteredCalendars =
					filteredCalendars
					.Where(
						c =>
						c.DateReference.ToLower().Contains(dateReference)
						)
					.ToList();
			}

			// Filtering by an activity status - curenntly it's active or inactive
			// If it changes to some enum values, it should be changed
			if (!string.IsNullOrEmpty(activityStatus))
			{
				if (activityStatus == "Inactive")
				{
					filteredCalendars =
						filteredCalendars
						.Where(
							c =>
							c.Active == false
							)
						.ToList();
				}

				if (activityStatus == "Active")
				{
					filteredCalendars =
						filteredCalendars
						.Where(
							c =>
							c.Active == true
							)
						.ToList();
				}
			}

			return filteredCalendars;
		}

		public List<CalendarModel> Sort(string dateReference, bool IsAscending)
		{
			// dateReference is in format "mm-yyyy" which is not sortable in meaningful way
			// TODO: Consider sorting calendars by year taken from "yyyy" part and then by month taken from "mm" part
			List<CalendarModel> sortedCalendars = GetAll();

			if (IsAscending)
			{
				sortedCalendars =
					sortedCalendars
					.OrderBy(
						c =>
						c.DateReference)
					.ToList();
			}
			else
			{
				sortedCalendars =
					sortedCalendars
					.OrderByDescending(
						c =>
						c.DateReference)
					.ToList();
			}

			return sortedCalendars;
		}

		public static void DeleteCalendar(int IdCalendar)
		{
			try
			{
				using (var db = new AppDbContext())
				{
					CalendarModel calendar = db.DbCalendars.Find(IdCalendar);

					if (calendar != null)
					{
						db.DbCalendars.Remove(calendar);
						db.SaveChanges();
					}
				}
			}
			catch (Microsoft.EntityFrameworkCore.DbUpdateException)
			{
				LastErrorMessage = "You can't remove this Calendar. Firstly remove connected appointments";
				throw;
			}

		}

		public static DateTime GetDateByIdCalendar(int idCalendar, int DayOfMonth)
		{
			List<CalendarModel> calendars = GetCalendarData();

			string reference = string.Empty;
			int year = 0, month = 0;

			foreach (CalendarModel calendar in calendars)
			{
				if (idCalendar == calendar.IdCalendar)
				{
					reference = calendar.DateReference;
					month = int.Parse(reference.Substring(0, 2));
					year = int.Parse(reference.Substring(3, 4));
				}
			}

			if (reference == string.Empty)
			{
				throw new Exception("Calendar don't found in database.");
			}

			DateTime result = new DateTime(year, month, DayOfMonth);

			return result;
		}

		public static int GetIdFromDate(DateTime date)
		{
			int result = 0;

			string month = date.Month.ToString("00");
			string year = date.Year.ToString();

			string DateReference = month + '-' + year;

			List<CalendarModel> calendarModels = GetCalendarData();

			foreach (CalendarModel calendarModel in calendarModels)
			{
				if (DateReference == calendarModel.DateReference)
				{
					result = calendarModel.IdCalendar;
				}
			}

			return result;
		}

        public static void ActivateCalendar(int calendarId)
        {
            using (AppDbContext context = new AppDbContext())
            {
                CalendarModel model = context.DbCalendars.Find(calendarId);
                if (model != null)
                {
                    model.Active = true;
                    context.SaveChanges();
                }
            }
        }

        public static void EditCalendar(int calendarId, bool active)
		{
			using (AppDbContext context = new AppDbContext())
			{
				CalendarModel model = context.DbCalendars.Find(calendarId);
				if (model != null)
				{
					model.Active = active;
					context.SaveChanges();
				}
			}
		}

		//Doctor merge with Rejestracja
		public static List<AppointmentModel> appointmentInSelectedDate(List<AppointmentModel> ListIn, DateTime selectedDate, int idCalendar)
		{
			List<AppointmentModel> result = new List<AppointmentModel>();

			int idDay = selectedDate.Day;

			foreach (AppointmentModel appointment in ListIn)
			{
				if (appointment.IdCalendar == idCalendar && appointment.IdDay == idDay)
				{
					result.Add(appointment);
				}
			}

			return result;
		}

		public static void ChangeCalendarStatusToAccepted(int calendar_id) //doctors
		{
			using (AppDbContext context = new AppDbContext())
			{
				CalendarModel calendar = GetCalendarById(calendar_id);
				context.DbCalendars.Update(calendar);
				calendar.NumberOfAcceptedDoctors++;
				context.SaveChanges();

                //Change calendar status if all doctors accept
				CheckIfAllDoctorsAccepted(calendar_id);
            }
		}

		public static void CheckIfAllDoctorsAccepted(int calendar_id) //doctors
		{
            using (AppDbContext context = new AppDbContext())
            {
                CalendarModel calendar = GetCalendarById(calendar_id);
				if(calendar.NumberOfAcceptedDoctors >= calendar.NumberOfDoctors)
					CalendarService.EditCalendar(calendar_id, true);
            }
        }

        public static void ChangeCalendarStatusToRejected(int calendar_id) //doctors
        {
            using (AppDbContext context = new AppDbContext())
            {
                CalendarModel calendar = GetCalendarById(calendar_id);
                context.DbCalendars.Update(calendar);
                calendar.NumberOfDoctors--;
                context.SaveChanges();
            } //changes are needed here
        }

        public static bool AreAllTermsAccepted(int calendar_id, EmployeeModel employee)//added by doctors
		{
			List<DoctorsDayPlanModel> list = new List<DoctorsDayPlanModel>();
			List<DoctorsDayPlanModel> ListdoctorsDayPlanModel = DoctorsPlanService.GetPlansByCalendarId(calendar_id);
			foreach (DoctorsDayPlanModel ddpm in ListdoctorsDayPlanModel)
			{
				if (ddpm.Status == EnumAppointmentStatus.Accepted && ddpm.IdEmployee == employee.IdEmployee)
				{
					list.Add(ddpm);
				}
			}
			if (list.Count == ListdoctorsDayPlanModel.Count)
			{			
				return true;
			}
			else return false;

		}
	}

}
