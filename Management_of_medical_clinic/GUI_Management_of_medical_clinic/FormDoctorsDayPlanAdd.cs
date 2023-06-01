using GUI_Management_of_medical_clinic;
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
    public partial class FormDoctorsDayPlanAdd : Form
    {
        int parsedEmployeeId = -1;
        int parsedOfficeId = -1;
        DateTime selectedDate;
        string dateReference;
        int selectedDay;
        int calendarId;
        EmployeeModel currentEmployee;

        public FormDoctorsDayPlanAdd(DateTime date, EmployeeModel currentEmployee)
        {
            selectedDate = date;
            selectedDay = date.Day;


            dateReference = selectedDate.ToString("d");
            calendarId = CalendarService.GetCalendarIdByDate(dateReference);

            this.currentEmployee = currentEmployee;


            InitializeComponent();

            foreach (EnumTerms term in Enum.GetValues(typeof(EnumTerms)))
            {
                checkedListBoxTerms.Items.Add(DoctorsPlanService.GetTermDescription(term));
            }

            try
            {
                foreach (EmployeeModel employeeModel in EmployeeService.GetDoctors())
                {
                    comboBoxDoctor.Items.Add(employeeModel.IdEmployee + "-" + employeeModel.FirstName + " " + employeeModel.LastName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            checkSelectedIds();
            DoctorsPlanService.CheckIfDoctorHasPlanForCurrentDay(parsedEmployeeId, selectedDay, calendarId);
        }
        private bool checkSelectedIds()
        {
            if (comboBoxDoctor.SelectedIndex == -1 || comboBoxOffice.SelectedIndex == -1)
            {
                return false;
            }
            string[] employeeIdString = comboBoxDoctor.SelectedItem.ToString().Split('-');
            string[] officeIdString = comboBoxOffice.SelectedItem.ToString().Split('-');
            if (int.TryParse(employeeIdString[0], out int resultEmployeeId))
            {
                parsedEmployeeId = resultEmployeeId;
                
            }
            else
            {
                MessageBox.Show("Error converting employeeId");
                return false;
            }
            if (int.TryParse(officeIdString[0], out int resultOfficeId))
            {
                parsedOfficeId = resultOfficeId;
            }
            else
            {
                MessageBox.Show("Error converting officeId");
                return false;
            }
            return true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void FormAppointmentAdd_Load(object sender, EventArgs e)
        {
            labelDay.Text = "Selected Date: " + selectedDate.ToString("d");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<int> checkedTerms = new List<int>();
            if (checkSelectedIds()==true)
            {
                for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
                {

                    if (checkedListBoxTerms.GetItemChecked(i))
                    {
                        checkedTerms.Add(i);
                    }
                }

                if (checkedTerms.Count==0)
                {
                    MessageBox.Show("No terms have been selected");
                    return;
                }

                if (calendarId != -1)
                {                    
                    try
                    {
                        string message;

                        if(!OfficeService.CheckIfOfficeIsFree(parsedEmployeeId, calendarId, selectedDay, parsedOfficeId, checkedTerms, out message))
                        {
                            MessageBox.Show(message);
                            return;
                        }

                        MessageBox.Show(DoctorsPlanService.AddPlans(checkedTerms, selectedDay, calendarId, parsedEmployeeId, parsedOfficeId));

                        FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentEmployee);
                        this.Hide();
                        formCalendar.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Calendar for current month hasn't been created");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Missing Input");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentEmployee);
            this.Hide();
            formCalendar.Show();
            this.Hide();
        }

        private void updateCheckBoxes()
        {
            if (checkSelectedIds())
            {
                List<int> checkedTerms = DoctorsPlanService.GetBookedTermsOfDoctorForCurrentDay(parsedEmployeeId, selectedDay, calendarId);

                for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
                {
                    checkedListBoxTerms.SetItemChecked(i, false);
                }
                foreach (int j in checkedTerms)
                {
                    checkedListBoxTerms.SetItemChecked(j, true);
                }
            }            
        }

        private void comboBoxOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCheckBoxes();
            comboBoxOffice.Items.Clear();
            comboBoxOffice.Text = "";

            List<OfficeModel> offices = OfficeService.GetOfficesData();
            if (comboBoxDoctor.SelectedIndex < 0)
            {
                return;
            }

            string selectedEmployee = comboBoxDoctor.SelectedItem.ToString();

            string[] employeeParts = selectedEmployee.Split('-');

            int selectedEmployeeId = int.Parse(employeeParts[0]);

            List<EmployeeModel> employees = EmployeeService.GetEmployeesData();
            EmployeeModel doctor = employees.FirstOrDefault(e => e.IdEmployee == selectedEmployeeId);
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();


            if (doctor == null) return;

            foreach (OfficeModel office in offices)
            {
                if (office.IdSpecialization == doctor.IdSpecialization)
                {

                    SpecializationModel specalization = specializations.FirstOrDefault(e => e.IdSpecialization == office.IdSpecialization);
                    comboBoxOffice.Items.Add(office.IdOffice + "-" + specalization.Name + " Room:" + office.Number);

                }
            }            
        }
    }
}
