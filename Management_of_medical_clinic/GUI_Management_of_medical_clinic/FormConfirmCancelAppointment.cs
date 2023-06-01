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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormConfirmCancelAppointment : Form
    {
        EmployeeModel currentUser;
        DoctorsDayPlanModel appointment;
        private string source;

        public FormConfirmCancelAppointment(string source, EmployeeModel currentUser, DoctorsDayPlanModel appointment)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.appointment = appointment;
            this.source = source;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            UserModel user = UserService.GetUserByEmployeeId(currentUser);

            if (textBoxPassword.Text != user.Password)
            {
                string msg = "Invalid password!";
                FormMessage formMessage = new FormMessage(msg);
                formMessage.ShowDialog();
                return;
            }

            using (AppDbContext context = new AppDbContext())
            {
                if (source == "cancel")
                {
                    appointment.PatientId = null;
                    appointment.Status = EnumAppointmentStatus.Cancelled;

                    context.Entry(appointment).State = EntityState.Modified;
                    context.SaveChanges();

                    string msg2 = "Appointment cancelled.";
                    FormMessage formMessage2 = new FormMessage(msg2);
                    formMessage2.ShowDialog();
                }
                else if (source == "clear from appointment" || source == "clear from calendar")
                {
                    List<DoctorsDayPlanModel> doctorsDayPlanModels = CalendarAppointmentService.GetAppointmentsWithPatients();

                    foreach (DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlanModels)
                    {
                        DateTime date = CalendarService.GetDateByIdCalendar((int)doctorsDayPlanModel.IdCalendar, doctorsDayPlanModel.IdDay);
                        string term = AppointmentService.GetTermByTermId((int)doctorsDayPlanModel.IdOfTerm);
                        TimeSpan time = TimeSpan.ParseExact(term, "hh\\:mm", null);

                        if (date <= DateTime.Now.Date && time <= DateTime.Now.TimeOfDay && (doctorsDayPlanModel.Status == EnumAppointmentStatus.Accepted ||
                            doctorsDayPlanModel.Status == EnumAppointmentStatus.Scheduled || doctorsDayPlanModel.Status == EnumAppointmentStatus.Confirmed))
                        {
                            doctorsDayPlanModel.Status = EnumAppointmentStatus.Overdue;
                            context.Entry(doctorsDayPlanModel).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                    }

                    string msg3 = "The calendar has been cleared.";
                    FormMessage formMessage3 = new FormMessage(msg3);
                    formMessage3.ShowDialog();
                }
            }

            List<Form> otwarteOkna = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form otwarteOkno in otwarteOkna)
            {
                otwarteOkno.Hide();
            }
            
            if (source == "cancel" || source == "clear from appointment")
            {
                FormListAppointment formListAppointment = new FormListAppointment(currentUser);
                formListAppointment.ShowDialog();
            }
            else if (source == "clear from calendar")
            {
                FormCalendarsList formCalendarsList = new(currentUser);
                formCalendarsList.ShowDialog();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            List<Form> otwarteOkna = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form otwarteOkno in otwarteOkna)
            {
                otwarteOkno.Hide();
            }

            if (source == "cancel" || source == "clear from appointment")
            {
                FormListAppointment formListAppointment = new FormListAppointment(currentUser);
                formListAppointment.ShowDialog();
            }
            else if (source == "clear from calendar")
            {
                FormCalendarsList formCalendarsList = new(currentUser);
                formCalendarsList.ShowDialog();
            }
        }

        private void FormConfirmCancelAppointment_Load(object sender, EventArgs e)
        {
            if (source == "clear from calendar" || source == "clear from appointment")
            {
                label1.Text = "Confirm calendar cleaning. Input password:";
            }
        }
    }
}
