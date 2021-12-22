using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            string firstName = FnameTxb.Text;
            string lastName = LnameTxb.Text;
            int yearBirth;

            if (!int.TryParse(DobTxb.Text, out yearBirth))
            {
                MessageBox.Show("You need to put integer value in year of birth");

            }
            else {
                if (yearBirth < 0)
                {
                    MessageBox.Show("You need to put positive value in year of birth");
                }
                else {
                    int age = 2021 - yearBirth;
                    ResultTxb.Text = "Hello, " + firstName + " " + lastName + ". You are " + age.ToString() + " years old!";
                }
            }

            

        }
    }
}
