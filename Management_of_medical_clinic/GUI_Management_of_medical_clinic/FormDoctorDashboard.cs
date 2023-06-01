using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic;
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
    public partial class FormDoctorDashboard : Form
    {
        EmployeeModel currentUser;

        public FormDoctorDashboard(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            label1.Text = "Welcome, " + currentUser.FirstName;
        }

        private void FormDoctorDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Room", "Room");
            dataGridView1.Columns.Add("Hour", "Hour");
            dataGridView1.Columns.Add("Patient", "Patient");
            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("PatientId", "PatientId");


            List<DoctorsDayPlanModel> appointments = DoctorsPlanService.GetDoctorsPlanData();
            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdCalendar == 1 && appointment.IdDay == 10)//DateTime.Now.Day)
                {
                    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
                    Patient? patient = PatientService.GetPatientsData().FirstOrDefault(p => p.PatientId == appointment.PatientId);

                    if (patient != null)
                    {
                        dataGridView1.Rows.Add(appointment.IdOffice, timeTerm, patient.LastName, appointment.IdDay, patient.PatientId);
                    }
                }
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int patientName = (int)row.Cells[4].Value;

                Patient patient = Patient.FindPatient(patientName);
                labelFullName.Text = patient.FirstName + " " + patient.LastName;
                labelPESEL.Text = patient.PESEL;
                labelSex.Text = patient.Sex.ToString();
                labelBirthday.Text = patient.BirthDate.ToString();

            }

        }

        #region Buttons
        private void button_patients_Click(object sender, EventArgs e)
        {
            
            FormDoctorPatientList formDocPatientList = new FormDoctorPatientList(currentUser);
            this.Hide();
            formDocPatientList.ShowDialog(this);
            this.Show();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorCalendar formDoctor = new FormDoctorCalendar(currentUser);
            formDoctor.ShowDialog();
            this.Close();

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void buttonCurrentCalendar_Click(object sender, EventArgs e)
        {
            IsCalendarActiveForCurrentMonth();
        }


        private void IsCalendarActiveForCurrentMonth()
        {
            ToFormCurrentCalendar();
            bool isCurrentCalendar = false;
            string currentMonthYear = DateTime.Today.ToString("MM-yyyy");


            List<CalendarModel> calendars = CalendarService.GetCalendarData();
            foreach (CalendarModel calendar in calendars)
            {
                if (calendar.Active == true &&
                    calendar.DateReference == currentMonthYear) //Comparison with the current year and mont
                {
                    isCurrentCalendar = true;
                    break;
                }
            }

            if (isCurrentCalendar)
            {
                ToFormCurrentCalendar();
            }
            else
            {
                MessageBox.Show("No active calendar for the current month");
            }

        }
        private void ToFormCurrentCalendar()
        {
            FormDoctorCurrentCalendar formCurrentCalendar = new FormDoctorCurrentCalendar(currentUser);
            this.Hide();
            formCurrentCalendar.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
