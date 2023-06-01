using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System.Globalization;
using System.Numerics;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
//using System.Globalization.Extensions;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarInChosenMonth : Form
    {
        EmployeeModel employee;
        DateTime parsedDate;
        string selectedDate;
        List<int> listID;

        public FormDoctorCalendarInChosenMonth(EmployeeModel employee, string selectedDate)
        {
            InitializeComponent();
            this.employee = employee;
            this.selectedDate = selectedDate;
            string date = Convert.ToDateTime(selectedDate).ToString("d");
            int data = CalendarService.GetCalendarIdByDate(date);
            listID = DoctorsPlanService.GetIDDayDoctorByCalendarID(data);
            DateTime.TryParse(selectedDate, out this.parsedDate);

        }

        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();
        List<DoctorsDayPlanModel> displayAllDoctorsAppointments = new List<DoctorsDayPlanModel>();

        private void FormDoctorCalendarInChosenMonth_Load(object sender, EventArgs e)
        {
            ReloadActiveForm();
        }




        private void buttonDisplayAppointments_Click(object sender, EventArgs e)
        {
            FormListAppointment formListAppointment = new FormListAppointment(employee);
            this.Hide();
            formListAppointment.ShowDialog();
            this.Close();
        }

        private void UserControlDay_ControlClicked(object sender, DateTime date)   // Date From UserControlDay
        {
            RemoveRowsInDataGridView(dataGridViewTerms);
            RemoveRowsInDataGridView(dataGridViewOtherAppointments);
            UpdateDateInLabel(date);
            displayListInDataGridView.Clear();
            displayAllDoctorsAppointments.Clear();
            string timeTerm;

            int calendarId = CalendarService.GetIdFromDate(date);

            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            List<DoctorsDayPlanModel> selectedAppointments = CalendarAppointmentService.appointmentInSelectedDate(appointments, date, calendarId);

            foreach (DoctorsDayPlanModel appointment in selectedAppointments) //change new
            {
                if (appointment.PatientId == null && appointment.Status == EnumAppointmentStatus.New && employee.IdEmployee == appointment.IdEmployee)
                {
                    AddItemToDataGridView(appointment, dataGridViewTerms);
                    displayListInDataGridView.Add(appointment);
                }
                if (employee.IdEmployee != appointment.IdEmployee) //tho idk if there should be accepted terms visible
                {
                    AddItemToDataGridView(appointment, dataGridViewOtherAppointments);
                    displayAllDoctorsAppointments.Add(appointment);

                }
            }

            dataGridViewTerms.ClearSelection();
            dataGridViewOtherAppointments.ClearSelection();
        }

        #region Calendar

        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void ChangeTitle(DateTime date)
        {
            string year = date.Year.ToString();

            CultureInfo culture = new CultureInfo("en-US");
            string month = date.ToString("MMMM", culture);

            labelTitleCalendar_Month.Text = month.ToUpper();
            labelTitleCalendar_Year.Text = year;
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
        private void MarkToday(UserControl userControl, DateTime day)
        {
            if (day.Date == DateTime.Today.Date)
            {
                userControl.BackColor = Color.LightBlue;
            }
        }
        private void MarkPlannedDays(UserControl userControl, DateTime day)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsData();
            int calendarId = CalendarService.GetCalendarIdByDate(Convert.ToDateTime(selectedDate).ToString("d"));

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == employee.IdEmployee && appointment.IdDay == day.Day
                    && appointment.IdCalendar == calendarId && appointment.Status == EnumAppointmentStatus.New //new
                    && appointment.PatientId == null)
                {
                    userControl.BackColor = Color.Orange;
                }
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

        private void UpdateDateInLabel(DateTime date)
        {
            labelSelectedDate.Text = date.ToString("d");
            selectedDate = date.ToString("d");
        }

        #endregion

        #region DataGridView
        private void AddItemToDataGridView(DoctorsDayPlanModel appointment, DataGridView dataGrid)
        {
            string timeTerm;
            OfficeModel room;

            timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
            room = OfficeService.GetOfficeById(Convert.ToInt32(appointment.IdOffice));
            int idDoctorsDayPlan = (int)appointment.IdDoctorsDayPlan;
            EmployeeModel employee = EmployeeModel.FindEmployee((int)appointment.IdEmployee);

            int index;

            if (dataGrid == dataGridViewTerms) //doctor's terms
            {
                index = dataGrid.Rows.Add(timeTerm, room.Number, idDoctorsDayPlan);
                dataGrid.Rows[index].Tag = appointment;
            }
            else //other doctors' duties in chosen day
            {
                index = dataGrid.Rows.Add(employee.FirstName + " " + employee.LastName, timeTerm, room.Number, idDoctorsDayPlan);
                dataGrid.Rows[index].Tag = appointment;
            }

        }

        private void RemoveRowsInDataGridView(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
        }
        #endregion

        #region Sort

        private void panelPatient_Click(object sender, EventArgs e)
        {
            SortByPatient(dataGridViewTerms);
        }

        private void labelPatient_Click(object sender, EventArgs e)
        {
            SortByPatient(dataGridViewTerms);
        }

        private void panelTime_Click(object sender, EventArgs e)
        {
            SortByTime(dataGridViewTerms);
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            SortByTime(dataGridViewTerms);
        }
        void SortByTime(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByTerm(displayListInDataGridView);
            dataGridViewTerms.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }

        void SortByDoctor(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByDoctorLastName(displayListInDataGridView);
            dataGridViewTerms.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }

        void SortByPatient(DataGridView dataGrid)
        {
            List<DoctorsDayPlanModel> result = CalendarAppointmentService.SortByPatientLastName(displayListInDataGridView);
            dataGridViewTerms.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in result)
            {
                AddItemToDataGridView(appointment, dataGrid);
            }
        }
        #endregion

        #region LeftPanel
        private void buttonAcceptCalendar_Click(object sender, EventArgs e)
        {
            FormDoctorCalendarAcceptConfirm formCalendarAcceptConfirm = new FormDoctorCalendarAcceptConfirm(listID, employee, selectedDate);
            formCalendarAcceptConfirm.ShowDialog();
            Hide();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(employee);
            this.Hide();
            formDoctorDashboard.ShowDialog();
            this.Close();
        }
        private void buttonRejectCalendar_Click(object sender, EventArgs e)
        {
            FormDoctorCalendarRejectConfirm formCalendarRejectConfirm = new FormDoctorCalendarRejectConfirm(selectedDate, employee, listID);
            formCalendarRejectConfirm.ShowDialog();
            Hide();
        }

        #endregion

        private void dataGridViewAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public List<int> GetSelectedColumnData(int columnIndex)
        {
            List<int> selectedColumnData = new List<int>();

            foreach (DataGridViewCell selectedCell in dataGridViewTerms.SelectedCells)
            {
                if (selectedCell.ColumnIndex == columnIndex)
                {
                    int cellValue = Convert.ToInt32(selectedCell.Value);
                    selectedColumnData.Add(cellValue);
                }
            }
            return selectedColumnData;
        }
        private void ReloadActiveForm()
        {
            DateTime displayMonth_date = Convert.ToDateTime(selectedDate);
            RemoveControlPanels();
            displayDays(displayMonth_date);
            ChangeTitle(displayMonth_date);
        }

        private void button_acceptAppointments_Click(object sender, EventArgs e)
        {

        }

        private void button_cancelAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTerms.SelectedRows.Count < 1)
                return;


            //when rejecting, term is deleted from database
            List<int> idDoctor = GetSelectedColumnData(2); //hidden column with idDoctorDayPlan
            DialogResult result = MessageBox.Show("Do you want to reject chosen term(s)?", "Confirm rejection", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DoctorsPlanService.ChangeAppointmentStatusToRejected(idDoctor, employee);
                MessageBox.Show("Chosen term(s) are now rejected.");
                /* DateTime month = Convert.ToDateTime(selectedDate);
                 int id_cal = CalendarService.GetIdFromDate(month);*/

            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Canceled rejecting terms");
            }

            dataGridViewTerms.ClearSelection();
            dataGridViewTerms.Rows.Clear();
            dataGridViewTerms.Refresh();
            dataGridViewOtherAppointments.ClearSelection();
            dataGridViewOtherAppointments.Rows.Clear();
            dataGridViewOtherAppointments.Refresh();
            ReloadActiveForm();

        }

        private void button_createTerm_Click(object sender, EventArgs e)
        {
            if (selectedDate.Length != 0)
            {
                MessageBox.Show(selectedDate);
                FormDoctorCalendarModify formDoctorCalendarModify = new FormDoctorCalendarModify(null, employee, true, /*DateTime.Parse(selectedDate)*/ selectedDate);
                this.Hide();
                formDoctorCalendarModify.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("A term needs to be selected");
            }
        }

        private void button_modifyAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewTerms.SelectedRows.Count != 1)
                return;

            DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewTerms.SelectedRows[0].Tag;

            FormDoctorCalendarDetails edit = new FormDoctorCalendarDetails(appointment, employee, selectedDate);

            this.Hide();
            edit.ShowDialog();
            this.Close();
        }
    }
}