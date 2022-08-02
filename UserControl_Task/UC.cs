using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_Task
{
    public partial class UC : UserControl
    {

        public string Number
        {
            get
            {
                return numberLbl.Text;
            }
            set
            {
                numberLbl.Text = value;
            }
        }
        public string DateTime
        {
            get
            {
                return LastEnteredDateLbl.Text;
            }
            set
            {
                LastEnteredDateLbl.Text = value;
            }
        }

        public string Fullname
        {
            get
            {
                return studentNameLbl.Text;
            }
            set
            {
                studentNameLbl.Text = value;
            }
        }

        public UC()
        {
            InitializeComponent();
            var arr = new string[13] { " ","1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            guna2ComboBox1.DataSource = arr.ToList();
            guna2ComboBox2.DataSource = arr.ToList();

        }

        private void UC_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2TextBox1.ForeColor = Color.Gray;
            MessageBox.Show("Rəy uğurla göndərildi");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox1.ForeColor = Color.Black;
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ImageCheckBox1.Checked)
            {
                guna2ImageCheckBox1.BackgroundImage = Properties.Resources.crystal;
            }
        }
    }
}
