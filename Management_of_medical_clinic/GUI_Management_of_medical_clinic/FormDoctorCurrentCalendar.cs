using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCurrentCalendar : Form
    {
        EmployeeModel currentUser;
        public FormDoctorCurrentCalendar(EmployeeModel currentUser, bool previousMonth = false)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        DateTime displayMonth = DateTime.Today;
        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();

        private void FormDoctorCalendar_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(displayMonth);
        }
        #region Calendar
        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void ChangeTitle(DateTime date)
        {
            CultureInfo culture = new CultureInfo("en-US");
            string month = date.ToString("MMMM", culture);
            labelTitleCalendarMonth.Text = month.ToUpper();
        }

        private void displayDays(DateTime date)
        {

            DateTime startOfTheMonth = new DateTime(date.Year, date.Month, 1);

            int days = DateTime.DaysInMonth(date.Year, date.Month);


            int dayOfWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank(null);
                flowLayoutPanelMonth.Controls.Add(userControlBlank);

            }

            for (int i = 1; i <= days; i++)
            {

                DateTime day = new DateTime(date.Year, date.Month, i);

                UserControl userControl = itIsADayOf(day);

                MarkPlannedDays(userControl, day);
                MarkToday(userControl, day);

                flowLayoutPanelMonth.Controls.Add(userControl);

            }

            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank(null);
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }

        }
        #endregion
        #region MarkDays
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdDay == day.Day)
                {
                    userControl.BackColor = Color.Orange;
                }
            }
        }

        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }

        private UserControl itIsADayOf(DateTime date)
        {
            //add holidays to calendar --dont work

            //int year = date.Year;
            //string countryCode = "PL";

            //CultureInfo culture = new CultureInfo(countryCode);
            //Calendar calendar = culture.Calendar;

            //DateTime[] holidays = calendar.GetHolidays(year);


            if (date.DayOfWeek != 0)  //|| !holidays.Contains(date)
            {
                UserControlDay userControlDay = new UserControlDay(date, null);
                userControlDay.ControlClicked += UserControlDay_ControlClicked;
                return userControlDay;
            }
            else
            {
                UserControlBlank userControlBlank = new UserControlBlank(date);
                userControlBlank.BackColor = Color.Gainsboro;
                return userControlBlank;
            }
        }
        #endregion
        private void UserControlDay_ControlClicked(object sender, DateTime selectedDate)   // Date From UserControlDay
        {
            RemoveRowsInDataGridView();
            UpdateDateInLabel(selectedDate);
            displayListInDataGridView.Clear();


            int calendarId = CalendarService.GetIdFromDate(selectedDate);

            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();


            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (true)
                {
                    DisplayDataInDataGridView(appointments, calendarId, selectedDate);
                }
            }

        }

        #region DateGridView
        private void DisplayDataInDataGridView(List<DoctorsDayPlanModel> appointments, int calendarId, DateTime selectedDate)
        {
            dataGridViewAppointments.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdDay == selectedDate.Day)
                {
                    int index = dataGridViewAppointments.Rows.Add(OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                        AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                        PatientService.GetPatientById((int)appointment.PatientId).ToString());


                    dataGridViewAppointments.Rows[index].Tag = appointment;
                }

            }
        }
        private void RemoveRowsInDataGridView()
        {
            dataGridViewAppointments.Rows.Clear();
        }

        #endregion
        private void UpdateDateInLabel(DateTime date)
        {
            labelDate.Text = "Selected date: " + date.ToShortDateString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ToDashboard();
        }

        private void ToDashboard()
        {
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();
            this.Close();
        }

    }
}