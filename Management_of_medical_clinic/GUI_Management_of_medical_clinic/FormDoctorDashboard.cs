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
            label2.Text = "Today is " + DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void FormDoctorDashboard_Load(object sender, EventArgs e)
        {
            InsertDataDataGridView();
        }
        #region DataGridView
        private void InsertDataDataGridView()
        {
            dataGridViewVisits.Rows.Clear();

            List<DoctorsDayPlanModel> appointments = DoctorsPlanService.GetDoctorsPlanData();
            int calendarId = CalendarService.GetIdFromDate(DateTime.Now.Date);


            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                if (appointment.IdEmployee == currentUser.IdEmployee && appointment.IdCalendar == calendarId && appointment.IdDay == DateTime.Now.Day)
                {
                    string timeTerm = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
                    Patient? patient = PatientService.GetPatientsData().FirstOrDefault(p => p.PatientId == appointment.PatientId);

                    if (patient != null)
                    {
                        int index = dataGridViewVisits.Rows.Add(OfficeService.GetOfficeById((int)appointment.IdOffice).Number,
                            AppointmentService.GetTermByTermId(appointment.IdOfTerm).ToString(),
                            appointment.Status,
                            PatientService.GetPatientById((int)appointment.PatientId).ToString(),
                            patient.PatientId);

                        dataGridViewVisits.Rows[index].Tag = appointment;
                    }
                }
            }
            dataGridViewVisits.ClearSelection();
        }
        private void dataGridViewVisits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVisits.ReadOnly = true;

            if (e.RowIndex >= 0 && dataGridViewVisits.Rows.Count > 0)
            {
                dataGridViewVisits.ClearSelection();

                DataGridViewRow row = dataGridViewVisits.Rows[e.RowIndex];
                row.Selected = true;

                int patientName = Convert.ToInt32(row.Cells[4].Value);
                if (patientName != 0)
                {
                    /*
                    Patient patient = Patient.FindPatient(patientName);
                    labelFullName.Text = patient.FirstName + " " + patient.LastName;
                    labelPESEL.Text = patient.PESEL;
                    labelSex.Text = patient.Sex.ToString();
                    labelBirthday.Text = patient.BirthDate.ToString();*/
                }
                else
                {
                    MessageBox.Show("Nie masz wizyt na dzisiaj");
                }
            }
        }
        #endregion
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
