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
                dataGridViewOffices.Rows.Add(office.IdOffice, office.Number, office.Status ? "Active" : "Not active", office.Info, SpecializationService.GetSpecializationById(office.IdSpecialization).Name);
            }
        }

        private void FormOfficeList_Load(object sender, EventArgs e)
        {
            dataGridViewOffices.Rows.Clear();
            dataGridViewOffices.Columns.Add("IdOffice", "Id of Office");
            dataGridViewOffices.Columns.Add("Number", "Number");
            dataGridViewOffices.Columns.Add("Status", "Status");
            dataGridViewOffices.Columns.Add("Info", "Info");
            dataGridViewOffices.Columns.Add("SpecializationName", "Specialization name");

            LoadOfficeData();
        }

        private void buttonAddOffice_Click(object sender, EventArgs e)
        {
            FormOfficeAdd officeAdd = new FormOfficeAdd(currentUser);
            officeAdd.ShowDialog();
            Close();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.ShowDialog();
            Close();
        }

        private void buttonEditOffice_Click(object sender, EventArgs e)
        {
            
            FormOfficeEdit officeEdit = new FormOfficeEdit(currentUser, OfficeService.GetOfficeById((int)dataGridViewOffices.CurrentRow.Cells[0].Value));
            officeEdit.ShowDialog();
            Close();
        }

        private void buttonRemoveOffice_Click(object sender, EventArgs e)
        {
            if (!OfficeService.CheckIfOfficeIsAppointed((int)dataGridViewOffices.CurrentRow.Cells[0].Value))
            {
                FormDeletingConfirmation delete = new FormDeletingConfirmation(OfficeService.GetOfficeById((int)dataGridViewOffices.CurrentRow.Cells[0].Value));
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
