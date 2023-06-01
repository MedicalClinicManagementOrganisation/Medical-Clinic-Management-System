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
            /*
            if (date != null)
            {
                selectedDate = date;
                selectedDay = date.Day;

                dateReference = selectedDate.ToString("d");
                calendarId = CalendarService.GetCalendarIdByDate(dateReference);
            }
            */

            InitializeComponent();
        }

        private void FormDoctorCalendarModify_Load(object sender, EventArgs e)
        {
            labelModifyAppointment.Text = creatingNew ? "Creating new appointment" : "Modifying Appointment";
            FillOfficesComboBox();

            dateTimePicker.Value = selectedDate;
            if (!creatingNew)
            {
                //Change selecteditem in combobox
                // dodać zaznaczenie wybranego dnia
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
            else
            {

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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTerm.SelectedIndex < 0)
                {
                    MessageBox.Show("You have to select a term");
                    return;
                }

                if (comboBoxOfficeNumber.SelectedIndex < 0)
                {
                    MessageBox.Show("You have to select an office");
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
