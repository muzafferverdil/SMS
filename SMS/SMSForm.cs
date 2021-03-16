using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Group_38
{
    public partial class SMSForm : Form
    {
        int timecheck = 0;
        
        public SMSForm()
        {
            InitializeComponent();
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GradeForm GradeForm = new GradeForm();
            GradeForm.Show();
        }

        private void EnrollmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentForm EnrollmentForm = new EnrollmentForm();
            EnrollmentForm.Show();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
                   
        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            if(timecheck <= 1)
            {
                labelWelcome.Location = new Point(164, 26);
                labelWelcome.Text = "Dear Teacher,\nWelcome to The Student Manager!";
                timecheck++;
            }
            else
            {
                labelWelcome.Location = new Point(200, 28);
                labelWelcome.Text = "\nWhat do you want to do?";
                timecheck = 0;
            }
            
        }

        private void SMSForm_Load(object sender, EventArgs e)
        {

        }
    }
}
