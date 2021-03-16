using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Group_23
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            this.enrolledStdTableAdapter.FillByID(this.sMSDatabaseDataSet.EnrolledStd, this.ID);
        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.enrolledStdTableAdapter.Fill(this.sMSDatabaseDataSet.EnrolledStd);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.enrolledStdBindingSource.EndEdit();
            this.enrolledStdTableAdapter.Update(this.sMSDatabaseDataSet.EnrolledStd);
        }
    }
}
