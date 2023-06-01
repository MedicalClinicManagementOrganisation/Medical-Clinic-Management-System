using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Logic;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using GUI_Management_of_medical_clinic;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormPatientList : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormPatientList(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            DisplayPatientsList();
            currentUser = employee;
        }

        public void DisplayPatientsList()
        {
            dataGridViewPatientList.DataSource = patientService.GetPatientData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            Hide();
            formMenu.ShowDialog();
            Close();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, null);
            Hide();
            formAddEditPatient.ShowDialog();
            Close();
        }

        private void buttonActivatePatient_Click(object sender, EventArgs e)
        {
            Patient patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            if (patient.IsActive == true)
            {
                string msg = "Patient is active!";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            FormChangeStatusOfPatient activate = new FormChangeStatusOfPatient("activate", patient, currentUser);
            activate.ShowDialog();
        }

        private void buttonDeactivatePatinet_Click(object sender, EventArgs e)
        {
            Patient patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            if (patient.IsActive == false)
            {
                string msg = "Patient is deactive!";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            FormChangeStatusOfPatient deactivate = new FormChangeStatusOfPatient("deactivate", patient, currentUser);
            deactivate.ShowDialog();
        }

        private void buttonRemovePatient_Click(object sender, EventArgs e)
        {
            Patient patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            List<DoctorsDayPlanModel> doctorsDayPlanModels = CalendarAppointmentService.GetAppointmentsWithPatients();

            foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
            {
                DateTime date = CalendarService.GetDateByIdCalendar((int)doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdDay);
                DateTime today = DateTime.Now;

                if (doctorsDayPlanModel.PatientId == patient.PatientId && date >= today)
                {
                    string msg2 = "You cannot delete a patient who has an appointment scheduled.";
                    FormMessage FormMessage2 = new FormMessage(msg2);
                    FormMessage2.ShowDialog();
                    return;
                }
            }

            string msg = "A deleted patient cannot be restored!";
            FormMessage FormMessage = new FormMessage(msg);
            FormMessage.ShowDialog();

            FormChangeStatusOfPatient remove = new FormChangeStatusOfPatient("remove", patient, currentUser);
            remove.ShowDialog();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientList.SelectedRows.Count == 0)
            {
                return;
            }

            Patient patient = new Patient();
            patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);

            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, patient);
            Hide();
            formAddEditPatient.ChangeTitle("Edit patient");
            formAddEditPatient.ShowDialog();
            Close();
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientList.SelectedRows.Count == 0)
            {
                return;
            }

            ShowDetails();
        }

        private void ShowDetails()
        {
            Patient patient = new Patient();
            patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            FormAddEditPatient formAddEditPatient = new FormAddEditPatient(currentUser, patient);
            formAddEditPatient.ChangeTitle("Details");
            formAddEditPatient.ReadOnlyControls();
            formAddEditPatient.buttonAddEditPatient.Visible = false;
            Hide();
            formAddEditPatient.ShowDialog();
            Close();
        }

        public List<Patient> GetSortedPatientData()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderBy(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientData()
        {
            List<Patient> sortedPatientList = GetSortedPatientData();
            dataGridViewPatientList.DataSource = sortedPatientList;
        }

        public List<Patient> GetSortedPatientDataDSC()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Patients.OrderByDescending(p => p.LastName).ToList();
            }
        }

        private void DisplaySortedPatientDataDSC()
        {
            List<Patient> sortedPatientList = GetSortedPatientDataDSC();
            dataGridViewPatientList.DataSource = sortedPatientList;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplaySortedPatientData();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplaySortedPatientDataDSC();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Clear Filters
            DisplayPatientsList();
            textBox1_Name.Text = null;
            TextBox_PESEL.Text = null;
            dateTimePicker1.Text = null;
            dateTimePicker2.Text = null;
        }

        private void buttonShowFilters_Click(object sender, EventArgs e)
        {
            //Filters
            PatientService patientService = new PatientService();
            List<Patient> FiltredPatients = patientService.FilterPatient(textBox1_Name.Text, TextBox_PESEL.Text);
            dataGridViewPatientList.DataSource = FiltredPatients;
        }

        private void buttonViewAppointments_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            Hide();
            formCalendarAppointment.ShowDialog();
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}