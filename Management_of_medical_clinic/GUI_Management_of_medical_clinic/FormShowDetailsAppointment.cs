using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Migrations;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI_Management_of_medical_clinic
{
	public partial class FormShowDetailsAppointment : Form
	{
		EmployeeModel currentUser;
		DoctorsDayPlanModel appointment;
		PaymentConfirmationGenerator pdfGenerator;

		public FormShowDetailsAppointment(EmployeeModel currentUser, DoctorsDayPlanModel appointment)
		{
			InitializeComponent();
			this.currentUser = currentUser;
			this.appointment = appointment;
			this.pdfGenerator = new PaymentConfirmationGenerator();
		}

		private void FormShowDetailsAppointment_Load(object sender, EventArgs e)
		{
			Patient patient = PatientService.GetPatientById((int)appointment.PatientId);
			EmployeeModel employee = EmployeeService.GetEmployeeByID((int)appointment.IdEmployee);
			SpecializationModel specialization = SpecializationService.GetSpecializationById((int)employee.IdSpecialization);
			OfficeModel office = OfficeService.GetOfficeById((int)appointment.IdOffice);
			DateTime date = CalendarService.GetDateByIdCalendar((int)appointment.IdCalendar, appointment.IdDay);
			string term = AppointmentService.GetTermByTermId((int)appointment.IdOfTerm);

			textBoxPatient.Text = patient.ToString();
			textBoxPESEL.Text = patient.PESEL;
			dateTimePickerDate.Value = date;
			textBoxHour.Text = term;
			textBoxDoktor.Text = employee.ToString();
			textBoxSpecialization.Text = specialization.Name.ToString();
			textBoxOffice.Text = office.Number.ToString();

			if (appointment.Cost == null)
			{
				numericUpDownCost.Value = 0;
			}
			else
			{
				numericUpDownCost.Value = (decimal)appointment.Cost;
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			FormListAppointment formListAppointment = new FormListAppointment(currentUser);
			Hide();
			formListAppointment.ShowDialog();
			Close();
		}

		private void buttonGeneratePDF_Click(object sender, EventArgs e)
		{
			pdfGenerator.GeneratePDFConfirmation(appointment);

			string fullPath = Path.GetFullPath(@$"..\..\..\..\Management_of_medical_clinic\Data\PDF\Payment confirmation for {appointment.IdDoctorsDayPlan}-{appointment.IdCalendar}-{appointment.IdDay}-{appointment.IdOfTerm}.pdf");
			Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
		}
	}
}
