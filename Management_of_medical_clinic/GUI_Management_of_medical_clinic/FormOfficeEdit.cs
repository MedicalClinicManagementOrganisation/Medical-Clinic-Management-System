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
    public partial class FormOfficeEdit : Form
    {
        EmployeeModel currentUser;
        OfficeModel office;

        public FormOfficeEdit()
        {
            InitializeComponent();
        }

        public FormOfficeEdit(EmployeeModel currentUser, OfficeModel office)
        {
            this.office = office;
            this.currentUser = currentUser;

            InitializeComponent();
        }

        private void checkIfRequiredFilled()
        {
            if (textBoxInfo.Text.Trim().Length > 0 && textBoxNumber.Text.Trim().Length > 0 && comboBoxActive.SelectedItem != null && listBoxSpecializations.SelectedItem != null && int.TryParse(textBoxNumber.Text, out _))
            {
                buttonEditOffice.Enabled = true;
            }
            else
            {
                buttonEditOffice.Enabled = false;
            }
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void listBoxSpecializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkIfRequiredFilled();
        }

        private void buttonEditOffice_Click(object sender, EventArgs e)
        {

            if (OfficeService.CheckIfNumberExists(int.Parse(textBoxNumber.Text)) && office.Number != int.Parse(textBoxNumber.Text)) { MessageBox.Show("The number of room entered is already taken. Please choose a different number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            OfficeService.EditOffice(office.IdOffice, int.Parse(textBoxNumber.Text), comboBoxActive.SelectedItem == "Active" ? true : false, textBoxInfo.Text, int.Parse(Regex.Match(listBoxSpecializations.SelectedItem.ToString(), @"^\d+").Value));

            MessageBox.Show("Success, data is saved.");

            FormOfficeList officeList = new FormOfficeList(currentUser);
            officeList.ShowDialog();
            Close();

        }

        private void FormOfficeEdit_Load(object sender, EventArgs e)
        {
            textBoxInfo.Text = office.Info;
            textBoxNumber.Text = office.Number.ToString();
            comboBoxActive.SelectedItem = office.Status ? "Active" : "Non active";

            foreach (SpecializationModel specialization in SpecializationService.GetSpecializationsData())
            {
                listBoxSpecializations.Items.Add(specialization.IdSpecialization + " " + specialization.Name);
                if (specialization.IdSpecialization == office.IdSpecialization) listBoxSpecializations.SelectedIndex = listBoxSpecializations.Items.Count - 1;
            }
            checkIfRequiredFilled();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            if (office.IdSpecialization != int.Parse(Regex.Match(listBoxSpecializations.SelectedItem.ToString(), @"^\d+").Value) || !comboBoxActive.SelectedItem.Equals(office.Status ? "Active" : "Non active") || !textBoxInfo.Text.Equals(office.Info) || office.Number != int.Parse(textBoxNumber.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel the operation? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            FormOfficeList officeList = new FormOfficeList(currentUser);
            officeList.ShowDialog();
            Close();
        }
    }
}
