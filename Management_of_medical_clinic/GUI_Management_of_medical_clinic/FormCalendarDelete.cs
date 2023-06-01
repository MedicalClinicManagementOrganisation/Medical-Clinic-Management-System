using Console_Management_of_medical_clinic.Logic;
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
    public partial class FormCalendarDelete : Form
    {
        int calendarId;
        public FormCalendarDelete(int calendarId)
        {
            InitializeComponent();
            this.calendarId = calendarId;
        }

        private void FormCalendarDelete_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                CalendarService.DeleteCalendar(calendarId);
                this.Close();
            }
            catch
            {
                MessageBox.Show(CalendarService.LastErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
