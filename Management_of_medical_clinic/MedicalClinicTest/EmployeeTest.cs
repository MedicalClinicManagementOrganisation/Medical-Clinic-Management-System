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
    public class EmployeeTest
    {

        [Fact]
        public void TestFindEmployeeById()
        {
            // Arrange
            int existingEmployeeId = 1;

            // Act
            EmployeeModel result = EmployeeModel.FindEmployee(existingEmployeeId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(existingEmployeeId, result.IdEmployee);
        }

        [Fact]
        public void TestFilterEmployees_MatchingRoleAndActiveStatus()
        {
            // Arrange
            EnumEmployeeRoles role = EnumEmployeeRoles.Janitor;
            bool isActive = true;

            // Act
            List<EmployeeModel> result = EmployeeModel.FilterEmployees(role, isActive);

            // Assert
            Assert.NotNull(result);
            Assert.All(result, employee =>
            {
                Assert.Equal(role, employee.Role);
                Assert.Equal(isActive, employee.IsActive);
            });
        }

        [Fact]
        public void TestToString_FullName()
        {
            // Arrange
            EmployeeModel employee = new EmployeeModel
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Act
            string result = employee.ToString();

            // Assert
            Assert.Equal("Doe John", result);
        }

        [Fact]
        public void TestFullNameWithId()
        {
            // Arrange
            EmployeeModel employee = new EmployeeModel
            {
                IdEmployee = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            // Act
            string result = employee.FullNameWithId();

            // Assert
            Assert.Equal("1-John Doe", result);
        }
    }
}
