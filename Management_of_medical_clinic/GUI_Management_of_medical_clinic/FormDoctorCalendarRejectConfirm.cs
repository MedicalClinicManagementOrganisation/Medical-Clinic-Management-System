using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarRejectConfirm : Form
    {
        EmployeeModel currentUser;
        string selectedDate;
        List<int> listID;

        public FormDoctorCalendarRejectConfirm(string selectedDate, EmployeeModel currentUser, List<int> listID)
        {
            InitializeComponent();
            this.selectedDate=selectedDate;
            this.currentUser = currentUser;
            this.listID = listID;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled calendar's rejecting");
            Hide();
            Close();
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            formDoctorCalendar.Show();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string date = Convert.ToDateTime(selectedDate).ToString("d");
            int cal_id = CalendarService.GetCalendarIdByDate(date);
            List<DoctorsDayPlanModel> list = DoctorsPlanService.GetAppointmentsDetailsByAppointmentID(listID);
            foreach (DoctorsDayPlanModel terms in list)
            {
                DoctorsPlanService.ChangeAppointmentStatusToRejected(listID, currentUser);
            }
            CalendarService.ChangeCalendarStatusToRejected(cal_id);
            MessageBox.Show("Calendar is rejected");
            Hide();
            Close();
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            formDoctorCalendar.Show();

            
        }
    }
}
