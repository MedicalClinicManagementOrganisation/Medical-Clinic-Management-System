using Console_Management_of_medical_clinic.Data.Enums;
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
    public partial class FormDoctorCalendarAcceptConfirm : Form
    {
        List<int> listID;
        EmployeeModel currentUser;
        string selectedDate;

        public FormDoctorCalendarAcceptConfirm(List<int> listID, EmployeeModel currentUser, string selectedDate)
        {
            InitializeComponent();
            this.listID = listID;
            this.currentUser = currentUser;
            this.selectedDate=selectedDate;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Canceled calendar's accepting");
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
               DoctorsPlanService.ChangeAppointmentStatusToAccepted(listID, currentUser);
            }
            CalendarService.ChangeCalendarStatusToAccepted(cal_id);
            MessageBox.Show("Calendar is accepted");
            

            Hide();
            Close();
            FormDoctorCalendar formDoctorCalendar = new FormDoctorCalendar(currentUser);
            formDoctorCalendar.Show();
        }

    }
}
