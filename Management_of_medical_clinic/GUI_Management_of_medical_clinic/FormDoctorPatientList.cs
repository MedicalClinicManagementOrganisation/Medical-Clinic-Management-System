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
using Console_Management_of_medical_clinic.Data.Enums;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorPatientList : Form
    {
        private PatientService patientService;
        EmployeeModel currentUser;

        public FormDoctorPatientList(EmployeeModel employee)
        {
            InitializeComponent();
            patientService = new PatientService();
            DisplayPatientsList();
            currentUser = employee;
            dataGridViewPatientList.ClearSelection();
            dataGridViewPatientList.Refresh();
        }
        public void DisplayPatientsList()
        {
            List<Patient> listPatients = patientService.GetPatientData();

            foreach (Patient patient in listPatients)
            {
                string sex;
                string dateTime = patient.BirthDate.ToString("d");

                if (patient.IsActive == true && patient.Sex == EnumSex.Female)
                {
                    sex = "Female";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
                else if (patient.IsActive == true && patient.Sex == EnumSex.Male)
                {
                    sex = "Male";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            Hide();
            formDoctorDashboard.ShowDialog();
            Close();
        }

        private void button_ShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatientList.SelectedRows.Count == 1) //you can see past visits for only one patient
            {
                ShowDetails();
            }
        }

        public void ShowDetails() //datagrid is filled on right side
        {
            dataGridViewLastVisits.Rows.Clear();
            Patient patient = new Patient();
            patient = Patient.FindPatient((int)dataGridViewPatientList.SelectedRows[0].Cells[0].Value);
            int patient_id = patient.PatientId;
            int year, month, day;
            string room;
            EmployeeModel employee;
            List<DoctorsDayPlanModel> list = DoctorsPlanService.GetAppointmentsByPatientId(patient_id);
            foreach (DoctorsDayPlanModel app in list)
            {
                int idAppointment = app.IdDoctorsDayPlan;
                CalendarModel mon = CalendarService.GetCalendarById((int)app.IdCalendar);
                year = Convert.ToDateTime(mon.DateReference).Year;
                month = Convert.ToDateTime(mon.DateReference).Month;
                day = app.IdDay;
                employee = EmployeeService.GetEmployeeByID((int)app.IdEmployee);
                string employeeNameAndSurname = employee.FirstName.ToString() + " " + employee.LastName.ToString();
                SpecializationModel spec= SpecializationService.GetSpecializationById((int)employee.IdSpecialization);
                string specialzation = spec.Name;
                /*OfficeModel officeInfo = OfficeService.GetOfficeById((int)app.IdOffice);
                room = officeInfo.Info;*/

                /*int hourInt = app.IdOfTerm;
                EnumTerms enumValue = (EnumTerms)hourInt;
                string hour = enumValue.ToString("");*/

                int index = dataGridViewLastVisits.Rows.Add(idAppointment, day+"."+month+"."+year, employee.FirstName +" "+employee.LastName, specialzation/*,room*/); //if room is uncommented, please change column visible=true in "Room"               
                dataGridViewLastVisits.Rows[index].Tag = app;
            }
            dataGridViewLastVisits.ClearSelection();
            dataGridViewLastVisits.Refresh();
        }

        #region Sorting

        public List<Patient> GetSortedAppointmentsByLastName()
        {
            List<Patient> patients = PatientService.GetPatientsData();
            List<Patient> sortedAppointments = patients.OrderBy(a => PatientService.GetPatientById((int)a.PatientId).LastName).ToList();
            return sortedAppointments;

        }
        public List<Patient> GetSortedAppointmentsByLastNameDSC()
        {
            List<Patient> patients = PatientService.GetPatientsData();
            List<Patient> sortedAppointments = patients.OrderByDescending(a => PatientService.GetPatientById((int)a.PatientId).LastName).ToList();
            return sortedAppointments;
        }

        private void DisplaySortedByLastName()
        {
            dataGridViewPatientList.Rows.Clear();
            List<Patient> sortedAppointments = GetSortedAppointmentsByLastName();
            foreach (Patient patient in sortedAppointments)
            {
                string sex;
                string dateTime = patient.BirthDate.ToString("d");

                if (patient.IsActive == true && patient.Sex == EnumSex.Female)
                {
                    sex = "Female";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName  , patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
                else if (patient.IsActive == true && patient.Sex == EnumSex.Male)
                {
                    sex = "Male";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }              
            }
            dataGridViewPatientList.Refresh();
        }
        private void DisplaySortedByLastNameDSC()
        {
            dataGridViewPatientList.Rows.Clear();
            List<Patient> sortedAppointments = GetSortedAppointmentsByLastNameDSC();
            foreach (Patient patient in sortedAppointments)
            {
                string sex;
                string dateTime = patient.BirthDate.ToString("d");

                if (patient.IsActive == true && patient.Sex == EnumSex.Female)
                {
                    sex = "Female";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
                else if (patient.IsActive == true && patient.Sex == EnumSex.Male)
                {
                    sex = "Male";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.LastName + " " + patient.FirstName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
            }
            dataGridViewPatientList.Refresh();
        }
        #endregion

        #region Filter
        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            dataGridViewPatientList.Rows.Clear();
            DisplayPatientsList();
            textBoxLastName.Text = null;
            textBoxName.Text = null;
        }
        private void buttonShowFilters_Click(object sender, EventArgs e)
        {
            dataGridViewPatientList.Rows.Clear();

            List<Patient> patients = patientService.GetPatientData();

            List<Patient> result = new List<Patient>();

            result = FilterByFirstName(patients);
            result = FilterByLastName(result);
            //result = FiltrByVisit(result);

            DisplayDataInDataGridView(result);
        }
        private void DisplayDataInDataGridView(List<Patient> patients)
        {
            dataGridViewPatientList.Rows.Clear();
            foreach (Patient patient in patients)
            {
                string sex;
                string dateTime = patient.BirthDate.ToString("d");

                if (patient.IsActive == true && patient.Sex == EnumSex.Female)
                {
                    sex = "Female";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.FirstName + " " + patient.LastName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
                else if (patient.IsActive == true && patient.Sex == EnumSex.Male)
                {
                    sex = "Male";
                    int index = dataGridViewPatientList.Rows.Add(patient.PatientId, patient.FirstName + " " + patient.LastName, patient.PESEL,
                        sex, dateTime, patient.IsActive, patient.LastVisitDate);
                    dataGridViewPatientList.Rows[index].Tag = patient;
                }
            }
        }

        private List<Patient> FilterByFirstName(List<Patient> patients)
        {
            List<Patient> result = new List<Patient>();
            patients = patientService.GetPatientData();
            string checkedString = textBoxName.Text.ToLower();

            if (textBoxName.Text == string.Empty)
            {
                return patients;
            }

            string name = string.Empty;

            foreach (Patient patient in patients)
            {
                name = patient.FirstName.ToLower();

                if (name.StartsWith(checkedString))
                {
                    result.Add(patient);
                }

            }
            return result;
        }

        private List<Patient> FilterByLastName(List<Patient> patients)
        {
            List<Patient> result = new List<Patient>();
            patients = patientService.GetPatientData();
            string checkedString = textBoxLastName.Text.ToLower();

            if (textBoxLastName.Text == string.Empty)
            {
                return patients;
            }

            string name = string.Empty;

            foreach (Patient patient in patients)
            {
                name = patient.LastName.ToLower();

                if (name.StartsWith(checkedString))
                {
                    result.Add(patient);
                }

            }
            return result;
        }
        #endregion
        private void dataGridViewLastVisits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = dataGridViewLastVisits.SelectedCells[0];
            if (selectedCell.ColumnIndex == 0) //i get appointment id from hidden column
            {
                List<int> id = new List<int>();
                int id_app = (int)selectedCell.Value;
                id.Add(id_app);               
                List<DoctorsDayPlanModel> listApp = DoctorsPlanService.GetAppointmentsDetailsByAppointmentID(id);
                foreach (DoctorsDayPlanModel app in listApp) //this foreach is for one id, but idk how to make it better
                {
                    if (app.IdDoctorsDayPlan == id_app)
                    {
                        FormDoctorPatientVisitDetails visitDetails = new FormDoctorPatientVisitDetails(currentUser, app, false);
                        visitDetails.Show();
                    }
                }               
            }
        }
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Hide();
            Close();
            FormDoctorDashboard formDoctorDashboard = new FormDoctorDashboard(currentUser);
            formDoctorDashboard.Show();               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
              DisplaySortedByLastName();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplaySortedByLastNameDSC();
        }
    }
}