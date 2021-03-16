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
    public partial class EnrollmentForm : Form
    {
        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            SMSForm MainForm = new SMSForm();
            MainForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {                   
            AddForm AddForm = new AddForm();
            DialogResult result = AddForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                enrolledStdTableAdapter.Fill(sMSDatabaseDataSet.EnrolledStd);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataRowView rowView = (DataRowView)enrolledStdBindingSource.Current;
            SMSDatabaseDataSet.EnrolledStdRow row = (SMSDatabaseDataSet.EnrolledStdRow)rowView.Row;

            this.enrolledStdTableAdapter.Delete(row.Name, row.Surname, row.ID, row.Gender, row.MotherName, row.FatherName, row.Phone);

            this.enrolledStdTableAdapter.Fill(sMSDatabaseDataSet.EnrolledStd);        
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'schoolDataSet.Students' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.enrolledStdTableAdapter.Fill(this.sMSDatabaseDataSet.EnrolledStd);
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.enrolledStdTableAdapter.Search(this.sMSDatabaseDataSet.EnrolledStd, iDToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Close();           
            EnrollmentForm EnrollmentForm = new EnrollmentForm();
            EnrollmentForm.Show();
        }
    }
}
 

