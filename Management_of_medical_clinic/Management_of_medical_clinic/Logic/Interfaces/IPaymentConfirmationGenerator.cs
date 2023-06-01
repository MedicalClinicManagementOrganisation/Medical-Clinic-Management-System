using Console_Management_of_medical_clinic.Model;

namespace Console_Management_of_medical_clinic.Logic.Interfaces
{
	public interface IPaymentConfirmationGenerator
	{
		public void GeneratePDFConfirmation(DoctorsDayPlanModel appointment);
	}
}
