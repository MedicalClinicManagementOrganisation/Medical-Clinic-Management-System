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
    public partial class UserControlDay : UserControl
    {
        public DateTime selectedDate;
        string TriggeredTheControl;

        public delegate void ControlClickedEventHandler(object sender, DateTime selectedDate);
        public event ControlClickedEventHandler ControlClicked;


        public UserControlDay(DateTime selecteddate, string? whichFormTriggeredTheControl)
        {
            selectedDate = selecteddate;
            TriggeredTheControl = whichFormTriggeredTheControl; // zmienna jest po to by odróżnić, która formatka wywołała kontrlkę, tymczasowo niewymagalna
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            labelNumberOfDay.Text = selectedDate.Day.ToString();
        }

        private void UserControlDay_MouseClick(object sender, MouseEventArgs e)
        {
            ControlClicked?.Invoke(this, selectedDate);
            this.BackColor = Color.SteelBlue;
        }

        private void UserControlDay_Leave(object sender, EventArgs e)
        {
            DateTime day = DateTime.Today;
            if (selectedDate == day)
            {
                this.BackColor = Color.LightBlue;
                return;
            }
            this.BackColor = Color.White;

        }
    }
}
