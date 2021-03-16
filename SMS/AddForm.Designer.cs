namespace Final_Group_38
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxNo = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelInfoE = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPNo = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.textBoxMN = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelMN = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.labelNecessary = new System.Windows.Forms.Label();
            this.enrolledStdTableAdapterAddForm = new Final_Group_38.SMSDatabaseDataSetTableAdapters.EnrolledStdTableAdapter();
            this.smsDatabaseDataSetAddForm = new Final_Group_38.SMSDatabaseDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smsDatabaseDataSetAddForm)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(164, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxNo);
            this.panel1.Controls.Add(this.radioButtonFemale);
            this.panel1.Controls.Add(this.radioButtonMale);
            this.panel1.Controls.Add(this.labelGender);
            this.panel1.Controls.Add(this.labelInfoE);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.textBoxInfo);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelPNo);
            this.panel1.Controls.Add(this.textBoxFN);
            this.panel1.Controls.Add(this.textBoxMN);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.labelFN);
            this.panel1.Controls.Add(this.labelMN);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 473);
            this.panel1.TabIndex = 1;
            // 
            // maskedTextBoxNo
            // 
            this.maskedTextBoxNo.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.maskedTextBoxNo.Location = new System.Drawing.Point(164, 243);
            this.maskedTextBoxNo.Mask = "(999) 000-0000";
            this.maskedTextBoxNo.Name = "maskedTextBoxNo";
            this.maskedTextBoxNo.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBoxNo.TabIndex = 21;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(269, 119);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 20;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(183, 119);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 19;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(65, 123);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 17);
            this.labelGender.TabIndex = 18;
            this.labelGender.Text = "&Gender";
            // 
            // labelInfoE
            // 
            this.labelInfoE.AutoSize = true;
            this.labelInfoE.Location = new System.Drawing.Point(20, 416);
            this.labelInfoE.Name = "labelInfoE";
            this.labelInfoE.Size = new System.Drawing.Size(101, 34);
            this.labelInfoE.TabIndex = 17;
            this.labelInfoE.Text = "(Special case, \r\n  illness etc.)";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(20, 388);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(101, 17);
            this.labelInfo.TabIndex = 16;
            this.labelInfo.Text = "&Info About Std.";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(164, 388);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(200, 73);
            this.textBoxInfo.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(164, 284);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(200, 73);
            this.textBoxAddress.TabIndex = 14;
            // 
            // labelPNo
            // 
            this.labelPNo.AutoSize = true;
            this.labelPNo.Location = new System.Drawing.Point(0, 248);
            this.labelPNo.Name = "labelPNo";
            this.labelPNo.Size = new System.Drawing.Size(126, 17);
            this.labelPNo.TabIndex = 12;
            this.labelPNo.Text = "&Parent Phone No.*";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(164, 201);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(200, 22);
            this.textBoxFN.TabIndex = 11;
            // 
            // textBoxMN
            // 
            this.textBoxMN.Location = new System.Drawing.Point(164, 157);
            this.textBoxMN.Name = "textBoxMN";
            this.textBoxMN.Size = new System.Drawing.Size(200, 22);
            this.textBoxMN.TabIndex = 10;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(56, 47);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(70, 17);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "&Surname*";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(61, 307);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(65, 17);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "&Address*";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(21, 206);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(105, 17);
            this.labelFN.TabIndex = 7;
            this.labelFN.Text = "&Father\'s Name*";
            // 
            // labelMN
            // 
            this.labelMN.AutoSize = true;
            this.labelMN.Location = new System.Drawing.Point(18, 162);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(108, 17);
            this.labelMN.TabIndex = 6;
            this.labelMN.Text = "&Mother\'s Name*";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(100, 87);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 17);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "&ID*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(76, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "&Name*";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(164, 82);
            this.textBoxID.MaxLength = 11;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 22);
            this.textBoxID.TabIndex = 2;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDBoxCheck);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(164, 42);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 22);
            this.textBoxSurname.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(401, 204);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(138, 63);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "ADD STUDENT";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // labelNecessary
            // 
            this.labelNecessary.AutoSize = true;
            this.labelNecessary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNecessary.ForeColor = System.Drawing.Color.Firebrick;
            this.labelNecessary.Location = new System.Drawing.Point(397, 20);
            this.labelNecessary.Name = "labelNecessary";
            this.labelNecessary.Size = new System.Drawing.Size(115, 20);
            this.labelNecessary.TabIndex = 7;
            this.labelNecessary.Text = "* = Necessary";
            // 
            // enrolledStdTableAdapterAddForm
            // 
            this.enrolledStdTableAdapterAddForm.ClearBeforeFill = true;
            // 
            // smsDatabaseDataSetAddForm
            // 
            this.smsDatabaseDataSetAddForm.DataSetName = "SMSDatabaseDataSet";
            this.smsDatabaseDataSetAddForm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(551, 493);
            this.Controls.Add(this.labelNecessary);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Name = "AddForm";
            this.Text = "Add Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smsDatabaseDataSetAddForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPNo;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.TextBox textBoxMN;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelMN;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelInfoE;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNo;
        private System.Windows.Forms.Label labelNecessary;
        private SMSDatabaseDataSetTableAdapters.EnrolledStdTableAdapter enrolledStdTableAdapterAddForm;
        private SMSDatabaseDataSet smsDatabaseDataSetAddForm;
    }
}