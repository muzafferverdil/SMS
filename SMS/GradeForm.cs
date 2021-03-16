using System;
using System.Windows.Forms;


/** I did not delete this part even though it is not coded because it was included in the project draft 
    in the very beginning and did not want to disregard the draft itself. **/

namespace Final_Group_38
{
    public partial class GradeForm : Form
    {       
        public GradeForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SMSForm MainForm = new SMSForm();
            MainForm.Show();
        }
    }
}
