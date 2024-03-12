namespace medCentre
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.viewPacientsButton = new System.Windows.Forms.Button();
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.viewEmployeesButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.titleLabel = new System.Windows.Forms.Label();
            this.otherTitleLabel = new System.Windows.Forms.Label();
            this.appointmentGB = new System.Windows.Forms.GroupBox();
            this.appointmentTitleLabel = new System.Windows.Forms.Label();
            this.dataViewGB = new System.Windows.Forms.GroupBox();
            this.viewDataTitleLabel = new System.Windows.Forms.Label();
            this.ieGB = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.ieTitleLabel = new System.Windows.Forms.Label();
            this.dbWorkGB = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dbWorkTitleLabel = new System.Windows.Forms.Label();
            this.otherGB = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.exitGB = new System.Windows.Forms.GroupBox();
            this.exitTitleLabel = new System.Windows.Forms.Label();
            this.exportDataSFD = new System.Windows.Forms.SaveFileDialog();
            this.exportContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportAppointmentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPacientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPersonalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exportServicesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataOFD = new System.Windows.Forms.OpenFileDialog();
            this.importContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.importAppointmentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.importPacientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.importPersonalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.importServiceTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPersonalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addPacientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addServiceTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPersonalTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editPacientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editServiceTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.appointmentGB.SuspendLayout();
            this.dataViewGB.SuspendLayout();
            this.ieGB.SuspendLayout();
            this.dbWorkGB.SuspendLayout();
            this.otherGB.SuspendLayout();
            this.exitGB.SuspendLayout();
            this.exportContext.SuspendLayout();
            this.importContext.SuspendLayout();
            this.addContext.SuspendLayout();
            this.editContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.addAppointmentButton.Location = new System.Drawing.Point(15, 26);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(211, 30);
            this.addAppointmentButton.TabIndex = 4;
            this.addAppointmentButton.Text = "Записать на приём";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAppointmentButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelAppointmentButton.ForeColor = System.Drawing.Color.White;
            this.cancelAppointmentButton.Location = new System.Drawing.Point(15, 62);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(211, 30);
            this.cancelAppointmentButton.TabIndex = 5;
            this.cancelAppointmentButton.Text = "Отменить запись";
            this.cancelAppointmentButton.UseVisualStyleBackColor = false;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.cancelAppointmentButton_Click);
            // 
            // viewPacientsButton
            // 
            this.viewPacientsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewPacientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPacientsButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewPacientsButton.ForeColor = System.Drawing.Color.White;
            this.viewPacientsButton.Location = new System.Drawing.Point(15, 100);
            this.viewPacientsButton.Name = "viewPacientsButton";
            this.viewPacientsButton.Size = new System.Drawing.Size(211, 30);
            this.viewPacientsButton.TabIndex = 6;
            this.viewPacientsButton.Text = "Пациенты";
            this.viewPacientsButton.UseVisualStyleBackColor = false;
            this.viewPacientsButton.Click += new System.EventHandler(this.viewPacientsButton_Click);
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewScheduleButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewScheduleButton.ForeColor = System.Drawing.Color.White;
            this.viewScheduleButton.Location = new System.Drawing.Point(15, 28);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(211, 30);
            this.viewScheduleButton.TabIndex = 7;
            this.viewScheduleButton.Text = "Расписание";
            this.viewScheduleButton.UseVisualStyleBackColor = false;
            this.viewScheduleButton.Click += new System.EventHandler(this.viewScheduleButton_Click);
            // 
            // viewEmployeesButton
            // 
            this.viewEmployeesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmployeesButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewEmployeesButton.ForeColor = System.Drawing.Color.White;
            this.viewEmployeesButton.Location = new System.Drawing.Point(15, 64);
            this.viewEmployeesButton.Name = "viewEmployeesButton";
            this.viewEmployeesButton.Size = new System.Drawing.Size(211, 30);
            this.viewEmployeesButton.TabIndex = 8;
            this.viewEmployeesButton.Text = "Сотрудники";
            this.viewEmployeesButton.UseVisualStyleBackColor = false;
            this.viewEmployeesButton.Click += new System.EventHandler(this.viewEmployeesButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(729, 5);
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
            this.closeButton.Location = new System.Drawing.Point(765, 5);
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
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 40);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            this.mainMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 21);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Медицинский центр \"Лазурит\"";
            // 
            // otherTitleLabel
            // 
            this.otherTitleLabel.AutoSize = true;
            this.otherTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.otherTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherTitleLabel.ForeColor = System.Drawing.Color.White;
            this.otherTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.otherTitleLabel.Name = "otherTitleLabel";
            this.otherTitleLabel.Size = new System.Drawing.Size(155, 21);
            this.otherTitleLabel.TabIndex = 20;
            this.otherTitleLabel.Text = "Другие действия";
            // 
            // appointmentGB
            // 
            this.appointmentGB.Controls.Add(this.appointmentTitleLabel);
            this.appointmentGB.Controls.Add(this.addAppointmentButton);
            this.appointmentGB.Controls.Add(this.cancelAppointmentButton);
            this.appointmentGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentGB.Location = new System.Drawing.Point(545, 71);
            this.appointmentGB.Name = "appointmentGB";
            this.appointmentGB.Size = new System.Drawing.Size(243, 105);
            this.appointmentGB.TabIndex = 22;
            this.appointmentGB.TabStop = false;
            this.appointmentGB.Text = "Запись";
            // 
            // appointmentTitleLabel
            // 
            this.appointmentTitleLabel.AutoSize = true;
            this.appointmentTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.appointmentTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appointmentTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.appointmentTitleLabel.Name = "appointmentTitleLabel";
            this.appointmentTitleLabel.Size = new System.Drawing.Size(74, 21);
            this.appointmentTitleLabel.TabIndex = 25;
            this.appointmentTitleLabel.Text = "Запись";
            // 
            // dataViewGB
            // 
            this.dataViewGB.Controls.Add(this.viewDataTitleLabel);
            this.dataViewGB.Controls.Add(this.viewScheduleButton);
            this.dataViewGB.Controls.Add(this.viewPacientsButton);
            this.dataViewGB.Controls.Add(this.viewEmployeesButton);
            this.dataViewGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataViewGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataViewGB.Location = new System.Drawing.Point(545, 182);
            this.dataViewGB.Name = "dataViewGB";
            this.dataViewGB.Size = new System.Drawing.Size(243, 145);
            this.dataViewGB.TabIndex = 23;
            this.dataViewGB.TabStop = false;
            this.dataViewGB.Text = "Просмотр данных";
            // 
            // viewDataTitleLabel
            // 
            this.viewDataTitleLabel.AutoSize = true;
            this.viewDataTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.viewDataTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewDataTitleLabel.ForeColor = System.Drawing.Color.White;
            this.viewDataTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.viewDataTitleLabel.Name = "viewDataTitleLabel";
            this.viewDataTitleLabel.Size = new System.Drawing.Size(171, 21);
            this.viewDataTitleLabel.TabIndex = 24;
            this.viewDataTitleLabel.Text = "Просмотр данных";
            // 
            // ieGB
            // 
            this.ieGB.Controls.Add(this.exportButton);
            this.ieGB.Controls.Add(this.importButton);
            this.ieGB.Controls.Add(this.ieTitleLabel);
            this.ieGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ieGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ieGB.Location = new System.Drawing.Point(16, 71);
            this.ieGB.Name = "ieGB";
            this.ieGB.Size = new System.Drawing.Size(243, 105);
            this.ieGB.TabIndex = 25;
            this.ieGB.TabStop = false;
            this.ieGB.Text = "Экспорт / Импорт";
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(15, 26);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(211, 34);
            this.exportButton.TabIndex = 30;
            this.exportButton.Text = "Экспорт данных";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(15, 66);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(211, 30);
            this.importButton.TabIndex = 29;
            this.importButton.Text = "Импорт данных";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // ieTitleLabel
            // 
            this.ieTitleLabel.AutoSize = true;
            this.ieTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ieTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ieTitleLabel.ForeColor = System.Drawing.Color.White;
            this.ieTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.ieTitleLabel.Name = "ieTitleLabel";
            this.ieTitleLabel.Size = new System.Drawing.Size(172, 21);
            this.ieTitleLabel.TabIndex = 24;
            this.ieTitleLabel.Text = "Экспорт / Импорт";
            // 
            // dbWorkGB
            // 
            this.dbWorkGB.Controls.Add(this.deleteButton);
            this.dbWorkGB.Controls.Add(this.editButton);
            this.dbWorkGB.Controls.Add(this.addButton);
            this.dbWorkGB.Controls.Add(this.dbWorkTitleLabel);
            this.dbWorkGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbWorkGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbWorkGB.Location = new System.Drawing.Point(16, 182);
            this.dbWorkGB.Name = "dbWorkGB";
            this.dbWorkGB.Size = new System.Drawing.Size(243, 145);
            this.dbWorkGB.TabIndex = 26;
            this.dbWorkGB.TabStop = false;
            this.dbWorkGB.Text = "Работа с данными";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(15, 100);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(211, 30);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(15, 64);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(211, 30);
            this.editButton.TabIndex = 26;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(15, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(211, 30);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dbWorkTitleLabel
            // 
            this.dbWorkTitleLabel.AutoSize = true;
            this.dbWorkTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.dbWorkTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbWorkTitleLabel.ForeColor = System.Drawing.Color.White;
            this.dbWorkTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.dbWorkTitleLabel.Name = "dbWorkTitleLabel";
            this.dbWorkTitleLabel.Size = new System.Drawing.Size(177, 21);
            this.dbWorkTitleLabel.TabIndex = 24;
            this.dbWorkTitleLabel.Text = "Работа с данными";
            // 
            // otherGB
            // 
            this.otherGB.Controls.Add(this.searchButton);
            this.otherGB.Controls.Add(this.otherTitleLabel);
            this.otherGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherGB.Location = new System.Drawing.Point(16, 333);
            this.otherGB.Name = "otherGB";
            this.otherGB.Size = new System.Drawing.Size(243, 72);
            this.otherGB.TabIndex = 23;
            this.otherGB.TabStop = false;
            this.otherGB.Text = "Другие действия";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(15, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(211, 34);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(10, 27);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(211, 30);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // exitGB
            // 
            this.exitGB.Controls.Add(this.exitTitleLabel);
            this.exitGB.Controls.Add(this.exitButton);
            this.exitGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitGB.Location = new System.Drawing.Point(545, 333);
            this.exitGB.Name = "exitGB";
            this.exitGB.Size = new System.Drawing.Size(243, 72);
            this.exitGB.TabIndex = 29;
            this.exitGB.TabStop = false;
            this.exitGB.Text = "Выход из программы";
            // 
            // exitTitleLabel
            // 
            this.exitTitleLabel.AutoSize = true;
            this.exitTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitTitleLabel.ForeColor = System.Drawing.Color.White;
            this.exitTitleLabel.Location = new System.Drawing.Point(6, 0);
            this.exitTitleLabel.Name = "exitTitleLabel";
            this.exitTitleLabel.Size = new System.Drawing.Size(198, 21);
            this.exitTitleLabel.TabIndex = 20;
            this.exitTitleLabel.Text = "Выход из программы";
            // 
            // exportDataSFD
            // 
            this.exportDataSFD.DefaultExt = "txt";
            this.exportDataSFD.Filter = "Text Docs (*.txt)|*.txt";
            this.exportDataSFD.Title = "Выберите файл для экспорта из базы...";
            // 
            // exportContext
            // 
            this.exportContext.AutoSize = false;
            this.exportContext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.exportContext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAppointmentTSMI,
            this.exportPacientTSMI,
            this.exportPersonalTSMI,
            this.exportServicesTSMI});
            this.exportContext.Name = "addContextMenu";
            this.exportContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.exportContext.ShowItemToolTips = false;
            this.exportContext.Size = new System.Drawing.Size(211, 94);
            // 
            // exportAppointmentTSMI
            // 
            this.exportAppointmentTSMI.AutoSize = false;
            this.exportAppointmentTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportAppointmentTSMI.ForeColor = System.Drawing.Color.White;
            this.exportAppointmentTSMI.Name = "exportAppointmentTSMI";
            this.exportAppointmentTSMI.Size = new System.Drawing.Size(211, 22);
            this.exportAppointmentTSMI.Text = "[Запись]";
            this.exportAppointmentTSMI.Click += new System.EventHandler(this.exportTSMI_Click);
            // 
            // exportPacientTSMI
            // 
            this.exportPacientTSMI.AutoSize = false;
            this.exportPacientTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportPacientTSMI.ForeColor = System.Drawing.Color.White;
            this.exportPacientTSMI.Name = "exportPacientTSMI";
            this.exportPacientTSMI.Size = new System.Drawing.Size(211, 22);
            this.exportPacientTSMI.Text = "[Пациент]";
            this.exportPacientTSMI.Click += new System.EventHandler(this.exportTSMI_Click);
            // 
            // exportPersonalTSMI
            // 
            this.exportPersonalTSMI.AutoSize = false;
            this.exportPersonalTSMI.BackColor = System.Drawing.Color.White;
            this.exportPersonalTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportPersonalTSMI.ForeColor = System.Drawing.Color.White;
            this.exportPersonalTSMI.Name = "exportPersonalTSMI";
            this.exportPersonalTSMI.Size = new System.Drawing.Size(211, 22);
            this.exportPersonalTSMI.Text = "[Сотрудники]";
            this.exportPersonalTSMI.Click += new System.EventHandler(this.exportTSMI_Click);
            // 
            // exportServicesTSMI
            // 
            this.exportServicesTSMI.AutoSize = false;
            this.exportServicesTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportServicesTSMI.ForeColor = System.Drawing.Color.White;
            this.exportServicesTSMI.Name = "exportServicesTSMI";
            this.exportServicesTSMI.Size = new System.Drawing.Size(211, 22);
            this.exportServicesTSMI.Text = "[Услуги]";
            this.exportServicesTSMI.Click += new System.EventHandler(this.exportTSMI_Click);
            // 
            // importDataOFD
            // 
            this.importDataOFD.DefaultExt = "txt";
            this.importDataOFD.Filter = "Text Docs (*.txt)|*.txt";
            this.importDataOFD.Title = "Выберите файл для импорта в базу...";
            // 
            // importContext
            // 
            this.importContext.AutoSize = false;
            this.importContext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.importContext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importAppointmentTSMI,
            this.importPacientTSMI,
            this.importPersonalTSMI,
            this.importServiceTSMI});
            this.importContext.Name = "addContextMenu";
            this.importContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.importContext.ShowItemToolTips = false;
            this.importContext.Size = new System.Drawing.Size(211, 94);
            // 
            // importAppointmentTSMI
            // 
            this.importAppointmentTSMI.AutoSize = false;
            this.importAppointmentTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importAppointmentTSMI.ForeColor = System.Drawing.Color.White;
            this.importAppointmentTSMI.Name = "importAppointmentTSMI";
            this.importAppointmentTSMI.Size = new System.Drawing.Size(211, 22);
            this.importAppointmentTSMI.Text = "[Запись]";
            this.importAppointmentTSMI.Click += new System.EventHandler(this.importTSMI_Click);
            // 
            // importPacientTSMI
            // 
            this.importPacientTSMI.AutoSize = false;
            this.importPacientTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importPacientTSMI.ForeColor = System.Drawing.Color.White;
            this.importPacientTSMI.Name = "importPacientTSMI";
            this.importPacientTSMI.Size = new System.Drawing.Size(211, 22);
            this.importPacientTSMI.Text = "[Пациент]";
            this.importPacientTSMI.Click += new System.EventHandler(this.importTSMI_Click);
            // 
            // importPersonalTSMI
            // 
            this.importPersonalTSMI.AutoSize = false;
            this.importPersonalTSMI.BackColor = System.Drawing.Color.White;
            this.importPersonalTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importPersonalTSMI.ForeColor = System.Drawing.Color.White;
            this.importPersonalTSMI.Name = "importPersonalTSMI";
            this.importPersonalTSMI.Size = new System.Drawing.Size(211, 22);
            this.importPersonalTSMI.Text = "[Сотрудники]";
            this.importPersonalTSMI.Click += new System.EventHandler(this.importTSMI_Click);
            // 
            // importServiceTSMI
            // 
            this.importServiceTSMI.AutoSize = false;
            this.importServiceTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importServiceTSMI.ForeColor = System.Drawing.Color.White;
            this.importServiceTSMI.Name = "importServiceTSMI";
            this.importServiceTSMI.Size = new System.Drawing.Size(211, 22);
            this.importServiceTSMI.Text = "[Услуги]";
            this.importServiceTSMI.Click += new System.EventHandler(this.importTSMI_Click);
            // 
            // addContext
            // 
            this.addContext.AutoSize = false;
            this.addContext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addContext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonalTSMI,
            this.addPacientTSMI,
            this.addServiceTSMI});
            this.addContext.Name = "addContextMenu";
            this.addContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.addContext.ShowItemToolTips = false;
            this.addContext.Size = new System.Drawing.Size(211, 72);
            // 
            // addPersonalTSMI
            // 
            this.addPersonalTSMI.AutoSize = false;
            this.addPersonalTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPersonalTSMI.ForeColor = System.Drawing.Color.White;
            this.addPersonalTSMI.Name = "addPersonalTSMI";
            this.addPersonalTSMI.Size = new System.Drawing.Size(211, 22);
            this.addPersonalTSMI.Text = "Сотрудника";
            this.addPersonalTSMI.Click += new System.EventHandler(this.addPersonalTSMI_Click);
            // 
            // addPacientTSMI
            // 
            this.addPacientTSMI.AutoSize = false;
            this.addPacientTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPacientTSMI.ForeColor = System.Drawing.Color.White;
            this.addPacientTSMI.Name = "addPacientTSMI";
            this.addPacientTSMI.Size = new System.Drawing.Size(211, 22);
            this.addPacientTSMI.Text = "Пациента";
            this.addPacientTSMI.Click += new System.EventHandler(this.addPacientTSMI_Click);
            // 
            // addServiceTSMI
            // 
            this.addServiceTSMI.AutoSize = false;
            this.addServiceTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServiceTSMI.ForeColor = System.Drawing.Color.White;
            this.addServiceTSMI.Name = "addServiceTSMI";
            this.addServiceTSMI.Size = new System.Drawing.Size(211, 22);
            this.addServiceTSMI.Text = "Услугу";
            this.addServiceTSMI.Click += new System.EventHandler(this.addServiceTSMI_Click);
            // 
            // editContext
            // 
            this.editContext.AutoSize = false;
            this.editContext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editContext.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPersonalTSMI,
            this.editPacientTSMI,
            this.editServiceTSMI});
            this.editContext.Name = "addContextMenu";
            this.editContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.editContext.ShowItemToolTips = false;
            this.editContext.Size = new System.Drawing.Size(211, 72);
            // 
            // editPersonalTSMI
            // 
            this.editPersonalTSMI.AutoSize = false;
            this.editPersonalTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPersonalTSMI.ForeColor = System.Drawing.Color.White;
            this.editPersonalTSMI.Name = "editPersonalTSMI";
            this.editPersonalTSMI.Size = new System.Drawing.Size(211, 22);
            this.editPersonalTSMI.Text = "Данные сотрудника";
            this.editPersonalTSMI.Click += new System.EventHandler(this.editPersonalTSMI_Click);
            // 
            // editPacientTSMI
            // 
            this.editPacientTSMI.AutoSize = false;
            this.editPacientTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPacientTSMI.ForeColor = System.Drawing.Color.White;
            this.editPacientTSMI.Name = "editPacientTSMI";
            this.editPacientTSMI.Size = new System.Drawing.Size(211, 22);
            this.editPacientTSMI.Text = "Данные пациента";
            this.editPacientTSMI.Click += new System.EventHandler(this.editPacientTSMI_Click);
            // 
            // editServiceTSMI
            // 
            this.editServiceTSMI.AutoSize = false;
            this.editServiceTSMI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editServiceTSMI.ForeColor = System.Drawing.Color.White;
            this.editServiceTSMI.Name = "editServiceTSMI";
            this.editServiceTSMI.Size = new System.Drawing.Size(211, 22);
            this.editServiceTSMI.Text = "Данные об услуге";
            this.editServiceTSMI.Click += new System.EventHandler(this.editServiceTSMI_Click);
            // 
            // logoPB
            // 
            this.logoPB.BackgroundImage = global::medCentre.Properties.Resources.logo;
            this.logoPB.Location = new System.Drawing.Point(275, 104);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(256, 256);
            this.logoPB.TabIndex = 27;
            this.logoPB.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitGB);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.otherGB);
            this.Controls.Add(this.dbWorkGB);
            this.Controls.Add(this.ieGB);
            this.Controls.Add(this.dataViewGB);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.appointmentGB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainForm";
            this.Text = "Медицинский центр \"Агат\"";
            this.appointmentGB.ResumeLayout(false);
            this.appointmentGB.PerformLayout();
            this.dataViewGB.ResumeLayout(false);
            this.dataViewGB.PerformLayout();
            this.ieGB.ResumeLayout(false);
            this.ieGB.PerformLayout();
            this.dbWorkGB.ResumeLayout(false);
            this.dbWorkGB.PerformLayout();
            this.otherGB.ResumeLayout(false);
            this.otherGB.PerformLayout();
            this.exitGB.ResumeLayout(false);
            this.exitGB.PerformLayout();
            this.exportContext.ResumeLayout(false);
            this.importContext.ResumeLayout(false);
            this.addContext.ResumeLayout(false);
            this.editContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.Button viewPacientsButton;
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button viewEmployeesButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label otherTitleLabel;
        private System.Windows.Forms.GroupBox appointmentGB;
        private System.Windows.Forms.GroupBox dataViewGB;
        private System.Windows.Forms.Label viewDataTitleLabel;
        private System.Windows.Forms.GroupBox ieGB;
        private System.Windows.Forms.Label ieTitleLabel;
        private System.Windows.Forms.GroupBox dbWorkGB;
        private System.Windows.Forms.Label dbWorkTitleLabel;
        private System.Windows.Forms.GroupBox otherGB;
        private System.Windows.Forms.Label appointmentTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox exitGB;
        private System.Windows.Forms.Label exitTitleLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.SaveFileDialog exportDataSFD;
        private System.Windows.Forms.ContextMenuStrip exportContext;
        private System.Windows.Forms.ToolStripMenuItem exportAppointmentTSMI;
        private System.Windows.Forms.ToolStripMenuItem exportPersonalTSMI;
        private System.Windows.Forms.ToolStripMenuItem exportPacientTSMI;
        private System.Windows.Forms.ToolStripMenuItem exportServicesTSMI;
        private System.Windows.Forms.OpenFileDialog importDataOFD;
        private System.Windows.Forms.ContextMenuStrip importContext;
        private System.Windows.Forms.ToolStripMenuItem importAppointmentTSMI;
        private System.Windows.Forms.ToolStripMenuItem importPersonalTSMI;
        private System.Windows.Forms.ToolStripMenuItem importPacientTSMI;
        private System.Windows.Forms.ToolStripMenuItem importServiceTSMI;
        private System.Windows.Forms.ContextMenuStrip addContext;
        private System.Windows.Forms.ToolStripMenuItem addPersonalTSMI;
        private System.Windows.Forms.ToolStripMenuItem addPacientTSMI;
        private System.Windows.Forms.ContextMenuStrip editContext;
        private System.Windows.Forms.ToolStripMenuItem editPersonalTSMI;
        private System.Windows.Forms.ToolStripMenuItem editPacientTSMI;
        private System.Windows.Forms.ToolStripMenuItem addServiceTSMI;
        private System.Windows.Forms.ToolStripMenuItem editServiceTSMI;
    }
}

