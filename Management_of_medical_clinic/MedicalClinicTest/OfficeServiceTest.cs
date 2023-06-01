using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicTest
{
    public class OfficeServiceTest
    {
        [Fact]
        public void TestGetOfficesData()
        {
            // Act
            List<OfficeModel> offices = OfficeService.GetOfficesData();

            // Assert
            Assert.NotNull(offices);
            Assert.NotEmpty(offices);
        }

        [Fact]
        public void TestGetCalendarIds_ReturnsListOfIds()
        {
            // Act
            List<int> officeIds = OfficeService.GetCalendarIds();

            // Assert
            Assert.NotNull(officeIds);
            Assert.NotEmpty(officeIds);
        }


        [Fact]
        public void TestGetOfficeById_ReturnsOffice()
        {
            // Arrange
            int officeId = 1;

            // Act
            OfficeModel office = OfficeService.GetOfficeById(officeId);

            // Assert
            Assert.NotNull(office);
            Assert.Equal(officeId, office.IdOffice);
        }

        [Fact]
        public void TestGetOfficeInfoById_ReturnsOfficeInfo()
        {
            // Arrange
            int officeId = 1;

            // Act
            string officeInfo = OfficeService.GetOfficeInfoById(officeId);

            // Assert
            Assert.NotNull(officeInfo);
            Assert.Contains("Room", officeInfo);
            Assert.Contains(officeId.ToString(), officeInfo);
        }


        [Fact]
        public void TestCheckIfOfficeIsAppointed_ReturnsTrueIfAppointed()
        {
            // Arrange
            int officeId = 1;

            // Act
            bool isAppointed = OfficeService.CheckIfOfficeIsAppointed(officeId);

            // Assert
            Assert.True(isAppointed);
        }

        [Fact]
        public void TestCheckIfOfficeIsAppointed_ReturnsTrueIfNotAppointed()
        {
            // Arrange
            int officeId = 2;

            // Act
            bool isAppointed = OfficeService.CheckIfOfficeIsAppointed(officeId);

            // Assert
            Assert.True(isAppointed);
        }

        [Fact]
        public void TestCheckIfOfficeIsFree_ReturnsTrueIfOfficeIsFree()
        {
            // Arrange
            int idEmployee = 1;
            int idCalendar = 1;
            int selectedDay = 1;
            int idOffice = 1;
            List<int> idOfTerms = new List<int> { 1, 2 };

            // Act
            bool isFree = OfficeService.CheckIfOfficeIsFree(idEmployee, idCalendar, selectedDay, idOffice, idOfTerms, out string message);

            // Assert
            Assert.True(isFree);
            Assert.Equal("", message);
        }

        [Fact]
        public void TestCheckIfOfficeIsFree_ReturnsFalseIfOfficeIsBusy()
        {
            // Arrange
            int idEmployee = 2;
            int idCalendar = 9;
            int selectedDay = 25;
            int idOffice = 1;
            List<int> idOfTerms = new List<int> { 24 };

            // Act
            bool isFree = OfficeService.CheckIfOfficeIsFree(idEmployee, idCalendar, selectedDay, idOffice, idOfTerms, out string message);

            // Assert
            Assert.False(isFree);
            Assert.Equal("A plan for this doctor on this day already exists. You have to edit it if you want to apply changes.", message);
        }
    }
}
