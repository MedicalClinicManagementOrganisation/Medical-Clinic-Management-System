namespace Calendar
{
    public partial class FormCalendar : Form
    {
        public FormCalendar()
        {
            InitializeComponent();
        }

        DateTime displayMonth = DateTime.Today;


        private void FormCalendar_Load(object sender, EventArgs e)
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
            FormCalendar.ActiveForm.Close();
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
            // bierzemy pierwszy dzie� miesi�ca
            DateTime startOfTheMonth = new DateTime(date.Year, date.Month, 1);

            // liczymy ilo�� dni w miesi�cu aby wiedzie� ile paneli trzeba pokaza�
            int days = DateTime.DaysInMonth(date.Year, date.Month);


            // konwertujemy startOfTheMonth na int, dzie� tygodnia
            // -- w kt�rym miejscu panel ma si� pojawi�, jak 3 to �roda itp
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
                flowLayoutPanelMonth.Controls.Add(userControlDay);
            }

            // liczymy ile trzeba doda� pustych paneli,aby uzupe�ni� kalendarz
            int completeControls = dayOfWeek + days;

            for (int i = completeControls; i < 42; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                flowLayoutPanelMonth.Controls.Add(userControlBlank);
            }
        }



        #endregion


    }
}