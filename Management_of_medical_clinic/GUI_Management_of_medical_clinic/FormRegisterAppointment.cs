using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormRegisterAppointment : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;
        public AppointmentService appointmentService;

        bool isEdit;

        DoctorsDayPlanModel appointment;

        public FormRegisterAppointment(EmployeeModel user, DoctorsDayPlanModel? appointment)
        {
            InitializeComponent();
            dataGridView_app_doctor.ClearSelection();
            DisplayDoctor();
            DisplayPatient();
            AddSpecializationToCombobox();


            this.appointment = appointment;
            this.currentUser = user;
        }

        public FormRegisterAppointment(EmployeeModel user, DoctorsDayPlanModel appointment, bool isEdit)
        {
            InitializeComponent();
            dataGridView_app_doctor.ClearSelection();


            DisplayDoctor();
            DisplayPatient();
            AddSpecializationToCombobox();

            this.appointment = appointment;
            this.currentUser = user;
            this.isEdit = isEdit;

        }

        public void DisplayDoctor()
        {

            using AppDbContext context = new();
            var doctors = context.DbEmployees
                .Include(d => d.SpecializationModel)
                .Where(d => d.Role == EnumEmployeeRoles.MedicalDoctor)
                .Select(
                    d => new
                    {
                        d.IdEmployee,
                        d.FirstName,
                        d.LastName,
                        Specialization = d.SpecializationModel.Name
                    }
                        )
                .ToList();
            string searchedDoctor = textBox1_doctor.Text;
            string searchedSpecializaton = comboBoxDoctorSpecialization.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(searchedSpecializaton))
            {
                doctors = doctors.Where(d => d.Specialization == searchedSpecializaton).ToList();
            }
            if (!string.IsNullOrEmpty(searchedDoctor))
            {
                searchedDoctor = searchedDoctor.ToLower();
                doctors = doctors.Where(
                        d =>
                        (d.FirstName + " " + d.LastName).ToLower().Contains(searchedDoctor)).ToList();

            }

            if (dataGridView_app_doctor.Columns.Count == 0)
            {

                dataGridView_app_doctor.AutoGenerateColumns = false;
                dataGridView_app_doctor.Columns.Add("IdEmployee", "ID");
                dataGridView_app_doctor.Columns.Add("FirstName", "First Name");
                dataGridView_app_doctor.Columns.Add("LastName", "Last Name");
                dataGridView_app_doctor.Columns.Add("Specialization", "Specialization");
            }


            dataGridView_app_doctor.Columns["IdEmployee"].DataPropertyName = "IdEmployee";
            dataGridView_app_doctor.Columns["FirstName"].DataPropertyName = "FirstName";
            dataGridView_app_doctor.Columns["LastName"].DataPropertyName = "LastName";
            dataGridView_app_doctor.Columns["Specialization"].DataPropertyName = "Specialization";

            dataGridView_app_doctor.Columns["FirstName"].Width = 250;
            dataGridView_app_doctor.Columns["LastName"].Width = 250;
            dataGridView_app_doctor.Columns["Specialization"].Width = 250;

            dataGridView_app_doctor.Columns["IdEmployee"].Visible = false;

            dataGridView_app_doctor.DataSource = doctors;

            //dataGridView_app_doctor.Rows[0].Selected = true;
        }

        public void DisplayPatient()
        {
            List<Patient> patients = PatientService.GetPatientsData();


            if (dataGridView_app_Patient.Columns.Count == 0)
            {
				dataGridView_app_Patient.AutoGenerateColumns = false;
				dataGridView_app_Patient.Columns.Add("PatientId", "ID");
				dataGridView_app_Patient.Columns.Add("FirstName", "First Name");
				dataGridView_app_Patient.Columns.Add("LastName", "Last Name");
				dataGridView_app_Patient.Columns.Add("PESEL", "PESEL");

			}

            dataGridView_app_Patient.Columns["PatientId"].DataPropertyName = "PatientId";
            dataGridView_app_Patient.Columns["FirstName"].DataPropertyName = "FirstName";
            dataGridView_app_Patient.Columns["LastName"].DataPropertyName = "LastName";
            dataGridView_app_Patient.Columns["PESEL"].DataPropertyName = "PESEL";

            dataGridView_app_Patient.Columns["FirstName"].Width = 250;
            dataGridView_app_Patient.Columns["LastName"].Width = 250;
            dataGridView_app_Patient.Columns["PESEL"].Width = 250;

            dataGridView_app_Patient.Columns["PatientId"].Visible = false;

            dataGridView_app_Patient.DataSource = patients;

            dataGridView_app_Patient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_app_Patient.Rows[0].Selected = true;
        }

        private void AddSpecializationToCombobox()
        {
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();

            foreach (SpecializationModel specialization in specializations)
            {
                int index = comboBoxDoctorSpecialization.Items.Add(specialization.ToString());
                comboBoxDoctorSpecialization.Items[index] = specialization;
            }

        }

        private void FormRegisterAppointment_Load(object sender, EventArgs e)
        {
            if (appointment != null && isEdit == false)
            {
                OnlyReadDoctorAndDateComboBox();
                SelectDateInCombo();
                SelectDoctorInComboBox();
            }

            if (isEdit == true)
            {
                LockDoctorAndPatientComboBox();
                SelectPatientInComboBox();
                SelectDoctorInComboBox();
                ChangeLabelWithNameOfFormAndButton();
            }


        }



        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();

        }


        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckIfAllComboBoxesAreSelected()
        {
            if (
                comboBoxDate.SelectedIndex == -1)
            {
                buttonAddAppointment.Enabled = false;
            }
            else
            {
                buttonAddAppointment.Enabled = true;
            }
        }

        private void comboBoxPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();
        }

        private void comboBoxDoctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfAllComboBoxesAreSelected();
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            int selectedAppointmentId = -1;
            int selectedPatientId = -1;

            if (comboBoxDate.SelectedItem != null)
            {
                DoctorsDayPlanModel selectedAppointment = (DoctorsDayPlanModel)comboBoxDate.SelectedItem;
                selectedAppointmentId = selectedAppointment.IdDoctorsDayPlan;
            }

            if (dataGridView_app_Patient.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView_app_Patient.SelectedRows[0];
                Patient selectedPatient = (Patient)selectedRow.DataBoundItem;
                selectedPatientId = selectedPatient.PatientId;
            }

            using (AppDbContext db = new AppDbContext())
            {
                DoctorsDayPlanModel? appointment = db.DbDoctorsDayPlan.FirstOrDefault(a => a.IdDoctorsDayPlan == selectedAppointmentId);

                if (appointment != null)
                {
                    appointment.PatientId = selectedPatientId;
                    appointment.Status = EnumAppointmentStatus.Scheduled;
                    db.Entry(appointment).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }


            if (isEdit == true)
            {
                DoctorsPlanService.RemovePatientFromPlan(appointment);

                FormListAppointment form = new FormListAppointment(currentUser);
                Hide();
                form.ShowDialog();
                Close();

            }

            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            formCalendarAppointment.ShowDialog();
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (isEdit == false)
            {
                FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
                this.Hide();
                formCalendarAppointment.ShowDialog();
                this.Close();
            }
            else
            {
                FormListAppointment form = new FormListAppointment(currentUser);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }


        }

        #region Function
        private void OnlyReadDoctorAndDateComboBox()
        {
            comboBoxDate.Enabled = false;
            //comboBoxDoctor.Enabled = false;
        }


        private void ChangeLabelWithNameOfFormAndButton()
        {
            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);

            String hour = DoctorsPlanService.GetTermDescription((EnumTerms)appointment.IdOfTerm);

            labelTitle.Text = "Changing the date of the visit from: " + date.ToShortDateString() + " hour: " + hour;
            buttonAddAppointment.Text = "Reschedule";
        }

        private void LockDoctorAndPatientComboBox()
        {
            //comboBoxDoctor.Enabled = false;
            //comboBoxPatient.Enabled = false;
        }

        private void SelectPatientInComboBox()
        {
            Patient patient = new Patient();
            patient = PatientService.GetPatientById((int)appointment.PatientId);


            //comboBoxPatient.Items.Clear();
            // comboBoxPatient.Items.Add(patient);

            //comboBoxPatient.SelectedIndex = 0;
        }

        private void SelectDoctorInComboBox()
        {
            // comboBoxDoctor.Items.Clear();
            EmployeeModel employee = new EmployeeModel();
            employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);

            // comboBoxDoctor.Items.Add(employee);
            //comboBoxDoctor.SelectedIndex = 0;
        }

        private void SelectDateInCombo()
        {
            comboBoxDate.Items.Clear();
            comboBoxDate.Items.Add(appointment);
            comboBoxDate.SelectedItem = appointment;
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_app_Patient_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dataGridView_app_Patient_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_app_doctor_SelectionChanged(object sender, EventArgs e)
        {
            int selectedDoctorId = 0;


            if (dataGridView_app_doctor.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView_app_doctor.SelectedRows[0];

                int employeeId = Convert.ToInt32(selectedRow.Cells["IdEmployee"].Value);

                //using AppDbContext context = new();
                //EmployeeModel selectedEmployee = context.DbEmployees.Find(employeeId);
                selectedDoctorId = employeeId;
            }

            List<DoctorsDayPlanModel> appointments =
            CalendarAppointmentService.GetAppointmentsData()
                .Where(a => a.IdEmployee == selectedDoctorId && a.Status == EnumAppointmentStatus.Accepted && a.PatientId == null)
                .ToList();


			comboBoxDate.Items.Clear();

			using AppDbContext context = new();
			foreach (DoctorsDayPlanModel appointment in appointments)
            {
                CalendarModel calendar = context.DbCalendars.FirstOrDefault(c => c.IdCalendar == appointment.IdCalendar)!;
                DateTime calendarDateTime = DateTime.ParseExact(calendar.DateReference, "MM-yyyy", CultureInfo.InvariantCulture);

                if (calendar.Active == true)
                {
                    if (calendarDateTime.Year > DateTime.Today.Year)
                    {
						comboBoxDate.Items.Add(appointment);
					}
                    else if ((calendarDateTime.Year == DateTime.Today.Year))
                    {
                        if (calendarDateTime.Month > DateTime.Today.Month)
                        {
							comboBoxDate.Items.Add(appointment);
						}
                        else if (calendarDateTime.Month == DateTime.Today.Month)
                        {
                            if (appointment.IdDay >  DateTime.Today.Day)
                            {
								comboBoxDate.Items.Add(appointment);
							}
                            else if (appointment.IdDay == DateTime.Today.Day)
                            {
								// Sprawdź godzinę
								string appointmentTime = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
								DateTime appointmentDateTime = DateTime.ParseExact(appointmentTime, "HH:mm", CultureInfo.InvariantCulture);

								if (appointmentDateTime >= DateTime.Now)
								{
									comboBoxDate.Items.Add(appointment);
								}
							}
                        }
                    }
                }
				comboBoxDate.DisplayMember = appointments.ToString();

            }
        }

        private void buttonShowFilters_Click(object sender, EventArgs e)
        {
            if (!(textBox1_Name.Text == string.Empty) || !(TextBox_PESEL.Text == string.Empty))
            {
                PatientService patientService = new PatientService();
                List<Patient> FiltredPatients = patientService.FilterPatient(textBox1_Name.Text, TextBox_PESEL.Text);
                dataGridView_app_Patient.DataSource = FiltredPatients;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1_doctor.Text == string.Empty) || !(comboBoxDoctorSpecialization.SelectedIndex == -1))
            {
                DisplayDoctor();
            }
                

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!(textBox1_Name.Text == string.Empty) || !(TextBox_PESEL.Text == string.Empty))

            {
                DisplayPatient();
                textBox1_Name.Text = string.Empty;
                TextBox_PESEL.Text = string.Empty;
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(textBox1_doctor.Text == string.Empty) || !(comboBoxDoctorSpecialization.SelectedIndex == -1))

            {
                textBox1_doctor.Text = string.Empty;
                comboBoxDoctorSpecialization.SelectedIndex = -1;
                DisplayDoctor();



            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
