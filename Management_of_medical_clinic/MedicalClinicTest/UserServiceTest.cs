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
    public class UserServiceTest
    {
        [Fact]
        public void TestGetUsersData_ReturnsListOfUsers()
        {
            // Act
            List<UserModel> users = UserService.GetUsersData();

            // Assert
            Assert.NotNull(users);
            Assert.NotEmpty(users);
        }

        [Fact]
        public void TestGetUserById_ReturnsUser()
        {
            // Arrange
            int userId = 1;

            // Act
            UserModel user = UserService.GetUserById(userId);

            // Assert
            Assert.NotNull(user);
            Assert.Equal(userId, user.IdUser);
        }

        [Fact]
        public void TestCheckIfUsernameExists_ReturnsTrueIfUsernameExists()
        {
            // Arrange
            string existingUsername = "1";

            // Act
            bool exists = UserService.CheckIfUsernameExists(existingUsername);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void TestCheckIfUsernameExists_ReturnsFalseIfUsernameDoesNotExist()
        {
            // Arrange
            string nonExistingUsername = "NonExistingUser";

            // Act
            bool exists = UserService.CheckIfUsernameExists(nonExistingUsername);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void TestCheckIfIdIsAlreadyUsed_ReturnsTrueIfIdIsAlreadyUsed()
        {
            // Arrange
            int usedId = 1;

            // Act
            bool isUsed = UserService.CheckIfIdIsAlreadyUsedByEmployeeId(usedId);

            // Assert
            Assert.True(isUsed);
        }

        [Fact]
        public void TestCheckIfIdIsAlreadyUsed_ReturnsFalseIfIdIsNotAlreadyUsed()
        {
            // Arrange
            int unusedId = 100;

            // Act
            bool isUsed = UserService.CheckIfIdIsAlreadyUsedByEmployeeId(unusedId);

            // Assert
            Assert.False(isUsed);
        }

        [Fact]
        public void TestValidatePassword_ReturnsTrueForValidPassword()
        {
            // Arrange
            string validPassword = "StrongPassword123!";

            // Act
            bool isValid = UserService.ValidatePassword(validPassword);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void TestValidatePassword_ReturnsFalseForInvalidPassword()
        {
            // Arrange
            string invalidPassword = "weakpassword";

            // Act
            bool isValid = UserService.ValidatePassword(invalidPassword);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void TestGetUserByEmployeeId_ReturnsUserForExistingEmployeeId()
        {
            // Arrange
            int employeeId = 1;

            // Act
            UserModel user = UserService.GetUserByEmployeeId(new EmployeeModel { IdEmployee = employeeId });

            // Assert
            Assert.NotNull(user);
            Assert.Equal(employeeId, user.IdEmployee);
        }

        [Fact]
        public void TestGetUserByEmployeeId_ReturnsNullForNonExistingEmployeeId()
        {
            // Arrange
            int nonExistingEmployeeId = 100;

            // Act
            UserModel user = UserService.GetUserByEmployeeId(new EmployeeModel { IdEmployee = nonExistingEmployeeId });

            // Assert
            Assert.Null(user);
        }
    }
}
