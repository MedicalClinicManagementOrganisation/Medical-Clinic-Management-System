using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Data.Enums
{
	public enum EnumAppointmentStatus
	{
		Inactive = 1,
		New = 2,
		Accepted = 3,
		Scheduled = 4,
		Confirmed = 5,
		Pending = 6,
		Handled = 7,
		Overdue = 8,
		Cancelled = 9,
	};
}