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
    public partial class FormOfficeList : Form
    {
        EmployeeModel currentUser;

        public FormOfficeList()
        {
            InitializeComponent();
        }

        public FormOfficeList(EmployeeModel currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
        }

        public void LoadOfficeData()
        {

            dataGridViewOffices.DataSource = null;

            dataGridViewOffices.Rows.Clear();

            foreach (OfficeModel office in OfficeService.GetOfficesData())
            {
                dataGridViewOffices.Rows.Add(office.Number, office.Status.ToString(), office.Info, SpecializationService.GetSpecializationById(office.IdSpecialization).Name);
            }
        }

        private void FormOfficeList_Load(object sender, EventArgs e)
        {
            dataGridViewOffices.Rows.Clear();
            dataGridViewOffices.Columns.Add("Number", "Number");
            dataGridViewOffices.Columns.Add("Status", "Status");
            dataGridViewOffices.Columns.Add("Info", "Info");
            dataGridViewOffices.Columns.Add("SpecializationName", "Specialization name");

            LoadOfficeData();
        }

        private void buttonAddOffice_Click(object sender, EventArgs e)
        {
            FormOfficeAdd officeAdd = new FormOfficeAdd(currentUser);
            Hide();
            officeAdd.ShowDialog();
            Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            Hide();
            menu.ShowDialog();
            Close();
        }

        private void buttonEditOffice_Click(object sender, EventArgs e)
        {
            if (dataGridViewOffices.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can edit only one office at a time. Please select one office from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormOfficeEdit officeEdit = new FormOfficeEdit(currentUser, OfficeService.GetOfficeByInfo("Room: " + dataGridViewOffices.CurrentRow.Cells[0].Value + ", " + dataGridViewOffices.CurrentRow.Cells[2].Value));  //"Room: " + office.Number.ToString() + ", " + office.Info
            Hide();
            officeEdit.ShowDialog();
            Close();
        }

        private void buttonRemoveOffice_Click(object sender, EventArgs e)
        {
            if (dataGridViewOffices.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can remove only one office at a time. Please select one office from the list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OfficeModel officeToRemove = OfficeService.GetOfficeByInfo("Room: " + dataGridViewOffices.CurrentRow.Cells[0].Value + ", " + dataGridViewOffices.CurrentRow.Cells[2].Value);

            if (!OfficeService.CheckIfOfficeIsAppointed(officeToRemove.IdOffice))
            {
                FormDeletingConfirmation delete = new FormDeletingConfirmation(officeToRemove);
                delete.ShowDialog();
                LoadOfficeData();
            }
            else
            {
                MessageBox.Show("This office has been appointed and therefore cannot be deleted. Please refrain from attempting to delete this office as it is integral to our operations. Thank you for your cooperation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
