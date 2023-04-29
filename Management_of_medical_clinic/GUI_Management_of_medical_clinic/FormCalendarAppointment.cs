using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormCalendarAppointment : Form
    {
        EmployeeModel currentEmployee;
        public FormCalendarAppointment(EmployeeModel currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
        }

        DateTime displayMonth = DateTime.Today;


        private void FormCalendarAppointment_Load(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();
            displayMonth = DateTime.Now;
            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonPreviousMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(-1);

            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonNextMonth_Click(object sender, EventArgs e)
        {
            RemoveControlPanels();

            displayMonth = displayMonth.AddMonths(+1);

            displayDays(displayMonth);
            ChangeTitle(labelTitleCalendar, displayMonth);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.ShowDialog();
            this.Close();
        }

        #region

        private void RemoveControlPanels()
        {
            flowLayoutPanelMonth.Controls.Clear();
        }

        private void ChangeTitle(Label label, DateTime date)
        {
            string year = date.Year.ToString();
            string month = date.ToString("MMMM");

            label.Text = year + " - " + month;
        }



        private void displayDays(DateTime date)
        {

            DateTime startOfTheMonth = new DateTime(date.Year, date.Month, 1);

            int days = DateTime.DaysInMonth(date.Year, date.Month);


            int dayOfWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek);

            for (int i = 0; i < dayOfWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }



            for (int i = 1; i <= days; i++)
            {

                DateTime day = new DateTime(date.Year, date.Month, i);

                UserControlDay userControlDay = new UserControlDay(day);

                //userControlDay.ControlClicked += UserControlDay_ControlClicked;

                flowLayoutPanelMonth.Controls.Add(userControlDay);
            }


            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }


        }

        private void UserControlDay_ControlClicked(object sender, DateTime selectedDate)   // Date From UserControlDay
        {
            labelDate.Text = selectedDate.ToString("d");
        }


        #endregion


        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            if (labelDate.Text == "Select term") { MessageBox.Show("Choose term"); return; }

            FormAppointmentAdd formAppointmentAdd = new FormAppointmentAdd(DateTime.Parse(labelDate.Text), currentEmployee);
            //this.Hide();
            formAppointmentAdd.ShowDialog();
            //this.Close();
        }

    }
}