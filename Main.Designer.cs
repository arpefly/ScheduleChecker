namespace ScheduleChecker
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewScedule = new System.Windows.Forms.DataGridView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.проверитьРасписанинеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnDate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnStartTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnEndTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnRoomNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSubjectName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScedule)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewScedule
            // 
            this.dataGridViewScedule.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewScedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnStartTime,
            this.ColumnEndTime,
            this.ColumnRoomNumber,
            this.ColumnSubjectName});
            this.dataGridViewScedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewScedule.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewScedule.Name = "dataGridViewScedule";
            this.dataGridViewScedule.Size = new System.Drawing.Size(800, 426);
            this.dataGridViewScedule.TabIndex = 0;
            this.dataGridViewScedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewScedule_CellContentClick);
            this.dataGridViewScedule.Click += new System.EventHandler(this.DataGridViewScedule_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar.Location = new System.Drawing.Point(185, 88);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateSelected);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "HH:mm:ss";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(356, 212);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(88, 26);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверитьРасписанинеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // проверитьРасписанинеToolStripMenuItem
            // 
            this.проверитьРасписанинеToolStripMenuItem.Name = "проверитьРасписанинеToolStripMenuItem";
            this.проверитьРасписанинеToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.проверитьРасписанинеToolStripMenuItem.Text = "Проверить расписанине";
            this.проверитьРасписанинеToolStripMenuItem.Click += new System.EventHandler(this.ПроверитьРасписанинеToolStripMenuItem_Click);
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnStartTime
            // 
            this.ColumnStartTime.HeaderText = "Время начала";
            this.ColumnStartTime.Name = "ColumnStartTime";
            this.ColumnStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnEndTime
            // 
            this.ColumnEndTime.HeaderText = "Время окончания";
            this.ColumnEndTime.Name = "ColumnEndTime";
            this.ColumnEndTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnRoomNumber
            // 
            this.ColumnRoomNumber.HeaderText = "Номер аудитории";
            this.ColumnRoomNumber.Items.AddRange(new object[] {
            "500",
            "501",
            "502",
            "503",
            "504",
            "505"});
            this.ColumnRoomNumber.Name = "ColumnRoomNumber";
            this.ColumnRoomNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnSubjectName
            // 
            this.ColumnSubjectName.HeaderText = "Название предмета";
            this.ColumnSubjectName.Items.AddRange(new object[] {
            "Пара математики",
            "Пара истории",
            "Экзамен"});
            this.ColumnSubjectName.Name = "ColumnSubjectName";
            this.ColumnSubjectName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewScedule);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScedule)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewScedule;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem проверитьРасписанинеToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnStartTime;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEndTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnRoomNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSubjectName;
    }
}

