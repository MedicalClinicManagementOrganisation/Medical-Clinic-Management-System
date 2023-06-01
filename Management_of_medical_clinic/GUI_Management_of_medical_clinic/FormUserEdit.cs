using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormUserEdit : Form
    {
        EmployeeModel currentUser;
        UserModel user;

        public FormUserEdit()
        {
            InitializeComponent();
        }

        public FormUserEdit(UserModel user, EmployeeModel currentUser)
        {
            this.user = user;
            this.currentUser = currentUser;

            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = user.Username;
            comboBoxRole.SelectedItem = user.Role.ToString();

            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                if (!UserService.CheckIfIdIsAlreadyUsedByEmployeeId(employee.IdEmployee) || employee.IdEmployee == user.IdEmployee)
                {
                    listBoxEmployees.Items.Add(employee.IdEmployee + " " + employee.FirstName + " " + employee.LastName);
                }
            }
            if (listBoxEmployees.Items.Count == 0) listBoxEmployees.Items.Add("There are no employees without a user.");
            listBoxEmployees.SelectedIndex = 0;
            checkIfRequiredFilled();
        }

        public void checkIfRequiredFilled()
        {
            buttonSaveUser.Enabled = false;
            if (textBoxUsername.Text.Trim().Length > 0 && listBoxEmployees.SelectedItem != null && comboBoxRole.SelectedItem != null)
            {
                if ((listBoxEmployees.Items[0].ToString() != "There are no employees without a user.") && (user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value) || !comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString())))
                {
                    buttonSaveUser.Enabled = true;
                }
            }
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            UserService.EditUser(user.IdUser, textBoxUsername.Text, (EnumUserRoles)Enum.Parse(typeof(EnumUserRoles), comboBoxRole.SelectedItem.ToString()), user.IsActive, int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value));

            MessageBox.Show("Success, data is saved.");

            FormUserList userList = new FormUserList(currentUser);
            Hide();
            userList.ShowDialog();
            Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (user.IdEmployee != int.Parse(Regex.Match(listBoxEmployees.SelectedItem.ToString(), @"^\d+").Value) || !comboBoxRole.SelectedItem.ToString().Equals(user.Role.ToString()))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            FormUserList userList = new FormUserList(currentUser);
            Hide();
            userList.ShowDialog();
            Close();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.Items[0].ToString().Equals("There are no employees without a user."))
            {
                listBoxEmployees.SelectedItem = null;
            }
            checkIfRequiredFilled();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePasswordOfUser formChange = new FormChangePasswordOfUser(user, currentUser);
            formChange.ShowDialog();
            Show();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            FormChangeStatusOfUser formChange = new FormChangeStatusOfUser(user, currentUser);
            formChange.ShowDialog();
        }
    }
}
