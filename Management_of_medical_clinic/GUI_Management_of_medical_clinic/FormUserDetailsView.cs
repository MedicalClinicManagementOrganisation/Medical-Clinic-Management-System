using Console_Management_of_medical_clinic.Logic;
using Console_Management_of_medical_clinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management_of_medical_clinic
{
    public partial class FormUserDetailsView : Form
    {
        EmployeeModel currentUser;
        UserModel user;

        public FormUserDetailsView()
        {
            InitializeComponent();
        }

        public FormUserDetailsView(UserModel user, EmployeeModel currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.user = user;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormUserList userList = new FormUserList(currentUser);
            Hide();
            userList.ShowDialog();
            Close();
        }

        private void FormUserDetailsView_Load(object sender, EventArgs e)
        {
            EmployeeModel employee = EmployeeService.GetEmployeeByUserId(user);
            textBoxFirstName.Text = employee.FirstName;
            textBoxLastName.Text = employee.LastName;
            textBoxUsername.Text = user.Username;
            textBoxRole.Text = user.Role.ToString();
            textBoxActive.Text = user.IsActive ? "Active" : "Disactive";
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            FormUserEdit userEdit = new FormUserEdit(user, currentUser);
            Hide();
            userEdit.ShowDialog();
            Close();
        }
    }
}
