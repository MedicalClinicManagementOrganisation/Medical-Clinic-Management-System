using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicTest
{
    public class EmployeeServiceTest
    {

        [Fact]
        public void TestGetEmployeesData()
        {
            // Act
            List<EmployeeModel> result = EmployeeService.GetEmployeesData();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TestGetDoctors()
        {
            // Act
            List<EmployeeModel> result = EmployeeService.GetDoctors();

            // Assert
            Assert.NotNull(result);
            Assert.All(result, employee =>
            {
                Assert.Equal(EnumEmployeeRoles.MedicalDoctor, employee.Role);
            });
        }

        [Fact]
        public void TestValidateEmail_ValidInput()
        {
            // Arrange
            string input = "john.doe@example.com";
            string name = "john";

            // Act
            (string message, bool isValid) = EmployeeService.validateEmail(input, name);

            // Assert
            Assert.Equal("Success", message);
            Assert.True(isValid);
        }

        [Fact]
        public void TestValidateEmail_InvalidInput()
        {
            // Arrange
            string input = "invalid_email";
            string name = "john";

            // Act
            (string message, bool isValid) = EmployeeService.validateEmail(input, name);

            // Assert
            Assert.NotEqual("Success", message);
            Assert.False(isValid);
        }

        [Fact]
        public void TestGetEmployeeByID_ExistingEmployeeID()
        {
            // Arrange
            int employeeID = 1;

            // Act
            EmployeeModel result = EmployeeService.GetEmployeeByID(employeeID);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(employeeID, result.IdEmployee);
        }

        [Fact]
        public void TestGetEmployeeByID_NonExistingEmployeeID()
        {
            // Arrange
            int employeeID = 999;

            // Act & Assert
            Assert.Throws<Exception>(() => EmployeeService.GetEmployeeByID(employeeID));
        }

        [Fact]
        public void TestValidatePhone_ValidInput()
        {
            // Arrange
            string input = "123456789";

            // Act
            (string message, bool isValid) = EmployeeService.validatePhone(input);

            // Assert
            Assert.Equal("Success", message);
            Assert.True(isValid);
        }

        [Fact]
        public void TestValidatePhone_InvalidInpute()
        {
            // Arrange
            string input = "1234";

            // Act
            (string message, bool isValid) = EmployeeService.validatePhone(input);

            // Assert
            Assert.NotEqual("Success", message);
            Assert.False(isValid);
        }

        [Fact]
        public void GetEmployeeInfoById()
        {
            // Arrange
            int id = 1;
            string expectedInfo = "Joe Doe";

            // Act
            string result = EmployeeService.GetEmployeeInfoById(id);

            // Assert
            Assert.Equal(expectedInfo, result);
        }
    }
}
