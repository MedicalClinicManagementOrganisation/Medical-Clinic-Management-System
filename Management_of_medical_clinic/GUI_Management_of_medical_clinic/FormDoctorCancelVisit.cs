using Console_Management_of_medical_clinic.Data;
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
    public partial class FormDoctorCancelVisit : Form
    {
        private List<DoctorsDayPlanModel> selectedAppointments;
        private EmployeeModel currentUser;
        public FormDoctorCancelVisit(List<DoctorsDayPlanModel> selectedAppointments, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.selectedAppointments = selectedAppointments;
            this.currentUser = currentUser;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormDoctorCancelVisit_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (DoctorsDayPlanModel appointment in selectedAppointments)
            {
                Patient patient = PatientService.GetPatientById(appointment.PatientId.Value);
                if (appointment != null)
                    listBox1.Items.Add($"{appointment.IdDoctorsDayPlan} {patient.FirstName} {patient.LastName} {appointment.IdDay} ");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctorCurrentCalendar currentCalendar = new FormDoctorCurrentCalendar(currentUser);
            currentCalendar.ShowDialog();
        }



        private void buttonRemoveFromList_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                selectedAppointments.RemoveAt(selectedIndex);
            }
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            using (AppDbContext db = new AppDbContext())
            {
                foreach (DoctorsDayPlanModel appointment in selectedAppointments)
                {
                    DoctorsDayPlanModel cancelAppointment = db.DbDoctorsDayPlan.Find(appointment.IdDoctorsDayPlan);
                    if (cancelAppointment != null)
                    {
                        cancelAppointment.Status = (EnumAppointmentStatus)9;
                        db.SaveChanges();
                    }
                }
                this.Hide();
                FormDoctorCurrentCalendar currentCalendar = new FormDoctorCurrentCalendar(currentUser);
                currentCalendar.ShowDialog();
            }
        }
    }
}
