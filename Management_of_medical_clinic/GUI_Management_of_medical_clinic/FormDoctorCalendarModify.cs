using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormDoctorCalendarModify : Form
    {
        EmployeeModel currentUser;
        DoctorsDayPlanModel appointment;
        string calendar;

        int selectedDay;
        int calendarId;
        bool creatingNew;


        string dateReference;
        DateTime selectedDate;

        public FormDoctorCalendarModify(DoctorsDayPlanModel? appointment, EmployeeModel currentUser, bool creatingNew, /*DateTime date,*/ string calendar)
        {
            this.currentUser = currentUser;
            this.appointment = appointment;
            this.creatingNew = creatingNew;
            this.calendar = calendar;

            DateTime.TryParse(calendar, out selectedDate);

            InitializeComponent();
        }

        private void FormDoctorCalendarModify_Load(object sender, EventArgs e)
        {
            labelModifyAppointment.Text = creatingNew ? "Creating new appointment" : "Modifying Appointment";
            FillOfficesComboBox();

            BlockDateTimePicker();

            dateTimePicker.Value = selectedDate;
            if (!creatingNew)
            {

                try
                {
                    dateTimePicker.Value = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
                    comboBoxOfficeNumber.SelectedItem = appointment.IdOffice.ToString();
                    comboBoxTerm.SelectedItem = AppointmentService.GetTermByTermId(appointment.IdOfTerm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

        }

        private void BlockDateTimePicker()
        {
            dateTimePicker.ShowUpDown = true; // Enable the up and down buttons for value adjustment

            // Disable the increase and decrease buttons for the month and year
            foreach (Control ctl in dateTimePicker.Controls)
            {
                if (ctl.GetType().Name == "DateTimePicker.DateTimePickerAccessibleObject")
                {
                    dynamic dtpAccessibleObject = ctl;
                    dtpAccessibleObject.UpButtonEnabled = false; // Disable the increase button
                    dtpAccessibleObject.DownButtonEnabled = false; // Disable the decrease button
                }
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value.Month != selectedDate.Month || dateTimePicker.Value.Year != selectedDate.Year)
            {
                dateTimePicker.Value = selectedDate; // Przywrócenie poprzedniej wartości miesiąca i roku
            }
            else
            {
                selectedDate = dateTimePicker.Value; // Zaktualizowanie poprzedniej wartości
            }
        }
        private void FillOfficesComboBox()
        {
            try
            {
                int currentUserSpecialization = currentUser.IdSpecialization.Value;
                List<OfficeModel> offices = OfficeService.GetOfficesData();
                List<OfficeModel> filteredOffices = offices.Where(o => o.IdSpecialization == currentUserSpecialization).ToList();
                comboBoxOfficeNumber.DisplayMember = "Name";
                comboBoxOfficeNumber.DataSource = filteredOffices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private bool CheckTheHoliday(DateTime date)
        {
            DateTime[] holidays = new DateTime[] {
            new DateTime(date.Year, 1, 1),  // Nowy Rok
            new DateTime(date.Year, 1, 6),  // Święto Trzech Króli
            new DateTime(date.Year, 4, 17), // Poniedziałek Wielkanocny
            new DateTime(date.Year, 5, 1),  // Święto Pracy
            new DateTime(date.Year, 5, 3),  // Święto Konstytucji 3 Maja
            new DateTime(date.Year, 6, 4),  // Zesłanie Ducha Świętego
            new DateTime(date.Year, 6, 15), // Boże Ciało
            new DateTime(date.Year, 8, 15), // Wniebowzięcie Najświętszej Maryi Panny
            new DateTime(date.Year, 11, 1), // Wszystkich Świętych
            new DateTime(date.Year, 11, 11), // Święto Niepodległości
            new DateTime(date.Year, 12, 25), // Boże Narodzenie (pierwszy dzień)
            new DateTime(date.Year, 12, 26), // Boże Narodzenie (drugi dzień)
            };

            return holidays.Contains(date);
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTerm.SelectedIndex < 0)
                {
                    if(comboBoxOfficeNumber.SelectedIndex < 0)
                    {
                        MessageBox.Show("You have to select a term and an office");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("You have to select a term");
                        return;
                    }

                }

                if (comboBoxOfficeNumber.SelectedIndex < 0)
                {
                    MessageBox.Show("You have to select an office");
                    return;
                }

                DateTime selectedDate = dateTimePicker.Value;
                DayOfWeek dayOfWeek = selectedDate.DayOfWeek;

                if (dayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("We're closed on Sunday. Please choose other date");
                    return;
                }

                if(CheckTheHoliday(selectedDate))
                {
                    MessageBox.Show("Selected date is a holiday. Please choose another date");
                    return;
                }

                DateTime DateInDTP = dateTimePicker.Value;
                dateReference = DateInDTP.ToString("d");
                calendarId = CalendarService.GetCalendarIdByDate(dateReference);
                OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeNumber.SelectedItem;

                if (DoctorsPlanService.CheckIfAppointmentExists(GetIdOfTermFromCombo(),
                    dateTimePicker.Value.Day,
                    calendarId, selectedOffice.IdOffice))
                {
                    MessageBox.Show("The office is already booked for this term");
                    return;
                }


                if (creatingNew)
                {
                    CreateAppointemntInDataBase();
                }
                else
                {
                    FindEditAppointemntInDataBase();
                }




                ToFormCalendar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private int GetIdOfTermFromCombo()
        {
            string term = comboBoxTerm.SelectedItem.ToString();
            int idTerm = AppointmentService.GetIdOfTerm(term) - 1;
            return idTerm;
        }

        #region ChangingDataInDatabase
        private void CreateAppointemntInDataBase()
        {
            int selectedDay = dateTimePicker.Value.Day;

            selectedDate = dateTimePicker.Value;
            dateReference = selectedDate.ToString("d");
            calendarId = CalendarService.GetCalendarIdByDate(dateReference);

            OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeNumber.SelectedItem;

            EnumAppointmentStatus status = (EnumAppointmentStatus)2;

            DoctorsDayPlanModel model = new DoctorsDayPlanModel(GetIdOfTermFromCombo(),
                dateTimePicker.Value.Day,
                calendarId,
                currentUser.IdEmployee,
                selectedOffice.IdOffice,
                status);
            DoctorsPlanService.AddPlan(model);
            MessageBox.Show("New plan was added successfully");
        }


        private void FindEditAppointemntInDataBase()
        {
            AppDbContext _context = new AppDbContext();
            appointment = _context.DbDoctorsDayPlan.Find(appointment.IdDoctorsDayPlan);
            ChangeOrAddAppointemntData();
            _context.SaveChanges();
            MessageBox.Show("Successfully changed the data!");
        }

        private void ChangeOrAddAppointemntData()
        {
            OfficeModel selectedOffice = (OfficeModel)comboBoxOfficeNumber.SelectedItem;

            appointment.IdOffice = selectedOffice.IdOffice;
            appointment.IdOfTerm = GetIdOfTermFromCombo();
            appointment.IdDay = dateTimePicker.Value.Day;
        }
        #endregion
        #region ChangingForms
        private void Exit()
        {
            if (creatingNew)
            {
                ToFormCalendar();
            }
            else
            {
                FormDoctorCalendarDetails formDoctorCalendarDetails = new FormDoctorCalendarDetails(appointment, currentUser, calendar);
                this.Hide();
                formDoctorCalendarDetails.ShowDialog();
                this.Close();
            }
        }

        private void ToFormCalendar()
        {
            FormDoctorCalendarInChosenMonth formDoctorCalendarICM = new FormDoctorCalendarInChosenMonth(currentUser, calendar);
            this.Hide();
            formDoctorCalendarICM.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
