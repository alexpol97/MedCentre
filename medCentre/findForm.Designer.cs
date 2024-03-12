namespace medCentre
{
    partial class findForm
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableCB = new System.Windows.Forms.ComboBox();
            this.fromTableLabel = new System.Windows.Forms.Label();
            this.compareTB = new System.Windows.Forms.TextBox();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.fieldCB = new System.Windows.Forms.ComboBox();
            this.selectAllWhereLabel = new System.Windows.Forms.Label();
            this.basesqlDataSet1 = new medCentre.basesqlDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.basesqlDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(513, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(30, 30);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(549, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.AutoSize = false;
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(584, 40);
            this.mainMenuStrip.TabIndex = 5;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMenuStrip_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(125, 19);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Поиск данных";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(250, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 39);
            this.cancelButton.TabIndex = 47;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(414, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(158, 39);
            this.okButton.TabIndex = 46;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(20, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 23);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "[фильтр поиска]";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tableCB
            // 
            this.tableCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableCB.ForeColor = System.Drawing.Color.White;
            this.tableCB.FormattingEnabled = true;
            this.tableCB.Items.AddRange(new object[] {
            "Запись",
            "Пациент",
            "Сотрудники",
            "Услуги"});
            this.tableCB.Location = new System.Drawing.Point(15, 86);
            this.tableCB.Name = "tableCB";
            this.tableCB.Size = new System.Drawing.Size(190, 27);
            this.tableCB.TabIndex = 44;
            this.tableCB.SelectedIndexChanged += new System.EventHandler(this.tableCB_SelectedIndexChanged);
            // 
            // fromTableLabel
            // 
            this.fromTableLabel.AutoSize = true;
            this.fromTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.fromTableLabel.ForeColor = System.Drawing.Color.White;
            this.fromTableLabel.Location = new System.Drawing.Point(16, 61);
            this.fromTableLabel.Name = "fromTableLabel";
            this.fromTableLabel.Size = new System.Drawing.Size(102, 19);
            this.fromTableLabel.TabIndex = 43;
            this.fromTableLabel.Text = "Из таблицы";
            // 
            // compareTB
            // 
            this.compareTB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.compareTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compareTB.Enabled = false;
            this.compareTB.ForeColor = System.Drawing.Color.White;
            this.compareTB.Location = new System.Drawing.Point(406, 177);
            this.compareTB.Multiline = true;
            this.compareTB.Name = "compareTB";
            this.compareTB.Size = new System.Drawing.Size(166, 30);
            this.compareTB.TabIndex = 42;
            // 
            // filterCB
            // 
            this.filterCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.filterCB.Enabled = false;
            this.filterCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterCB.ForeColor = System.Drawing.Color.White;
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "равен",
            "не равен",
            "больше",
            "меньше",
            "содержит",
            "не содержит"});
            this.filterCB.Location = new System.Drawing.Point(211, 176);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(189, 27);
            this.filterCB.TabIndex = 41;
            // 
            // fieldCB
            // 
            this.fieldCB.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.fieldCB.Enabled = false;
            this.fieldCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fieldCB.ForeColor = System.Drawing.Color.White;
            this.fieldCB.FormattingEnabled = true;
            this.fieldCB.Location = new System.Drawing.Point(15, 176);
            this.fieldCB.Name = "fieldCB";
            this.fieldCB.Size = new System.Drawing.Size(190, 27);
            this.fieldCB.TabIndex = 40;
            // 
            // selectAllWhereLabel
            // 
            this.selectAllWhereLabel.AutoSize = true;
            this.selectAllWhereLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectAllWhereLabel.ForeColor = System.Drawing.Color.White;
            this.selectAllWhereLabel.Location = new System.Drawing.Point(16, 151);
            this.selectAllWhereLabel.Name = "selectAllWhereLabel";
            this.selectAllWhereLabel.Size = new System.Drawing.Size(257, 19);
            this.selectAllWhereLabel.TabIndex = 39;
            this.selectAllWhereLabel.Text = "Вывести только те записи, где:";
            // 
            // basesqlDataSet1
            // 
            this.basesqlDataSet1.DataSetName = "basesqlDataSet";
            this.basesqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(584, 270);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tableCB);
            this.Controls.Add(this.fromTableLabel);
            this.Controls.Add(this.compareTB);
            this.Controls.Add(this.filterCB);
            this.Controls.Add(this.fieldCB);
            this.Controls.Add(this.selectAllWhereLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "findForm";
            this.Text = "Найти";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.basesqlDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox tableCB;
        private System.Windows.Forms.Label fromTableLabel;
        private System.Windows.Forms.TextBox compareTB;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.ComboBox fieldCB;
        private System.Windows.Forms.Label selectAllWhereLabel;
        private basesqlDataSet basesqlDataSet1;
    }
}