using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Console_Management_of_medical_clinic.Logic
{
    public class UserService
    {
        public static List<UserModel> GetUsersData()
        {
            List<UserModel> users = new List<UserModel>();
            using (var db = new AppDbContext())
            {
                users = db.DbUsers.ToList();
            }

            return users;
        }

        private void checkIfAdmin()
        {

        }

        public static void AddUser(string username, string password, EnumUserRoles role, bool isActive, int employeeId)
        {
            //a method to add new User to Database
            using(AppDbContext context = new AppDbContext())
            {
                context.DbUsers.Add(new UserModel(username, password, role, isActive, employeeId));
                context.SaveChanges();
            }
        } 

        public static List<UserModel> FilterUsers(string username, string firstname, string lastname, string role)
        {

            List<UserModel> filteredUsers = GetUsersData();

            if (!string.IsNullOrEmpty(username))
            {
                filteredUsers = filteredUsers.Where(u => u.Username.Contains(username)).ToList();
            }

            if (!string.IsNullOrEmpty(firstname))
            {
                filteredUsers = filteredUsers.Where(u => EmployeeModel.FindEmployee(u.IdEmployee).FirstName.Contains(firstname)).ToList();
            }

            if (!string.IsNullOrEmpty(lastname))
            {
                filteredUsers = filteredUsers.Where(u => EmployeeModel.FindEmployee(u.IdEmployee).LastName.Contains(lastname)).ToList();
            }

            if (role != "")
            {
                EnumUserRoles roleUser = (EnumUserRoles)Enum.Parse(typeof(EnumUserRoles), role);
                filteredUsers = filteredUsers.Where(u => u.Role == roleUser).ToList();
            }

            return filteredUsers;
        }

        public static UserModel GetUserById(int id)
        {
            return GetUsersData().FirstOrDefault(user => user.IdUser == id);
        }

        public static bool CheckIfUsernameExists(string username)
        {
            List<UserModel> users = UserService.GetUsersData();


            foreach (UserModel user in users)
            {
                if (user.Username == username)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfIdIsAlreadyUsedByEmployeeId(int id)
        {
            return GetUsersData().Any(user => user.IdEmployee == id);
        }

        public static void EditUser(int idUser, string username, EnumUserRoles userRoles, bool isActive, int idEmployee)
        {
            using (AppDbContext context = new AppDbContext()) {
                UserModel user = context.DbUsers.Find(idUser);
                if (user != null)
                {
                    user.Username = username;
                    user.Role = userRoles;
                    user.IsActive = isActive;
                    user.IdEmployee = idEmployee;
                    context.SaveChanges();
                }
            }
        }

        public static bool ValidatePassword(string password)
        {
            return Regex.Match(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[-_!#$*]).{8,15}$").Success;
        }

        public static void ChangePassword(int idUser, string password)
        {
            using(AppDbContext context = new AppDbContext())
            {
                UserModel user = context.DbUsers.Find(idUser);
                if (user != null)
                {
                    user.Password = password;
                    context.SaveChanges();
                }
            }
        }

        public static UserModel GetUserByEmployeeId(EmployeeModel employee)
        {
            List<UserModel> users = GetUsersData();
            foreach(UserModel user in users)
            {
                if(employee.IdEmployee == user.IdEmployee)
                {
                    return user;
                }
            }
            return null;
        }

        public static UserModel GetUserByUsername(string username)
        {
            return GetUsersData().FirstOrDefault(x => x.Username == username);
        }
    }
        
}
