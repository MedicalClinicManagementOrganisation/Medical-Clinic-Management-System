using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormCalendarsList : Form
    {
        EmployeeModel currentUser;
        CalendarService _calendarService = new();
        List<string> statusList = new List<string>()
        { "Active", "Inactive", "" };

        public FormCalendarsList(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            dataGridViewCalendars.DataSource = _calendarService.GetAll();
            dataGridViewCalendars.Columns["NumberOfDoctors"].HeaderText = "Number of doctors";
            dataGridViewCalendars.Columns["NumberOfAcceptedDoctors"].HeaderText = "Number of accepted doctors";
            comboBoxStatus.DataSource = statusList;
            comboBoxStatus.SelectedIndex = 2;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
            Close();
        }


        private void buttonDuplicateCalendar_Click(object sender, EventArgs e)
        {
            FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentUser, CalendarService.GetCalendarById((int)dataGridViewCalendars.CurrentRow.Cells[0].Value));
            formCalendar.ShowDialog();
            Close();
        }


        private void buttonReviewCalendar_Click(object sender, EventArgs e)
        {
            FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentUser, (int)dataGridViewCalendars.CurrentRow.Cells[0].Value);
            formCalendar.ShowDialog();
            Close();
        }

        private void buttonRemoveCalendar_Click(object sender, EventArgs e)
        {
            // TODO: Open a window with a confirmation if someone really wants to delete selected calendar
            try
            {
                int calendarId = int.Parse(dataGridViewCalendars.CurrentRow.Cells[0].Value.ToString());

                FormCalendarDelete formCalendarDelete = new FormCalendarDelete(calendarId);
                formCalendarDelete.ShowDialog();
                dataGridViewCalendars.DataSource = null;
                dataGridViewCalendars.DataSource = _calendarService.GetAll();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilterCalendars_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.DataSource = _calendarService.Filter(textBoxDateReference.Text, (string)comboBoxStatus.SelectedValue);
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.DataSource = _calendarService.GetAll();
        }

        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.DataSource = _calendarService.Sort(textBoxDateReference.Text, true);
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            dataGridViewCalendars.DataSource = _calendarService.Sort(textBoxDateReference.Text, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDoctorsPlanCalendar formCalendar = new(currentUser);
            formCalendar.ShowDialog();
            Close();
        }

        private void FormCalendarsList_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditCalendar_Click(object sender, EventArgs e)
        {
            if ((bool)dataGridViewCalendars.CurrentRow.Cells[2].Value)
            {
                MessageBox.Show("It is not possible to change active calendars. Check if the selected calendar is right.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormCalendarEdit formCalendar = new FormCalendarEdit(currentUser, CalendarService.GetCalendarById((int)dataGridViewCalendars.CurrentRow.Cells[0].Value), new FormCalendarsList(currentUser));
            formCalendar.ShowDialog();
            Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> doctorsDayPlanModels = CalendarAppointmentService.GetAppointmentsWithPatients();

            int count = 0;

            foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
            {
                DateTime date = CalendarService.GetDateByIdCalendar((int)doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdDay);
                string term = AppointmentService.GetTermByTermId((int)doctorsDayPlanModel.IdOfTerm);
                TimeSpan time = TimeSpan.ParseExact(term, "hh\\:mm", null);

                if (date <= DateTime.Now.Date && time <= DateTime.Now.TimeOfDay && (doctorsDayPlanModel.Status == EnumAppointmentStatus.Accepted ||
                    doctorsDayPlanModel.Status == EnumAppointmentStatus.Scheduled || doctorsDayPlanModel.Status == EnumAppointmentStatus.Confirmed))
                {
                    FormConfirmCancelAppointment clear = new FormConfirmCancelAppointment("clear from appointment", currentUser, doctorsDayPlanModel);
                    clear.ShowDialog();
                }
                else
                {
                    count++;
                }
            }

            if (count == doctorsDayPlanModels.Count)
            {
                string msg1 = "The calendars are already cleared.";
                FormMessage FormMessage1 = new FormMessage(msg1);
                FormMessage1.ShowDialog();
                return;
            }
        }
    }
}
