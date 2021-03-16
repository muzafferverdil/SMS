namespace Final_Group_38
{
    partial class SMSForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSForm));
            this.GradesButton = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.EnrollmentsButton = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelTimer = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timerWelcome = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GradesButton
            // 
            this.GradesButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.GradesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.GradesButton.Location = new System.Drawing.Point(314, 270);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.Size = new System.Drawing.Size(172, 65);
            this.GradesButton.TabIndex = 2;
            this.GradesButton.Text = "&Grades";
            this.GradesButton.UseVisualStyleBackColor = false;
            this.GradesButton.Click += new System.EventHandler(this.GradesButton_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AllowDrop = true;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Britannic Bold", 12.8F);
            this.labelWelcome.Location = new System.Drawing.Point(218, 32);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(344, 50);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Dear Teacher,\r\nWelcome to The Student Manager!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnrollmentsButton
            // 
            this.EnrollmentsButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.EnrollmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.EnrollmentsButton.Location = new System.Drawing.Point(314, 140);
            this.EnrollmentsButton.Name = "EnrollmentsButton";
            this.EnrollmentsButton.Size = new System.Drawing.Size(172, 65);
            this.EnrollmentsButton.TabIndex = 1;
            this.EnrollmentsButton.Text = "&Enrollments";
            this.EnrollmentsButton.UseVisualStyleBackColor = false;
            this.EnrollmentsButton.Click += new System.EventHandler(this.EnrollmentsButton_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Location = new System.Drawing.Point(569, 411);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(201, 17);
            this.LabelTimer.TabIndex = 3;
            this.LabelTimer.Text = "Current Time In Your Location:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.TimeLabel.Location = new System.Drawing.Point(650, 427);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(39, 17);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Time";
            // 
            // timerWelcome
            // 
            this.timerWelcome.Enabled = true;
            this.timerWelcome.Interval = 5000;
            this.timerWelcome.Tick += new System.EventHandler(this.timerWelcome_Tick);
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.EnrollmentsButton);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.GradesButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMSForm";
            this.Text = "The Student Manager";
            this.Load += new System.EventHandler(this.SMSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GradesButton;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button EnrollmentsButton;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timerWelcome;
    }
}

