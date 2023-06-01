using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MedicalClinicTest
{
    public class CalendarAppointmentServiceTest
    {
        #region Fake Data

        Patient fakePatient = new Patient()
        {
            PatientId = 1000,
            FirstName = "Jan",
            LastName = "Kowalski",
            PESEL = "88010112339",
            Sex = EnumSex.Male,
            BirthDate = new DateTime(1988, 1, 1),
            IsActive = true,
            LastVisitDate = null
        };

        EmployeeModel firstFakeEmployee = new EmployeeModel()
        {
            IdEmployee = 1000,
            FirstName = "Piotr",
            LastName = "Nowak",
            PESEL = "92013012345",
            DateOfBirth = "13-01-1992"
        };

        DoctorsDayPlanModel firstFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 1,
            IdDay = 11,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 1000,
            PatientId = 1000,
            IdOffice = 1
        };

        DoctorsDayPlanModel secondFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 1,
            IdDay = 11,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 1000,
            PatientId = null,
            IdOffice = 1
        };

        DoctorsDayPlanModel thirdFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 3,
            IdDay = 3,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 3,
            PatientId = 1,
            IdOffice = 1
        };

        DoctorsDayPlanModel fourthFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 4,
            IdDay = 4,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 4,
            PatientId = 4,
            IdOffice = 2
        };

        #endregion

        #region Fake data to sort 

        EmployeeModel secendFakeEmployee = new EmployeeModel()
        {
            IdEmployee = 1001,
            FirstName = "Piotr",
            LastName = "Zowak",
            PESEL = "85091022515",
            DateOfBirth = "10-09-1985"
        };

        EmployeeModel thirdFakeEmployee = new EmployeeModel()
        {
            IdEmployee = 1002,
            FirstName = "Piotr",
            LastName = "Awak",
            PESEL = "85091087877",
            DateOfBirth = "10-09-1985"
        };

        DoctorsDayPlanModel fifthFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 2,
            IdDay = 2,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 1001,
            PatientId = 4,
            IdOffice = 2
        };

        DoctorsDayPlanModel sixthFakeAppointment = new DoctorsDayPlanModel()
        {
            IdOfTerm = 1,
            IdDay = 2,
            Cost = 1000,
            Status = EnumAppointmentStatus.Scheduled,
            IdCalendar = 1,
            IdEmployee = 1002,
            PatientId = 4,
            IdOffice = 2
        };


        #endregion

        #region SortByDoctorLastName

        [Fact]
        public void TestSortByDoctor_correct()
        {
            EmployeeService.AddEmployee(secendFakeEmployee);
            EmployeeService.AddEmployee(thirdFakeEmployee);

            AppointmentService.AddAppointment(fifthFakeAppointment);
            AppointmentService.AddAppointment(sixthFakeAppointment);


            List<DoctorsDayPlanModel> fakeListAppointments = new List<DoctorsDayPlanModel>();
            fakeListAppointments.Add(fifthFakeAppointment); //Zowak
            fakeListAppointments.Add(sixthFakeAppointment); //Awak

            List<DoctorsDayPlanModel> test = CalendarAppointmentService.SortByDoctorLastName(fakeListAppointments);
            int result = (int)test[0].IdEmployee;
            int expect = 1002;
            Assert.Equal(expect, result);


            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Remove(fifthFakeAppointment);
                context.DbDoctorsDayPlan.Remove(sixthFakeAppointment);

                context.DbEmployees.Remove(secendFakeEmployee);
                context.DbEmployees.Remove(thirdFakeEmployee);
                
                context.SaveChanges();
            }

        }

        #endregion

        #region SortByTerm

        [Fact]
        public void TestSortByTerm_correct()
        {
            EmployeeService.AddEmployee(secendFakeEmployee);
            EmployeeService.AddEmployee(thirdFakeEmployee);

            AppointmentService.AddAppointment(fifthFakeAppointment);
            AppointmentService.AddAppointment(sixthFakeAppointment);

            List<DoctorsDayPlanModel> fakeListAppointments = new List<DoctorsDayPlanModel>
            {
                fifthFakeAppointment, //2
                sixthFakeAppointment //1
            };

            List<DoctorsDayPlanModel> test = CalendarAppointmentService.SortByTerm(fakeListAppointments);
            int result = (int)test[0].IdOfTerm;
            int expect = 1;
            Assert.Equal(expect, result);


            using (AppDbContext context = new AppDbContext())
            {
                context.DbDoctorsDayPlan.Remove(fifthFakeAppointment);
                context.DbDoctorsDayPlan.Remove(sixthFakeAppointment);

                context.DbEmployees.Remove(secendFakeEmployee);
                context.DbEmployees.Remove(thirdFakeEmployee);

                context.SaveChanges();
            }

        }
        #endregion

        #region GetPatientDataByIdPatient

        [Fact]
        public void TestGetPatientDataByIdPatient_Correct()
        {
            AppDbContext context = new AppDbContext();

            Patient patient = fakePatient;
            context.Patients.Add(patient);

            EmployeeModel employee = firstFakeEmployee;
            context.DbEmployees.Add(employee);

            DoctorsDayPlanModel first = firstFakeAppointment;
            context.DbDoctorsDayPlan.Add(first);
            context.SaveChanges();

            Patient result = CalendarAppointmentService.GetPatientDataByIdPatient(first);

            Assert.NotNull(result);
            Assert.Equal(patient.FirstName, result.FirstName);
            Assert.Equal(patient.LastName, result.LastName);
            Assert.Equal(patient.PESEL, result.PESEL);
            Assert.Equal(patient.Sex, result.Sex);
            Assert.Equal(patient.BirthDate, result.BirthDate);
            Assert.Equal(patient.IsActive, result.IsActive);
            Assert.Equal(patient.LastVisitDate, result.LastVisitDate);

            context.DbDoctorsDayPlan.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void GetPatientDataByIdPatient_PatientNotFound()
        {
            DoctorsDayPlanModel appointment = new DoctorsDayPlanModel
            {
                PatientId = 9999
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetPatientDataByIdPatient(appointment));
            Assert.Equal("Patient not found in database", exception.Message);
        }

        [Fact]
        public void GetPatientDataByIdPatient_PatientIsNull()
        {
            DoctorsDayPlanModel appointment = new DoctorsDayPlanModel
            {
                PatientId = null
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetPatientDataByIdPatient(appointment));
            Assert.Equal("PatientId = null", exception.Message);
        }

        #endregion

        #region GetAppointmentsWithPatients

        [Fact]
        public void TestGetAppointmentsWithPatients_Include()
        {
            AppDbContext context = new AppDbContext();

            Patient patient = fakePatient;
            context.Patients.Add(patient);

            EmployeeModel employee = firstFakeEmployee;
            context.DbEmployees.Add(employee);

            DoctorsDayPlanModel first = firstFakeAppointment;
            context.DbDoctorsDayPlan.Add(first);
            context.SaveChanges();

            List<DoctorsDayPlanModel> result = CalendarAppointmentService.GetAppointmentsWithPatients();

            Assert.Contains(result, a => a.IdDoctorsDayPlan == first.IdDoctorsDayPlan);

            context.DbDoctorsDayPlan.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void TestGetAppointmentsWithPatients_NotInclude()
        {
            AppDbContext context = new AppDbContext();

            EmployeeModel employee = firstFakeEmployee;
            context.DbEmployees.Add(employee);

            DoctorsDayPlanModel second = secondFakeAppointment;
            context.DbDoctorsDayPlan.Add(second);
            context.SaveChanges();

            List<DoctorsDayPlanModel> result = CalendarAppointmentService.GetAppointmentsWithPatients();

            Assert.DoesNotContain(result, a => a.IdDoctorsDayPlan == second.IdDoctorsDayPlan);

            context.DbDoctorsDayPlan.Remove(second);
            context.DbEmployees.Remove(employee);
            context.SaveChanges();
        }

        #endregion

        #region GetLastNameAndNameOfEmployeeByAppointment

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_Correct()
        {
            AppDbContext context = new AppDbContext();

            EmployeeModel employee = firstFakeEmployee;
            context.DbEmployees.Add(employee);

            Patient patient = fakePatient;
            context.Patients.Add(patient);

            DoctorsDayPlanModel first = firstFakeAppointment;
            context.DbDoctorsDayPlan.Add(first);
            context.SaveChanges();

            string result = CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(first);
            string full_name = employee.FirstName + " " + employee.LastName;
           
            Assert.Equal(full_name, result);

            context.DbDoctorsDayPlan.Remove(first);
            context.DbEmployees.Remove(employee);
            context.Patients.Remove(patient);
            context.SaveChanges();
        }

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_EmployeeNotFound()
        {
            DoctorsDayPlanModel appointment = new DoctorsDayPlanModel
            {
                IdEmployee = 9999
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(appointment));
            Assert.Equal("Employee not found in database", exception.Message);
        }

        [Fact]
        public void TestGetLastNameAndNameOfEmployeeByAppointment_EmployeeIsNull()
        {
            DoctorsDayPlanModel appointment = new DoctorsDayPlanModel
            {
                IdEmployee = null
            };

            Exception exception = Assert.Throws<Exception>(() => CalendarAppointmentService.GetLastNameAndNameOfEmployeeByAppointment(appointment));
            Assert.Equal("IdEmployee = null", exception.Message);
        }

        #endregion

        #region AppointmentInSelectedDate
        [Fact]
        public void TestappointmentInSelectedDate_Correct()
        {
            DateTime selectedDate = new DateTime(2023, 05, 06);
            int idCalendar = 1;
            List<DoctorsDayPlanModel> appointments = new List<DoctorsDayPlanModel>()
            {
            new DoctorsDayPlanModel 
            {
                IdOfTerm = 3,
                IdDay = 6,
                Cost = 150,
                Status = EnumAppointmentStatus.Scheduled,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1
            },
            new DoctorsDayPlanModel 
            { 
                IdOfTerm = 4,
                IdDay = 6,
                Cost = 150,
                Status = EnumAppointmentStatus.Scheduled,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1 
            },
            new DoctorsDayPlanModel 
            {  
                IdOfTerm = 3,
                IdDay = 6,
                Cost = 100,
                Status = EnumAppointmentStatus.Scheduled,
                IdCalendar = 2,
                IdEmployee = 3,
                PatientId = 1,
                IdOffice = 1 }
            };

            List<DoctorsDayPlanModel> result = CalendarAppointmentService.appointmentInSelectedDate(appointments, selectedDate, idCalendar);

            Assert.Equal(2, result.Count);
            Assert.All(result, appointment => Assert.Equal(1, appointment.IdCalendar));
            Assert.All(result, appointment => Assert.Equal(6, appointment.IdDay));
        }


        [Fact]
        public void TestappointmentInSelectedDate_incorrect()
        {
            DateTime selectedDate = new DateTime(2023, 05, 06);
            int idCalendar = 2;

            List<DoctorsDayPlanModel> appointments = new List<DoctorsDayPlanModel>()
            {
            new DoctorsDayPlanModel 
            { 
                IdOfTerm = 3,
                IdDay = 4,
                Cost = 1000,
                Status = EnumAppointmentStatus.Scheduled,
                IdCalendar = 2,
                IdEmployee = 3,
                PatientId = 2,
                IdOffice = 1 },
            new DoctorsDayPlanModel 
            { 
                IdOfTerm = 10,
                IdDay = 9,
                Cost = 1000,
                Status = EnumAppointmentStatus.Scheduled,
                IdCalendar = 1,
                IdEmployee = 3,
                PatientId = 3,
                IdOffice = 1 }
            };

            List<DoctorsDayPlanModel> result = CalendarAppointmentService.appointmentInSelectedDate(appointments, selectedDate, idCalendar);
            Assert.Empty(result);
        }
        #endregion

        #region GetAppointmentsData
        [Fact]
        public void TestGetAppointmentsData_Correct()
        {
            using (AppDbContext context = new AppDbContext())
            {
                DoctorsDayPlanModel fourth = fourthFakeAppointment;
                context.DbDoctorsDayPlan.Add(fourth);
                DoctorsDayPlanModel third = thirdFakeAppointment;
                context.DbDoctorsDayPlan.Add(third);
                context.SaveChanges();

                int Count = context.DbDoctorsDayPlan.Count();

                var result = CalendarAppointmentService.GetAppointmentsData();
                Assert.Equal(Count, result.Count);
                Assert.Contains(result, a => a.IdOfTerm == 3);
                Assert.Contains(result, a => a.IdOfTerm == 4);
                Assert.Contains(result, a => a.IdDay == 3);
                Assert.Contains(result, a => a.IdDay == 4);
                Assert.Contains(result, a => a.Cost == 1000);
                Assert.Contains(result, a => a.Cost == 1000);
                Assert.Contains(result, a => a.Status == EnumAppointmentStatus.Scheduled);
                Assert.Contains(result, a => a.Status == EnumAppointmentStatus.Scheduled);
                Assert.Contains(result, a => a.IdCalendar == 1);
                Assert.Contains(result, a => a.IdCalendar == 1);
                Assert.Contains(result, a => a.IdEmployee == 3);
                Assert.Contains(result, a => a.IdEmployee == 4);
                Assert.Contains(result, a => a.PatientId == 1);
                Assert.Contains(result, a => a.PatientId == 4);
                Assert.Contains(result, a => a.IdOffice == 1);
                Assert.Contains(result, a => a.IdOffice == 2);

                context.DbDoctorsDayPlan.Remove(fourth);
                context.DbDoctorsDayPlan.Remove(third);
                context.SaveChanges();

            }
        }

        #region GetDateByIdCalendar

        [Fact]
        public void TestGetDateByIdCalendar()
        {
           
            // Arrange
            int idCalendar = 1;
            int dayOfMonth = 15;
            DateTime expectedDate = new DateTime(2023, 03, dayOfMonth);
            // assumes that the DateReference for idCalendar is "03/2023"

            // Act
            CalendarService calendarService = new CalendarService();
            DateTime actualDate = CalendarService.GetDateByIdCalendar(idCalendar, dayOfMonth);

            // Assert
            Assert.Equal(expectedDate, actualDate);


        }

        #endregion

        #region GetIdFromDate
        [Fact]
        public void TestGetIdFromDate()
        {
            // Arrange
            DateTime date = new DateTime(2023, 5, 1);
            int expectedId = 5; // Assuming that there is a calendar in the database for May 2023 with id = 4

            // Act
            CalendarService calendarService = new CalendarService();
            int result = CalendarService.GetIdFromDate(date);

            // Assert
            Assert.Equal(expectedId, result);
        }
        #endregion
    }
    #endregion

}