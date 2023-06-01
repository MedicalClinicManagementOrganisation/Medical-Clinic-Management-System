using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;

//The system allows to filter patients on: 

//Name and the surname of patient. x 

//The PESEL number x

//Date of the visit x 

//Doctor specialization x

//Doctor name/surname x


namespace GUI_Management_of_medical_clinic
{
    public partial class FormListAppointment : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormListAppointment(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            currentUser = employee;
        }

        private void FormListAppointment_Load(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();
            DisplayDataInDataGridView(appointments);

            AddItemsToTheComboBoxDoctorOrPatient();
            AddItemsToComboBoxSpecialization();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormCalendarAppointment formCalendarAppointment = new FormCalendarAppointment(currentUser);
            this.Hide();
            formCalendarAppointment.ShowDialog();
            this.Close();
        }

        #region Display data

        private void DisplayDataInDataGridView(List<DoctorsDayPlanModel> appointments)
        {
            dataGridViewAppointmentList.Rows.Clear();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                int index = dataGridViewAppointmentList.Rows.Add(appointment.appointmentData);
                dataGridViewAppointmentList.Rows[index].Tag = appointment;
            }
        }

        enum DoctorOrPatient { Patient, Doctor }

        private void AddItemsToTheComboBoxDoctorOrPatient()
        {
            comboBoxSelectDoctorOrPatient.Items.Clear();
            comboBoxSelectDoctorOrPatient.Items.Add(DoctorOrPatient.Patient);
            comboBoxSelectDoctorOrPatient.Items.Add(DoctorOrPatient.Doctor);

            comboBoxSelectDoctorOrPatient.SelectedIndex = 0;
        }

        private void AddItemsToComboBoxSpecialization()
        {
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();

            foreach (SpecializationModel specialization in specializations)
            {
                int index = comboBoxDoctorSpecialization.Items.Add(specialization.ToString());
                comboBoxDoctorSpecialization.Items[index] = specialization;
            }
        }

        #endregion

        #region Filtr data

        private List<DoctorsDayPlanModel> FiltrByName(List<DoctorsDayPlanModel> appointments)
        {
            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();
            string checkedString = textBoxName.Text.ToLower();

            if (textBoxName.Text == string.Empty)
            {
                return appointments;
            }

            string PatientOrDoctor = SelectedInComboBoxIsDoctorOrPatient();

            string name = string.Empty;

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (PatientOrDoctor == "Patient")
                {
                    Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                    name = patient.FirstName.ToLower();

                    if (name.StartsWith(checkedString))
                    {
                        result.Add(appointment);
                    }
                }
                else
                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);
                    name = employee.FirstName.ToLower();

                    if (name.StartsWith(checkedString))
                    {
                        result.Add(appointment);
                    }
                }
            }
            return result;
        }

        private List<DoctorsDayPlanModel> FiltrByLastName(List<DoctorsDayPlanModel> appointments)
        {
            string checkedValue = textBoxLastName.Text.ToLower();

            if (textBoxLastName.Text == string.Empty)
            {
                return appointments;
            }

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            string PatientOrDoctor = SelectedInComboBoxIsDoctorOrPatient();
            string name = string.Empty;

            foreach (DoctorsDayPlanModel appointment in appointments)
            {

                if (PatientOrDoctor == "Patient")
                {
                    Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                    name = patient.LastName.ToLower();

                    if (name.StartsWith(checkedValue))
                    {
                        result.Add(appointment);
                    }
                }
                else
                {
                    EmployeeModel employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);
                    name = employee.LastName.ToLower();

                    if (name.StartsWith(checkedValue))
                    {
                        result.Add(appointment);
                    }
                }
            }

            return result;
        }


        private List<DoctorsDayPlanModel> FiltrByPESEL(List<DoctorsDayPlanModel> appointments)
        {
            string checkedValue = maskedTextBoxPESEL.Text;

            if (checkedValue == string.Empty)
            {
                return appointments;
            }

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                Patient patient = PatientService.GetPatientById((int)appointment.PatientId);

                if (patient.PESEL.StartsWith(checkedValue))
                {
                    result.Add(appointment);
                }
            }
            return result;
        }


        private List<DoctorsDayPlanModel> FiltrByVisit(List<DoctorsDayPlanModel> appointments)
        {
            DateTime checkedValue = dateTimePickerDateOfVisit.Value.Date;

            if (!checkBoxDateOfVisit.Checked)
            {
                return appointments;
            }

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            DateTime date;

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                result = CalendarAppointmentService.appointmentInSelectedDate(appointments, checkedValue, (int)appointment.IdCalendar);
                //?            
            }

            return result;
        }


        private List<DoctorsDayPlanModel> FiltrBySpecialization(List<DoctorsDayPlanModel> appointments)
        {
            if (comboBoxDoctorSpecialization.SelectedIndex == -1)
            {
                return appointments;
            }

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            SpecializationModel checkedValue = (SpecializationModel)comboBoxDoctorSpecialization.SelectedItem;

            int idSpecialization = checkedValue.IdSpecialization;

            EmployeeModel employee = new EmployeeModel();


            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);

                if (employee.IdSpecialization == idSpecialization)
                {
                    result.Add(appointment);
                }
            }

            return result;

        }

        private string SelectedInComboBoxIsDoctorOrPatient()
        {
            string result = string.Empty;
            if (comboBoxSelectDoctorOrPatient.SelectedIndex == 0) // Patient
            {
                result = "Patient";
            }
            else if (comboBoxSelectDoctorOrPatient.SelectedIndex == 1) //Doctor
            {
                result = "Doctor";
            }

            return result;
        }

        #endregion

        private void buttonAddFiltr_Click(object sender, EventArgs e)
        {
            dataGridViewAppointmentList.Rows.Clear();

            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            result = FiltrByName(appointments);
            result = FiltrByLastName(result);
            result = FiltrByPESEL(result);
            result = FiltrBySpecialization(result);
            result = FiltrByVisit(result);

            DisplayDataInDataGridView(result);
        }

        private void buttonClearFiltr_Click(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> appointments = CalendarAppointmentService.GetAppointmentsWithPatients();
            DisplayDataInDataGridView(appointments);

            comboBoxDoctorSpecialization.SelectedIndex = -1;
            comboBoxSelectDoctorOrPatient.SelectedIndex = 0;

            textBoxLastName.Text = string.Empty;
            textBoxName.Text = string.Empty;
            maskedTextBoxPESEL.Text = string.Empty;
            dateTimePickerDateOfVisit.Value = DateTime.Today;
            checkBoxDateOfVisit.Checked = false;
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.Rows.Count == 0)
            {
                string msg = "No appointments. Register an appointment.";
                FormMessage FormMessage = new FormMessage(msg);
                FormMessage.ShowDialog();
                return;
            }

            DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewAppointmentList.SelectedRows[0].Tag;

            using (AppDbContext context = new())
            {
                appointment = context
                    .DbDoctorsDayPlan
                    .Include(a => a.Patient)
                    .Include(a => a.EmployeeModel)
                    .FirstOrDefault(a => a.IdDoctorsDayPlan == appointment.IdDoctorsDayPlan)!;
            }

            FormShowDetailsAppointment formShowDetailsAppointment = new FormShowDetailsAppointment(currentUser, appointment);
            Hide();
            formShowDetailsAppointment.ShowDialog();
            Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.Rows.Count == 0)
            {
                string msg1 = "No appointments. Register an appointment.";
                FormMessage FormMessage1 = new FormMessage(msg1);
                FormMessage1.ShowDialog();
                return;
            }

            DoctorsDayPlanModel appointment = (DoctorsDayPlanModel)dataGridViewAppointmentList.SelectedRows[0].Tag;

            DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
            string term = AppointmentService.GetTermByTermId((int)appointment.IdOfTerm);
            TimeSpan time = TimeSpan.ParseExact(term, "hh\\:mm", null);

            if (date <= DateTime.Now.Date && time <= DateTime.Now.TimeOfDay)
            {
                string msg2 = "You cannot cancel past appointment.";
                FormMessage FormMessage2 = new FormMessage(msg2);
                FormMessage2.ShowDialog();
                return;
            }

            FormConfirmCancelAppointment cancel = new FormConfirmCancelAppointment("cancel", currentUser, appointment);
            cancel.ShowDialog();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> doctorsDayPlanModels = CalendarAppointmentService.GetAppointmentsWithPatients();

            int count = 0;

            foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
            {
                DateTime date = CalendarService.GetDateByIdCalendar((int)doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdDay);
                string term = AppointmentService.GetTermByTermId(doctorsDayPlanModel.IdOfTerm);
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

        private void buttonRescheduleAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointmentList.SelectedRows.Count == 0) return;

            DoctorsDayPlanModel visit = new DoctorsDayPlanModel();
            visit = (DoctorsDayPlanModel)dataGridViewAppointmentList.SelectedRows[0].Tag;

            FormRegisterAppointment form = new FormRegisterAppointment(currentUser, visit, true);
            Hide();
            form.ShowDialog();
            Close();

        }

     
    }
}
