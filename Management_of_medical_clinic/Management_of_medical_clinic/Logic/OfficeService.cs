using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class OfficeService
    {
        
        public static List<OfficeModel> GetOfficesData()
        {
            List<OfficeModel> offices;
            using (AppDbContext db = new AppDbContext())
            {
                offices = db.DbOffices.ToList();
            }
            return offices;
        }

        public static List<int> GetCalendarIds()
        {
            List<int> officeIds = new List<int>();
            List<OfficeModel> offices = GetOfficesData();

            foreach (OfficeModel office in offices)
            {
                officeIds.Add(office.IdOffice);
            }
            return officeIds;
        }

        public static void AddOffice(OfficeModel newOffice)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.DbOffices.Add(newOffice);
                db.SaveChanges();
            }
        }

        public static bool CheckIfNumberExists(int number)
        {
            return GetOfficesData().Any(o => o.Number == number);
        }

        public static OfficeModel GetOfficeById(int id)
        {
            return GetOfficesData().FirstOrDefault(o => o.IdOffice == id);
        }

        public static string GetOfficeInfoById(int id)
        {
            OfficeModel office = GetOfficeById(id);
            return "Room: "+office.Number.ToString()+", "+office.Info;
        }

        public static OfficeModel GetOfficeByInfo(string info)
        {
            return GetOfficesData().FirstOrDefault(office => ("Room: " + office.Number.ToString() + ", " + office.Info).Equals(info));
        }

        public static void EditOffice(int idOffice, int number, EnumOfficeStatuses status, string info, int idSpecialization)
        {
            using (AppDbContext context = new AppDbContext())
            {
                OfficeModel office = context.DbOffices.Find(idOffice);
                if (office != null)
                {
                    office.Number = number;
                    office.Status = status;
                    office.Info = info;
                    office.IdSpecialization = idSpecialization;
                    context.SaveChanges();
                }
            }
        }

        public static void RemoveOfficeById(int id)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.DbOffices.Remove(context.DbOffices.Find(id));
                context.SaveChanges();
            }
        }

        public static bool CheckIfOfficeIsAppointed(int id)
        {
            if (id >= 0)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    if (context.DbDoctorsDayPlan.Any(a => a.IdOffice == id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool CheckIfOfficeIsFree(int idEmployee, int idCalendar, int selectedDay, int idOffice, List<int> idOfTerms, out string message)
        {
            List<DoctorsDayPlanModel> doctorsDayPlans;
            using(AppDbContext context = new AppDbContext())
            {
                doctorsDayPlans = context.DbDoctorsDayPlan.ToList();
            }


            foreach(DoctorsDayPlanModel doctorsDayPlanModel in doctorsDayPlans)
            {
                if(doctorsDayPlanModel.IdEmployee == idEmployee && doctorsDayPlanModel.IdCalendar == idCalendar && doctorsDayPlanModel.IdDay == selectedDay)
                {
                    message = "A plan for this doctor on this day already exists. You have to edit it if you want to apply changes.";
                    return false;
                }

                if(doctorsDayPlanModel.IdCalendar==idCalendar && doctorsDayPlanModel.IdOffice == idOffice && doctorsDayPlanModel.IdDay == selectedDay)
                {
                    foreach(int idTerm in idOfTerms)
                    {
                        if (idTerm == doctorsDayPlanModel.IdOfTerm)
                        {
                            message = "Office is busy at this term";
                            return false;
                        }
                    }
                }
            }

            message = "";
            return true;
        }

        public static bool CheckIfOfficeIsFreeForProvidedTerm(int employeeId, int idCalendar, int selectedDay, int idOffice, List<int> idOfTerms, out string message)
        {
            foreach (DoctorsDayPlanModel doctorsPlan in DoctorsPlanService.GetDoctorsPlanData())
            {
                if (doctorsPlan.IdCalendar == idCalendar && doctorsPlan.IdOffice == idOffice && doctorsPlan.IdDay == selectedDay)
                {
                    foreach (int idTerm in idOfTerms)
                    {
                        if (idTerm == doctorsPlan.IdOfTerm && !DoctorsPlanService.GetBookedTermsOfDoctorForCurrentDay(employeeId, selectedDay, idCalendar).Contains(idTerm))
                        {
                            message = "Office is busy at this term";
                            return false;
                        }
                    }
                }
            }

            message = "";
            return true;
        }

        public static List<OfficeModel> GetOfficesBySpecializationId(int specializationId)
        {
            return GetOfficesData().Where(office => office.IdSpecialization ==  specializationId).ToList();
        }
    }

    
}
