namespace medCentre
{
    partial class addAppointment
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeCB = new System.Windows.Forms.ComboBox();
            this.pacientCB = new System.Windows.Forms.ComboBox();
            this.servicesCB = new System.Windows.Forms.ComboBox();
            this.doctorCB = new System.Windows.Forms.ComboBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.pacientLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(379, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(415, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.AutoSize = false;
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(450, 40);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Записать на приём";
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addAppointmentButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.addAppointmentButton.Location = new System.Drawing.Point(234, 408);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(211, 30);
            this.addAppointmentButton.TabIndex = 28;
            this.addAppointmentButton.Text = "OK";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(10, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(211, 30);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.dateTimePicker);
            this.mainPanel.Controls.Add(this.timeCB);
            this.mainPanel.Controls.Add(this.pacientCB);
            this.mainPanel.Controls.Add(this.servicesCB);
            this.mainPanel.Controls.Add(this.doctorCB);
            this.mainPanel.Controls.Add(this.serviceLabel);
            this.mainPanel.Controls.Add(this.timeLabel);
            this.mainPanel.Controls.Add(this.dateLabel);
            this.mainPanel.Controls.Add(this.doctorLabel);
            this.mainPanel.Controls.Add(this.pacientLabel);
            this.mainPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.Location = new System.Drawing.Point(10, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(435, 359);
            this.mainPanel.TabIndex = 29;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.Location = new System.Drawing.Point(3, 137);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(425, 27);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timeCB
            // 
            this.timeCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.timeCB.Enabled = false;
            this.timeCB.ForeColor = System.Drawing.Color.White;
            this.timeCB.FormattingEnabled = true;
            this.timeCB.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.timeCB.Location = new System.Drawing.Point(0, 194);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(432, 29);
            this.timeCB.TabIndex = 13;
            // 
            // pacientCB
            // 
            this.pacientCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pacientCB.ForeColor = System.Drawing.Color.White;
            this.pacientCB.FormattingEnabled = true;
            this.pacientCB.Location = new System.Drawing.Point(0, 25);
            this.pacientCB.Name = "pacientCB";
            this.pacientCB.Size = new System.Drawing.Size(432, 29);
            this.pacientCB.TabIndex = 12;
            // 
            // servicesCB
            // 
            this.servicesCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.servicesCB.ForeColor = System.Drawing.Color.White;
            this.servicesCB.FormattingEnabled = true;
            this.servicesCB.Location = new System.Drawing.Point(0, 250);
            this.servicesCB.Name = "servicesCB";
            this.servicesCB.Size = new System.Drawing.Size(432, 29);
            this.servicesCB.TabIndex = 11;
            // 
            // doctorCB
            // 
            this.doctorCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.doctorCB.ForeColor = System.Drawing.Color.White;
            this.doctorCB.FormattingEnabled = true;
            this.doctorCB.Location = new System.Drawing.Point(0, 81);
            this.doctorCB.Name = "doctorCB";
            this.doctorCB.Size = new System.Drawing.Size(432, 29);
            this.doctorCB.TabIndex = 10;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.ForeColor = System.Drawing.Color.White;
            this.serviceLabel.Location = new System.Drawing.Point(3, 226);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(70, 21);
            this.serviceLabel.TabIndex = 9;
            this.serviceLabel.Text = "Услуга";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(3, 169);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(66, 21);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "Время";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(3, 113);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(54, 21);
            this.dateLabel.TabIndex = 5;
            this.dateLabel.Text = "Дата";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.ForeColor = System.Drawing.Color.White;
            this.doctorLabel.Location = new System.Drawing.Point(3, 57);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(52, 21);
            this.doctorLabel.TabIndex = 3;
            this.doctorLabel.Text = "Врач";
            // 
            // pacientLabel
            // 
            this.pacientLabel.AutoSize = true;
            this.pacientLabel.ForeColor = System.Drawing.Color.White;
            this.pacientLabel.Location = new System.Drawing.Point(3, 1);
            this.pacientLabel.Name = "pacientLabel";
            this.pacientLabel.Size = new System.Drawing.Size(85, 21);
            this.pacientLabel.TabIndex = 0;
            this.pacientLabel.Text = "Пациент";
            // 
            // addAppointment
            // 
            this.AcceptButton = this.addAppointmentButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "addAppointment";
            this.Text = "Записать на приём";
            this.TopMost = true;
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label pacientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.ComboBox pacientCB;
        private System.Windows.Forms.ComboBox servicesCB;
        private System.Windows.Forms.ComboBox doctorCB;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox timeCB;
    }
}

