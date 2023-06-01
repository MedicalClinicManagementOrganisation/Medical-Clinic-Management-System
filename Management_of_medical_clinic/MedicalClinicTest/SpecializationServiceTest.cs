using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinicTest
{
    public class SpecializationServiceTest
    {
        [Fact]
        public void TestGetSpecializationsData()
        {
            // Act
            List<SpecializationModel> specializations = SpecializationService.GetSpecializationsData();

            // Assert
            Assert.NotNull(specializations);
            Assert.NotEmpty(specializations);
        }

        [Fact]
        public void TestCheckIfSpecializationExists_ReturnsTrueIfSpecializationExists()
        {
            // Arrange
            string existingSpecialization = "Surgeon";

            // Act
            bool exists = SpecializationService.CheckIfSpecializationExists(existingSpecialization);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void TestCheckIfSpecializationExists_ReturnsFalseIfSpecializationDoesNotExist()
        {
            // Arrange
            string nonExistingSpecialization = "NonExistingSpecialization";

            // Act
            bool exists = SpecializationService.CheckIfSpecializationExists(nonExistingSpecialization);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void TestGetSpecializationIdByName_ReturnsIdForExistingSpecialization()
        {
            // Arrange
            string existingSpecialization = "Surgeon";
            int expectedId = 1;

            // Act
            int specializationId = SpecializationService.getSpecializationIdByName(existingSpecialization);

            // Assert
            Assert.Equal(expectedId, specializationId);
        }

        [Fact]
        public void TestGetSpecializationIdByName_ReturnsZeroForNonExistingSpecialization()
        {
            // Arrange
            string nonExistingSpecialization = "NonExistingSpecialization";
            int expectedId = 0;

            // Act
            int specializationId = SpecializationService.getSpecializationIdByName(nonExistingSpecialization);

            // Assert
            Assert.Equal(expectedId, specializationId);
        }

        [Fact]
        public void TestCheckIfSpecializationIsAssigned_ReturnsTrueIfSpecializationIsAssigned()
        {
            // Arrange
            List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel { IdSpecialization = 1 },
            new EmployeeModel { IdSpecialization = 2 },
            new EmployeeModel { IdSpecialization = 1 }
        };
            int assignedSpecializationId = 1;

            // Act
            bool isAssigned = SpecializationService.checkIfSpecializationIsAssigned(employees, assignedSpecializationId);

            // Assert
            Assert.True(isAssigned);
        }

        [Fact]
        public void TestCheckIfSpecializationIsAssigned_ReturnsFalseIfSpecializationIsNotAssigned()
        {
            // Arrange
            List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel { IdSpecialization = 2 },
            new EmployeeModel { IdSpecialization = 3 },
            new EmployeeModel { IdSpecialization = 4 }
        };
            int assignedSpecializationId = 1;

            // Act
            bool isAssigned = SpecializationService.checkIfSpecializationIsAssigned(employees, assignedSpecializationId);

            // Assert
            Assert.False(isAssigned);
        }

        [Fact]
        public void TestGetSpecializationNameById_ReturnsSpecializationName()
        {
            // Arrange
            int specializationId = 1;
            string expectedName = "Surgeon";

            // Act
            string specializationName = SpecializationService.GetSpecializationNameById(specializationId);

            // Assert
            Assert.Equal(expectedName, specializationName);
        }
    }
}
