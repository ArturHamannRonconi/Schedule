
namespace Schedule.views

{
    partial class FormShowAll
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendarBeginDate = new System.Windows.Forms.MonthCalendar();
            this.comboBoxCommitments = new System.Windows.Forms.ComboBox();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.dataGridViewCommitments = new System.Windows.Forms.DataGridView();
            this.dataGridViewNotifications = new System.Windows.Forms.DataGridView();
            this.buttonList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommitments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarBeginDate
            // 
            this.monthCalendarBeginDate.Location = new System.Drawing.Point(513, 18);
            this.monthCalendarBeginDate.Name = "monthCalendarBeginDate";
            this.monthCalendarBeginDate.TabIndex = 0;
            this.monthCalendarBeginDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarBeginDate_DateChanged);
            // 
            // comboBoxCommitments
            // 
            this.comboBoxCommitments.FormattingEnabled = true;
            this.comboBoxCommitments.Location = new System.Drawing.Point(513, 237);
            this.comboBoxCommitments.Name = "comboBoxCommitments";
            this.comboBoxCommitments.Size = new System.Drawing.Size(269, 28);
            this.comboBoxCommitments.TabIndex = 1;
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(513, 284);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(269, 29);
            this.buttonOptions.TabIndex = 2;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // dataGridViewCommitments
            // 
            this.dataGridViewCommitments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommitments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCommitments.Name = "dataGridViewCommitments";
            this.dataGridViewCommitments.RowHeadersWidth = 51;
            this.dataGridViewCommitments.RowTemplate.Height = 29;
            this.dataGridViewCommitments.Size = new System.Drawing.Size(479, 301);
            this.dataGridViewCommitments.TabIndex = 3;
            // 
            // dataGridViewNotifications
            // 
            this.dataGridViewNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifications.Location = new System.Drawing.Point(12, 319);
            this.dataGridViewNotifications.Name = "dataGridViewNotifications";
            this.dataGridViewNotifications.RowHeadersWidth = 51;
            this.dataGridViewNotifications.RowTemplate.Height = 29;
            this.dataGridViewNotifications.Size = new System.Drawing.Size(479, 301);
            this.dataGridViewNotifications.TabIndex = 4;
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(513, 328);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(269, 29);
            this.buttonList.TabIndex = 5;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // FormShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 628);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.dataGridViewNotifications);
            this.Controls.Add(this.dataGridViewCommitments);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.comboBoxCommitments);
            this.Controls.Add(this.monthCalendarBeginDate);
            this.Name = "FormShowAll";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormShowAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommitments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarBeginDate;
        private System.Windows.Forms.ComboBox comboBoxCommitments;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.DataGridView dataGridViewCommitments;
        private System.Windows.Forms.DataGridView dataGridViewNotifications;
        private System.Windows.Forms.Button buttonList;
    }
}

