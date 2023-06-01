using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Reflection;

//The system allows to filter patients on: 
//surname of patient 
//The PESEL number
//Date of the visit
//sort asc/desc x

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorAppointmentList : Form
    {
        EmployeeModel currentUser;
        DateTime currentMonth;

        public FormDoctorAppointmentList(EmployeeModel employee, DateTime currentMonth)
        {
            InitializeComponent();
            currentUser = employee;
            this.currentMonth = currentMonth;
        }

        private void FormDoctorAppointmentList_Load(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> appointments = AppointmentService.GetAppointmentsForDoctorInChosenMonth(currentMonth, currentUser);
            DisplayDataInDataGridView(appointments);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDoctorCurrentCalendar formDoctorCurrentCalendar = new FormDoctorCurrentCalendar(currentUser);
            this.Hide();
            formDoctorCurrentCalendar.ShowDialog();
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

            string name = string.Empty;

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                name = patient.FirstName.ToLower();

                if (name.StartsWith(checkedString))
                {
                    result.Add(appointment);
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

            string name = string.Empty;

            foreach (DoctorsDayPlanModel appointment in appointments)
            {
                Patient patient = CalendarAppointmentService.GetPatientDataByIdPatient(appointment);
                name = patient.LastName.ToLower();

                if (name.StartsWith(checkedValue))
                {
                    result.Add(appointment);
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
            }

            return result;
        }

        #endregion

        private void buttonAddFiltr_Click(object sender, EventArgs e)
        {
            dataGridViewAppointmentList.Rows.Clear();

            List<DoctorsDayPlanModel> appointments = AppointmentService.GetAppointmentsForDoctorInChosenMonth(currentMonth, currentUser);

            List<DoctorsDayPlanModel> result = new List<DoctorsDayPlanModel>();

            result = FiltrByName(appointments);
            result = FiltrByLastName(result);
            result = FiltrByPESEL(result);
            result = FiltrByVisit(result);

            DisplayDataInDataGridView(result);
        }

        private void buttonClearFiltr_Click(object sender, EventArgs e)
        {
            List<DoctorsDayPlanModel> appointments = AppointmentService.GetAppointmentsForDoctorInChosenMonth(currentMonth, currentUser);
            DisplayDataInDataGridView(appointments);

            textBoxLastName.Text = string.Empty;
            textBoxName.Text = string.Empty;
            maskedTextBoxPESEL.Text = string.Empty;
            dateTimePickerDateOfVisit.Value = DateTime.Today;
            checkBoxDateOfVisit.Checked = false;
        }

        //will it be needed?
        /*//will it be needed?
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

        */
        private void buttonRemove_Click(object sender, EventArgs e) //cancel appointment
        {
            if (dataGridViewAppointmentList.Rows.Count == 0)
            {
                MessageBox.Show("Choose appointment to cancel", "Information", MessageBoxButtons.OK);
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
        public List<DoctorsDayPlanModel> GetSortedAppointmentsByLastName()
        {
            List<DoctorsDayPlanModel> appointments = AppointmentService.GetAppointmentsForDoctorInChosenMonth(currentMonth, currentUser);
            List<DoctorsDayPlanModel> sortedAppointments = appointments.OrderBy(a => PatientService.GetPatientById((int)a.PatientId).LastName).ToList();
            return sortedAppointments;

        }
        public List<DoctorsDayPlanModel> GetSortedAppointmentsByLastNameDSC()
        {
            List<DoctorsDayPlanModel> appointments = AppointmentService.GetAppointmentsForDoctorInChosenMonth(currentMonth, currentUser);
            List<DoctorsDayPlanModel> sortedAppointments = appointments.OrderByDescending(a => PatientService.GetPatientById((int)a.PatientId).LastName).ToList();
            return sortedAppointments;
        }

        private void DisplaySortedByLastName()
        {
            dataGridViewAppointmentList.Rows.Clear();
            List<DoctorsDayPlanModel> sortedAppointments = GetSortedAppointmentsByLastName();
            foreach (DoctorsDayPlanModel appointment in sortedAppointments)
            {
                Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
                int patient_id = PatientService.GetPatientById((int)appointment.PatientId).PatientId;
                string lastName = PatientService.GetPatientById((int)appointment.PatientId).LastName;
                string firstName = PatientService.GetPatientById((int)appointment.PatientId).FirstName;
                string pesel = PatientService.GetPatientById((int)appointment.PatientId).PESEL;
                string date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay).ToShortDateString();
                string term = DoctorsPlanService.GetTermDescription((EnumTerms)appointment.IdOfTerm);
                int office = OfficeService.GetOfficeById((int)appointment.IdOffice).Number;
                decimal cost = (decimal)appointment.Cost;

                int index = dataGridViewAppointmentList.Rows.Add(patient_id, lastName, firstName, pesel, date, term, office, cost);
                dataGridViewAppointmentList.Rows[index].Tag = patient;
            }
            dataGridViewAppointmentList.Refresh();
        }
        private void DisplaySortedByLastNameDSC()
        {
            dataGridViewAppointmentList.Rows.Clear();
            List<DoctorsDayPlanModel> sortedAppointments = GetSortedAppointmentsByLastNameDSC();
            foreach (DoctorsDayPlanModel appointment in sortedAppointments)
            {
                Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
                int patient_id = PatientService.GetPatientById((int)appointment.PatientId).PatientId;
                string lastName = PatientService.GetPatientById((int)appointment.PatientId).LastName;
                string firstName = PatientService.GetPatientById((int)appointment.PatientId).FirstName;
                string pesel = PatientService.GetPatientById((int)appointment.PatientId).PESEL;
                string date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay).ToShortDateString();
                string term = DoctorsPlanService.GetTermDescription((EnumTerms)appointment.IdOfTerm);
                int office = OfficeService.GetOfficeById((int)appointment.IdOffice).Number;
                decimal cost = (decimal)appointment.Cost;

                int index = dataGridViewAppointmentList.Rows.Add(patient_id, lastName, firstName, pesel, date, term, office, cost);
                dataGridViewAppointmentList.Rows[index].Tag = patient;
            }
            dataGridViewAppointmentList.Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplaySortedByLastName();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplaySortedByLastNameDSC();
        }

        private void buttonShowDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
