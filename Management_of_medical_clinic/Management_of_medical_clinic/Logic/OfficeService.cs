using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
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

        public static void EditOffice(int idOffice, int number, bool status, string info, int idSpecialization)
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
                    if (context.DbAppointments.Any(a => a.IdOffice == id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
