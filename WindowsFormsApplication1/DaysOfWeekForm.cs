using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DaysOfWeekForm : Form
    {
        public DaysOfWeekForm()
        {
            InitializeComponent();
        }

        private void DaysOfWeekForm_Load(object sender, EventArgs e)
        {
            List<string> days = new List<string>();
            days.Add("Saturday");
            days.Add("Sunday");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");

            comboBox1.DataSource = days;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        

        private void DaysOfWeekForm_LoadList(object sender, EventArgs e)
        {
            List<string> daysList = new List<string>();
            daysList.Add("Saturday");
            daysList.Add("Sunday");
            daysList.Add("Monday");
            daysList.Add("Tuesday");
            daysList.Add("Wednesday");
            daysList.Add("Thursday");
            daysList.Add("Friday");
            listBox1.DataSource = daysList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
