﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Model
{
    public class DoctorsDayPlanModel
    {
        [Key] public int IdDoctorsDayPlan { get; set; }
        public int IdOfTerm { get; set; }
        public int IdDay { get; set; }
        public bool IsActive { get; set; }
        //Relationships
        [ForeignKey("CalendarModel")] public int? IdCalendar { get; set; }
        public CalendarModel CalendarModel { get; set; }
        [ForeignKey("EmployeeModel")] public int? IdEmployee { get; set; }
        public EmployeeModel EmployeeModel { get; set; }
        [ForeignKey("OfficeModel")] public int? IdOffice { get; set; }
        public OfficeModel OfficeModel { get; set; }
        [ForeignKey("Patient")] public int? PatientId { get; set; }
        public Patient Patient { get; set; }


        public DoctorsDayPlanModel() { }

        public DoctorsDayPlanModel(int idOfTerm,  bool isActive)
        {
            IdOfTerm = idOfTerm;
            IsActive = isActive;
        }

        public DoctorsDayPlanModel(int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, bool isActive)
        {
            IdOfTerm = idOfTerm;
            IdDay = idDay;
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            IsActive = isActive;
        }

        public DoctorsDayPlanModel(int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, int patientId, bool isActive)
        {
            IdOfTerm = idOfTerm;
            IdDay = idDay;            
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            PatientId = patientId;
            IsActive = isActive;
        }

        public DoctorsDayPlanModel(int idDoctorsDayPlan, int idOfTerm, int idDay, int idCalendar, int idEmployee, int idOffice, int patientId, bool isActive)
        {
            IdDoctorsDayPlan = idDoctorsDayPlan;
            IdOfTerm = idOfTerm;
            IdDay = idDay;            
            IdCalendar = idCalendar;
            IdEmployee = idEmployee;
            IdOffice = idOffice;
            PatientId = patientId;
            IsActive = isActive;
        }

    }
}
