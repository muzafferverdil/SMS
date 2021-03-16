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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void IDBoxCheck(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                string digiterror = "Please enter an ID with 11 numeric characters.";
                MessageBox.Show(digiterror);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Gender;
            if(radioButtonMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            
            if ((textBoxName.Text != "") && (textBoxSurname.Text != "") && (textBoxID.Text.Length == 11)
                 && (textBoxMN.Text != "") && (textBoxFN.Text != "") && (maskedTextBoxNo.Text != "") && (textBoxAddress.Text != ""))
            {
                enrolledStdTableAdapterAddForm.Insert(
                    textBoxName.Text, textBoxSurname.Text, textBoxID.Text, Gender, textBoxMN.Text, textBoxFN.Text, maskedTextBoxNo.Text, textBoxAddress.Text, textBoxInfo.Text);

                string added = "You have added the student successfully.";
                MessageBox.Show(added);
                this.Close();
            }
            else
            {
                string missinginfo = "Please fill the necessary informations correctly.";
                MessageBox.Show(missinginfo);
            }

        }    
    }
}
