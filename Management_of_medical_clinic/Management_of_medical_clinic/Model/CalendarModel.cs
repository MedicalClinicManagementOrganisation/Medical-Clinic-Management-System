using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class CalendarModel
    {
        [Key] public int IdCalendar { get; set; }

        public string DateReference { get; set; } //format: "mm-yyyy"
        public bool Active { get; set; }
        public int? NumberOfDoctors { get; set; } = 0;
        public int? NumberOfAcceptedDoctors { get; set; } = 0;
        //Relationships

        //public int IdEmployee { get; set; } //added by doctors
        public List<AppointmentModel>? AppointmentModels { get; set; }
        public List<DoctorsDayPlanModel>? DoctorsDayPlanModels { get; set; }


        public CalendarModel() { }

        public CalendarModel(string dateReference, bool active)
        {
            DateReference = dateReference;
            Active = active;
        }
    }
}
