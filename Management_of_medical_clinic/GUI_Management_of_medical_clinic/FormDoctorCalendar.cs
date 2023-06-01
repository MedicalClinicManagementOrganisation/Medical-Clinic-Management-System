using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using GUI_Management_of_medical_clinic;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendar : Form
    {
        EmployeeModel currentUser;
        DoctorsDayPlanModel appointment;
        public FormDoctorCalendar(EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        public FormDoctorCalendar(EmployeeModel currentUser, DoctorsDayPlanModel appointment)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.appointment = appointment;
        }

        List<DoctorsDayPlanModel> displayListInDataGridView = new List<DoctorsDayPlanModel>();

        private void FormDoctorCalendar_Load(object sender, EventArgs e)
        {
            list_ofCalendars.Items.Clear();
            list_ofCalendars.Refresh();

            List<DoctorsDayPlanModel> doctorsDayPlanModels = DoctorsPlanService.GetDoctorsPlanData();
            List<CalendarModel> listID = CalendarService.GetCalendarData();
            foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
            {
                int idCalendar = (int)doctorsDayPlanModel.IdCalendar;

                CalendarModel calendar = listID.FirstOrDefault(x => x.IdCalendar == idCalendar);
                int month = Convert.ToDateTime(calendar.DateReference).Month;

                //calendar for present or future months                  
                if (month >= DateTime.Today.Month && doctorsDayPlanModel.IdEmployee == currentUser.IdEmployee
                && doctorsDayPlanModel.Status == EnumAppointmentStatus.New && listID.Count > 0)
                {
                    DateTime date = Convert.ToDateTime(calendar.DateReference);
                    list_ofCalendars.Items.Add(date.ToString("MM-yyyy"));
                }
            }
            HashSet<string> uniqueItems = new HashSet<string>();
            for (int i = list_ofCalendars.Items.Count - 1; i >= 0; i--) //deleting duplicated datas
            {
                string item = list_ofCalendars.Items[i].Text;
                if (!uniqueItems.Contains(item))
                {
                    uniqueItems.Add(item);
                }
                else
                {
                    list_ofCalendars.Items.RemoveAt(i);
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.ShowDialog();
            this.Close();
        }

        private void listofCalendars_DoubleClick(object sender, EventArgs e)
        {
            foreach (int selectedIndex in list_ofCalendars.SelectedIndices)
            {
                string item = list_ofCalendars.Items[selectedIndex].Text;
                string dateString = item.ToString();
                FormDoctorCalendarInChosenMonth formDoctorCalendarInChosenMonth = new FormDoctorCalendarInChosenMonth(currentUser, dateString);
                formDoctorCalendarInChosenMonth.Show();
            }

        }
    }
}