using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace MedicalClinicTest
{
	// TODO: testy AllActive_Correct, AllActive_Incorrect, AllInactive_Correct należy dostosować do stanu faktycznego
	public class CalendarServiceTest
	{
		[Fact]
		public void SortAscending_Correct()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", true);

			Assert.StartsWith("03", sortedCalendars[0].DateReference);
		}

		[Fact]
		public void SortDescending_Correct()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", false);

			Assert.StartsWith("08", sortedCalendars[0].DateReference);
		}

		[Fact]
		public void SortAscending_Incorrect()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", true);

			bool incorrectFirstMonth = sortedCalendars[0].DateReference.StartsWith("05");
			Assert.False(incorrectFirstMonth);
		}

		[Fact]
		public void SortDescending_Incorrect()
		{
			CalendarService calendarService = new();
			List<CalendarModel> sortedCalendars = calendarService.Sort("", false);

			bool incorrectFirstMonth = sortedCalendars[0].DateReference.StartsWith("03");
			Assert.False(incorrectFirstMonth);
		}

		[Fact]
		public void Filter_ExistingCalendar()
		{
			string dataReference = "03";
			string activityStatus = "Inactive";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter(dataReference, activityStatus);
			bool containsCalendar = filteredCalendars.Any(c => c.DateReference.StartsWith(dataReference) && c.Active == false);

			Assert.True(containsCalendar);
		}

		[Fact]
		public void Filter_NotExistingCalendar()
		{
			string dataReference = "02-2023";
			string activityStatus = "Active";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter(dataReference, activityStatus);
			bool containsCalendar = filteredCalendars.Any(c => c.DateReference.StartsWith(dataReference) && c.Active == true);

			Assert.False(containsCalendar);
		}

		[Fact]
		public void Filter_AllActive_Correct()
		{
			string activityStatus = "Active";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter("", activityStatus);
			int filteredCount = filteredCalendars.Count();

			Assert.Equal(0, filteredCount);
		}

		[Fact]
		public void Filter_AllActive_Incorrect()
		{
			string activityStatus = "Active";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter("", activityStatus);
			int filteredCount = filteredCalendars.Count();

			Assert.NotEqual(10, filteredCount);
		}

		[Fact]
		public void Filter_AllInactive_Correct()
		{
			string activityStatus = "Inactive";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter("", activityStatus);
			int filteredCount = filteredCalendars.Count();

			Assert.Equal(5, filteredCount);
		}

		[Fact]
		public void Filter_AllInactive_Incorrect()
		{
			string activityStatus = "Inactive";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter("", activityStatus);
			int filteredCount = filteredCalendars.Count();

			Assert.NotEqual(0, filteredCount);
		}

		[Fact]
		public void Filter_NotExisting()
		{
			string dataReference = "01-1900";
			CalendarService calendarService = new();

			List<CalendarModel> filteredCalendars = calendarService.Filter(dataReference, "");
			int filteredCount = filteredCalendars.Count();

			Assert.Equal(0, filteredCount);
		}
	}
}
