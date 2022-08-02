using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
       // UC uC = new UC();
        public Form1()
        {
            InitializeComponent();
            //uC.Location = new Point(0, 250);
            //guna2CustomGradientPanel1.Controls.Add(uC);

            var students = new List<Student>()
            {

                new Student
            {
                Fullname = "Ali Ahmadov",
                dateTime = DateTime.Now
            },

                new Student
            {
                Fullname = "Rafael Muradov",
                dateTime = DateTime.Now.AddMinutes(15)
            },
                      new Student
            {
                Fullname = "Jeyhun Mirzayev",
                dateTime = DateTime.Now.AddMinutes(4)
            },
                            new Student
            {
                Fullname = "Leyla Adigozalova",
                dateTime = DateTime.Now.AddMinutes(5)
            },
                              new Student
            {
                Fullname = "Elgün Memmedov",
                dateTime = DateTime.Now.AddMinutes(6)
            },
                new Student
            {
                Fullname = "Uğur Memmedzade",
                dateTime = DateTime.Now.AddMinutes(9)
            }


        };

            int y = 250;
            int number = 0;
            foreach (var s in students)
            {
                UC studentUc = new UC();
                studentUc.Number = (++number).ToString();
                studentUc.Location=new Point(studentUc.Location.X, y);
                studentUc.Fullname = s.Fullname;
                studentUc.DateTime = s.dateTime.ToLongDateString();

                y += 160;
                guna2CustomGradientPanel1.Controls.Add(studentUc);
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var button = sender as RadioButton;
            if (button.Checked)
            {
                foreach (var item in guna2CustomGradientPanel1.Controls)
                {
                    if(item is UC uc)
                    {
                        foreach (var groupBox in uc.Controls)
                        {
                            if(groupBox is GroupBox gb)
                            {
                                foreach (var radioButton in gb.Controls)
                                {
                                    if(radioButton is Guna2CustomRadioButton rB)
                                    {
                                        rB.Checked = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.ForeColor = Color.Gray;
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
            guna2TextBox1.ForeColor= Color.Black;
        }
    }
}
