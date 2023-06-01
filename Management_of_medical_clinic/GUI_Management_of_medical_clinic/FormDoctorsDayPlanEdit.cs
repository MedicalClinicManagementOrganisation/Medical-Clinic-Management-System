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
using System.Globalization;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorsDayPlanEdit : Form
    {
        DateTime selectedDate;
        EmployeeModel currentEmployee;
        DoctorsDayPlanModel plan;
        CalendarModel calendar;

        public FormDoctorsDayPlanEdit(DateTime date, EmployeeModel currentEmployee, DoctorsDayPlanModel planToEdit)
        {
            selectedDate = date;
            this.currentEmployee = currentEmployee;
            plan = planToEdit;

            calendar = CalendarService.GetCalendarById(CalendarService.GetCalendarIdByDate(selectedDate.ToString("d")));

            InitializeComponent();

            insertTermDataIntoForm();

            try
            {
                EmployeeModel doctor = EmployeeService.GetEmployeeByID((int)plan.IdEmployee);
                comboBoxDoctor.Items.Add(doctor.IdEmployee + "-" + doctor.FirstName + " " + doctor.LastName);
                if (doctor.IdEmployee == plan.IdEmployee) comboBoxDoctor.SelectedItem = doctor.IdEmployee + "-" + doctor.FirstName + " " + doctor.LastName;
                comboBoxDoctor.Enabled = false;

                foreach (OfficeModel office in OfficeService.GetOfficesBySpecializationId((int)EmployeeService.GetEmployeeByID((int)plan.IdEmployee).IdSpecialization))
                {
                    if (office.IdOffice == plan.IdOffice) comboBoxOffice.SelectedItem = office.IdOffice + "-" + SpecializationService.GetSpecializationNameById(office.IdSpecialization) + " Room:" + office.Number;
                }

                insertTermsAcordingToDoctor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with uploading data. Go back and try to open this window again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public FormDoctorsDayPlanEdit(DateTime date, EmployeeModel currentEmployee)
        {
            selectedDate = date;
            this.currentEmployee = currentEmployee;

            calendar = CalendarService.GetCalendarById(CalendarService.GetCalendarIdByDate(selectedDate.ToString("d")));

            InitializeComponent();

            insertTermDataIntoForm();

            foreach(EmployeeModel doctor in EmployeeService.GetDoctors())
            {
                comboBoxDoctor.Items.Add(doctor.IdEmployee + "-" + doctor.FirstName + " " + doctor.LastName);
            }
        }

        private void FormAppointmentAdd_Load(object sender, EventArgs e)
        {
            labelDay.Text = "Selected Date: " + selectedDate.ToString("d");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkIfDifferentFromBasicValues())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentEmployee);
            Hide();
            formCalendar.Show();
            Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxOffice.SelectedItem == null || comboBoxOffice.SelectedItem == null)
            {
                MessageBox.Show("Please provide all the requared information for the new plan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> checkedTerms = returnCheckedTerms();

            if (plan != null)
            {
                if (!checkIfDifferentFromBasicValues())
                {
                    MessageBox.Show("There are no differences with already existing plans!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (checkedTerms.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete these plans? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if ( result == DialogResult.No)
                    {
                        return;
                    }
                }

                try
                {
                    string message;

                    if (!OfficeService.CheckIfOfficeIsFreeForProvidedTerm(int.Parse(comboBoxDoctor.SelectedItem.ToString().Split('-')[0]) ,calendar.IdCalendar, selectedDate.Day, int.Parse(comboBoxOffice.SelectedItem.ToString().Split('-')[0]), checkedTerms, out message))
                    {
                        MessageBox.Show(message);
                        return;
                    }

                    MessageBox.Show(DoctorsPlanService.EditPlans(checkedTerms, plan.IdDay, (int)plan.IdCalendar, (int)plan.IdEmployee, (int)plan.IdOffice), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentEmployee);
                    Hide();
                    formCalendar.Show();
                    Hide();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("There is an error acured during editing new doctor plans. Try again later!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
            else
            {
                if (checkedTerms.Count == 0)
                {
                    MessageBox.Show("There is no information about plans provided!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (calendar != null)
                {
                    try
                    {
                        string message;

                        if (!OfficeService.CheckIfOfficeIsFree(int.Parse(comboBoxDoctor.SelectedItem.ToString().Split('-')[0]), calendar.IdCalendar, selectedDate.Day, int.Parse(comboBoxOffice.SelectedItem.ToString().Split('-')[0]), checkedTerms, out message))
                        {
                            MessageBox.Show(message);
                            return;
                        }

                        MessageBox.Show(DoctorsPlanService.AddPlans(checkedTerms, selectedDate.Day, calendar.IdCalendar, int.Parse(comboBoxDoctor.SelectedItem.ToString().Split('-')[0]), int.Parse(comboBoxOffice.SelectedItem.ToString().Split('-')[0])));

                        FormDoctorsPlanCalendar formCalendar = new FormDoctorsPlanCalendar(currentEmployee);
                        Hide();
                        formCalendar.Show();
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There is an error acured during addition new doctor plans. Try again later!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Calendar for current month hasn't been created!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeModel selectedDoctor = EmployeeService.GetEmployeeByID(int.Parse(comboBoxDoctor.SelectedItem.ToString().Split('-')[0]));

            if (plan != null)
            {
                if (plan.IdEmployee != selectedDoctor.IdEmployee)
                {
                    for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
                    {
                        checkedListBoxTerms.SetItemChecked(i, false);
                    }

                }
                else
                {
                    insertTermsAcordingToDoctor();
                }
            }

            if (comboBoxOffice.SelectedItem != null)
            {
                OfficeModel selectedOffice = OfficeService.GetOfficeById(int.Parse(comboBoxOffice.SelectedItem.ToString().Split('-')[0]));

                if (selectedDoctor.IdSpecialization != selectedOffice.IdSpecialization)
                {
                    comboBoxOffice.Items.Clear();
                    comboBoxOffice.Text = "";

                    foreach (OfficeModel office in OfficeService.GetOfficesBySpecializationId((int)selectedDoctor.IdSpecialization))
                    {
                        comboBoxOffice.Items.Add(office.IdOffice + "-" + SpecializationService.GetSpecializationNameById(office.IdSpecialization) + " Room:" + office.Number);
                    }
                }
            }
            else {
                comboBoxOffice.Items.Clear();
                comboBoxOffice.Text = "";

                foreach (OfficeModel office in OfficeService.GetOfficesBySpecializationId((int)EmployeeService.GetEmployeeByID((int)selectedDoctor.IdEmployee).IdSpecialization))
                {
                    comboBoxOffice.Items.Add(office.IdOffice + "-" + SpecializationService.GetSpecializationNameById(office.IdSpecialization) + " Room:" + office.Number);
                }
            }
        }

        private void insertTermDataIntoForm()
        {
            foreach (EnumTerms term in Enum.GetValues(typeof(EnumTerms)))
            {
                checkedListBoxTerms.Items.Add(DoctorsPlanService.GetTermDescription(term));
            }
        }

        private void insertTermsAcordingToDoctor()
        {
            List<int> checkedTerms = DoctorsPlanService.GetBookedTermsOfDoctorForCurrentDay((int)plan.IdEmployee, selectedDate.Day, calendar.IdCalendar);

            for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
            {
                if (checkedTerms.Contains(i)) checkedListBoxTerms.SetItemChecked(i, true);
                else checkedListBoxTerms.SetItemChecked(i, false);
            }
        } 
        
        private bool checkIfDifferentFromBasicValues()
        {
            List<int> checkedTerms = returnCheckedTerms();

            if (plan != null)
            {
                return int.Parse(comboBoxDoctor.SelectedItem.ToString().Split('-')[0]) != plan.IdEmployee || int.Parse(comboBoxOffice.SelectedItem.ToString().Split('-')[0]) != plan.IdOffice || !checkedTerms.SequenceEqual(DoctorsPlanService.GetBookedTermsOfDoctorForCurrentDay((int)plan.IdEmployee, selectedDate.Day, calendar.IdCalendar));
            }
            else
            {
                return comboBoxOffice.SelectedItem != null || comboBoxDoctor.SelectedItem != null || checkedTerms.Count != 0;
            }
        }

        private List<int> returnCheckedTerms()
        {
            List<int> checkedTerms = new List<int>();

            for (int i = 0; i < checkedListBoxTerms.Items.Count; i++)
            {
                if (checkedListBoxTerms.GetItemChecked(i))
                {
                    checkedTerms.Add(i);
                }
            }

            return checkedTerms;
        }
    }
}
