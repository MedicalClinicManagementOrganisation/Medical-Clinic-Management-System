using Console_Management_of_medical_clinic.Data.Enums;
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
    public partial class FormEmployeeList : Form
    {
        EmployeeModel currentUser;     // from now 'employee object' which is moving beetween forms is person logged to system
        //string[] roles = { "Employee", "Medical Doctor", "Manager", "None" };

        void LoadEmployeeData()
        {
            dataGridViewEmployees.DataSource = null;

            if (dataGridViewEmployees.Rows.Count > 0)
            {
                dataGridViewEmployees.Rows.Clear();
            }

            foreach (EmployeeModel employee in EmployeeService.GetEmployeesData())
            {
                dataGridViewEmployees.Rows.Add(employee.IdEmployee, employee.FirstName, employee.LastName, employee.Role, (employee.IsActive == true) ? "Active" : "Not Active");

                if (employee.IdEmployee == currentUser.IdEmployee) { currentUser = employee; }     // it makes user always refreshed
            }
        }

        public FormEmployeeList(EmployeeModel emp)
        {
            currentUser = emp;
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            dataGridViewEmployees.Rows.Clear();
            //comboBoxRole.Items.Clear();
            //comboBoxRole.Items.AddRange(roles);
            dataGridViewEmployees.Columns.Add("IdEmployee", "Id of Employee");
            dataGridViewEmployees.Columns.Add("FirstName", "First Name");
            dataGridViewEmployees.Columns.Add("LastName", "Last Name");
            dataGridViewEmployees.Columns.Add("Role", "Role");
            dataGridViewEmployees.Columns.Add("IsActive", "Is active?");

            LoadEmployeeData();
        }

        private void buttonFilterEmployee_Click(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Select variant of filter!");
                return;
            }

            EnumEmployeeRoles role = (EnumEmployeeRoles)Enum.Parse(typeof(EnumEmployeeRoles), comboBoxRole.SelectedItem.ToString());
            bool isActive = checkBoxIsActive.Checked;

            List<EmployeeModel> employees = EmployeeModel.FilterEmployees(role, isActive);

            dataGridViewEmployees.Rows.Clear();
            foreach (EmployeeModel employee in employees)
            {
                dataGridViewEmployees.Rows.Add(employee.IdEmployee, employee.FirstName, employee.LastName, employee.Role, (employee.IsActive == true) ? "Active" : "Not Active");
            }
        }

        private void buttonClearFilter_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
            comboBoxRole.SelectedItem = null;
            checkBoxIsActive.Checked = false;
        }

        private void buttonDeactivateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
                return;
            }

            int rowIndex = dataGridViewEmployees.CurrentCell.RowIndex;

            if (dataGridViewEmployees.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Not Active")
            {
                MessageBox.Show("Employee is deactive!");
                return;
            }

            int IdEmployee = (int)dataGridViewEmployees.Rows[rowIndex].Cells[0].Value;
            EmployeeModel employee = EmployeeModel.FindEmployee(IdEmployee);

            FormChangeStatusOfEmployee deactivate = new FormChangeStatusOfEmployee(employee, currentUser);
            this.InitializeComponent();
            deactivate.ShowDialog();
        }

        private void dataGridViewEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void buttonReactivate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one employee from list!");
                return;
            }

            int rowIndex = dataGridViewEmployees.CurrentCell.RowIndex;

            if (dataGridViewEmployees.Rows[rowIndex].Cells["IsActive"].Value.ToString() == "Active")
            {
                MessageBox.Show("Employee is active!");
                return;
            }

            int IdEmployee = (int)dataGridViewEmployees.Rows[rowIndex].Cells[0].Value;
            EmployeeModel employee = EmployeeModel.FindEmployee(IdEmployee);

            FormChangeStatusOfEmployee deactivate = new FormChangeStatusOfEmployee(employee, currentUser);
            this.InitializeComponent();
            deactivate.ShowDialog();
        }

        private void buttonReviewEmployee_Click(object sender, EventArgs e)
        {
            //int rowIndex = dataGridViewEmployees.CurrentRow.Index;

            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select one employee from list!");
                return;
            }

            int rowIndex = dataGridViewEmployees.CurrentRow.Index;

            int IdEmployee = (int)dataGridViewEmployees.Rows[rowIndex].Cells[0].Value;
            EmployeeModel employee = EmployeeModel.FindEmployee(IdEmployee);

            FormEmployeeDetailsView employeeDetailsView = new FormEmployeeDetailsView(employee, currentUser);
            Hide();
            employeeDetailsView.ShowDialog();
            Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormEmployeeAdd employeeAdd = new FormEmployeeAdd(currentUser);
            Hide();
            employeeAdd.ShowDialog();
            Close();
        }

        private void buttonSpecializations_Click(object sender, EventArgs e)
        {
            FormSpecializationAdd specializationAdd = new FormSpecializationAdd(currentUser);
            Hide();
            specializationAdd.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEmployees.CurrentRow.Index;

            if (rowIndex < 0)
            {
                MessageBox.Show("Select one employee from list!");
                return;
            }

            int IdEmployee = (int)dataGridViewEmployees.Rows[rowIndex].Cells[0].Value;
            EmployeeModel employee = EmployeeModel.FindEmployee(IdEmployee);

            FormEmployeeEdit employeeEdit = new FormEmployeeEdit(employee, currentUser);
            Hide();
            employeeEdit.ShowDialog();
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            Hide();
            formMenu.ShowDialog();
            Close();
        }
    }
}
