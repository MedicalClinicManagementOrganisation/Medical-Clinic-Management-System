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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormUserList : Form
    {
        EmployeeModel currentUser;
        void LoadUserData()
        {
            dataGridViewUsers.DataSource = null;

            if (dataGridViewUsers.Rows.Count > 0)
            {
                dataGridViewUsers.Rows.Clear();
            }

            foreach (UserModel user in UserService.GetUsersData())
            {
                dataGridViewUsers.Rows.Add(user.Username, EmployeeService.GetEmployeeByUserId(user).FirstName, EmployeeService.GetEmployeeByUserId(user).LastName, user.Role, (user.IsActive == true) ? "Active" : "Not active");
                if (user.IdEmployee == currentUser.IdEmployee) { currentUser = EmployeeService.GetEmployeeByUserId(user); }     // it makes user always refreshed
            }

        }

        private void buttonFilterUser_Click(object sender, EventArgs e)
        {
            List<UserModel> filteredUsers = UserService.FilterUsers(textBoxUsername.Text, textBoxFirstname.Text, textBoxLastname.Text, comboBoxRole.SelectedItem == null ? "" : comboBoxRole.SelectedItem.ToString());

            dataGridViewUsers.Rows.Clear();
            foreach (UserModel user in filteredUsers)
            {
                dataGridViewUsers.Rows.Add(user.Username, EmployeeService.GetEmployeeByUserId(user).FirstName, EmployeeService.GetEmployeeByUserId(user).LastName, user.Role, (user.IsActive == true) ? "Active" : "Not Active");
            }

        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.Rows.Clear();

            dataGridViewUsers.Columns.Add("Username", "Username");
            dataGridViewUsers.Columns.Add("FirstName", "First name");
            dataGridViewUsers.Columns.Add("LastName", "Last name");
            dataGridViewUsers.Columns.Add("Role", "Role");
            dataGridViewUsers.Columns.Add("IsActive", "Is active?");

            LoadUserData();
        }

        public FormUserList(EmployeeModel user)
        {
            currentUser = user;
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormUserAdd userAdd = new FormUserAdd(currentUser);
            Hide();
            userAdd.ShowDialog();
            Close();
        }

        private void buttonReviewUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can view data of the only one user at a time. Please select one user from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            FormUserDetailsView userDetailsView = new FormUserDetailsView(UserService.GetUserByUsername(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString()), currentUser);
            Hide();
            userDetailsView.ShowDialog();
            Close();
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can edit data of the only one user at a time. Please select one user from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            FormUserEdit formUser = new FormUserEdit(UserService.GetUserByUsername(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString()), currentUser);
            Hide();
            formUser.ShowDialog();
            Close();
        }

        private void buttonDeactivateUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can deactivate only one user at a time. Please select one user from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            if (dataGridViewUsers.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Not active")
            {
                MessageBox.Show("User is deactive!");
                return;
            }

            UserModel user = UserService.GetUserByUsername(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString());
            FormChangeStatusOfUser deactivate = new FormChangeStatusOfUser(user, currentUser);
            deactivate.ShowDialog();
        }

        private void buttonReactivateUser_Click(object sender, EventArgs e)
        {

            if (dataGridViewUsers.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can reactivate only one user at a time. Please select one user from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dataGridViewUsers.CurrentCell.RowIndex;
            if (dataGridViewUsers.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Active")
            {
                MessageBox.Show("User is Active!");
                return;
            }

            UserModel user = UserService.GetUserByUsername(dataGridViewUsers.CurrentRow.Cells[0].Value.ToString());
            FormChangeStatusOfUser deactivate = new FormChangeStatusOfUser(user, currentUser);
            deactivate.ShowDialog();

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
            Close();
        }

        private void buttonFilterClear_Click(object sender, EventArgs e)
        {
            LoadUserData();
            textBoxFirstname.Text = null;
            textBoxLastname.Text = null;
            textBoxUsername.Text = null;
            comboBoxRole.SelectedItem = null;
        }
    }
}
