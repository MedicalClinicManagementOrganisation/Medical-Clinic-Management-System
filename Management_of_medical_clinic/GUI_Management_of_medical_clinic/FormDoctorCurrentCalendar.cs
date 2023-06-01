using Console_Management_of_medical_clinic.Data.Enums;
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
        private List<DoctorsDayPlanModel> selectedAppointments = new List<DoctorsDayPlanModel>();
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
            string year = date.Year.ToString();

            labelTitleCalendarMonth.Text = month.ToUpper();
            labelTitleCalendarYear.Text = year;
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

            int calendarId = CalendarService.GetIdFromDate(day);

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee
                    && appointment.IdDay == day.Day
                    && calendarId == appointment.IdCalendar
                    && appointment.Status == EnumAppointmentStatus.Accepted)
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


            //List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetScheduledAppointments();
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();


            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (calendarId == appointment.IdCalendar)
                {
                    DisplayDataInDataGridView(appointments, calendarId, selectedDate);
                }
            }

        }

        #region DateGridView
        int calendarId = CalendarService.GetIdFromDate(DateTime.Now.Date);
        private void dataGridViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAppointments.Rows[e.RowIndex];
                DoctorsDayPlanModel appointment = row.Tag as DoctorsDayPlanModel;
                DateTime term = Convert.ToDateTime(AppointmentService.GetTermByTermId(appointment.IdOfTerm));
                if (appointment != null)
                {
                    if (appointment.IdCalendar == calendarId)
                    {
                        //                               chаnge here v !
                        if (appointment.IdDay == DateTime.Now.Day - 11 && term.TimeOfDay > DateTime.Now.TimeOfDay)
                        {
                            if (row.Selected)
                            {
                                if (!selectedAppointments.Contains(appointment))
                                {
                                    selectedAppointments.Add(appointment);
                                }
                            }
                            else
                            {
                                selectedAppointments.Remove(appointment);
                            }
                        } //                              chаnge here v 
                        else if (appointment.IdDay > DateTime.Now.Day - 11)
                        {
                            if (row.Selected)
                            {
                                if (!selectedAppointments.Contains(appointment))
                                {
                                    selectedAppointments.Add(appointment);
                                }
                            }
                            else
                            {
                                selectedAppointments.Remove(appointment);
                            }

                        }
                        else
                        {
                            MessageBox.Show("You can't pick this time out to cancelling , because appointment already was");
                        }

                    }
                }
                else if (appointment.IdCalendar > calendarId)
                {

                    if (row.Selected)
                    {
                        if (!selectedAppointments.Contains(appointment))
                        {
                            selectedAppointments.Add(appointment);
                        }
                    }
                    else
                    {
                        selectedAppointments.Remove(appointment);
                    }


                }
            }
        }
        private void DisplayDataInDataGridView(List<DoctorsDayPlanModel> appointments, int calendarId, DateTime selectedDate)
        {
            dataGridViewAppointments.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdDay == selectedDate.Day && calendarId == appointment.IdCalendar)
                {
                    int index = dataGridViewAppointments.Rows.Add(OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                        AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                        appointment.Status,
                        PatientService.GetPatientById((int)appointment.PatientId).ToString());


                    dataGridViewAppointments.Rows[index].Tag = appointment;
                }

            }

            dataGridViewAppointments.ClearSelection();
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

        private void button_ShowVisits_Click(object sender, EventArgs e)
        {

            FormDoctorAppointmentList formDoctorAppointmentList = new FormDoctorAppointmentList(currentUser, displayMonth);
            this.Hide();
            formDoctorAppointmentList.ShowDialog(this);
            this.Show();
        }

        private void CorrectDateToCancel()
        {

        }
        private void button_cancelAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointments.Count() != 0)
            {
                FormDoctorCancelVisit cancelVisit = new FormDoctorCancelVisit(selectedAppointments, currentUser);
                cancelVisit.ShowDialog();
            }
            else
            {
                MessageBox.Show("You have to select an appointment");
            }
        }

        
    }
}