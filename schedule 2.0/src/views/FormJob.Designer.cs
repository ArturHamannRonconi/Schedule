
namespace Schedule.views
{
    partial class FormJob
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dateTimePickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelBeginDateTime = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.labelEndDateTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxUnity = new System.Windows.Forms.ComboBox();
            this.labelUnity = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewJob = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJob)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(14, 51);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(551, 27);
            this.textBoxTitle.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(14, 123);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(551, 151);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDescription.Location = new System.Drawing.Point(14, 85);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 30);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(622, 265);
            this.dateTimePickerBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(323, 27);
            this.dateTimePickerBeginDate.TabIndex = 4;
            // 
            // labelBeginDateTime
            // 
            this.labelBeginDateTime.AutoSize = true;
            this.labelBeginDateTime.BackColor = System.Drawing.SystemColors.Menu;
            this.labelBeginDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelBeginDateTime.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelBeginDateTime.Location = new System.Drawing.Point(622, 236);
            this.labelBeginDateTime.Name = "labelBeginDateTime";
            this.labelBeginDateTime.Size = new System.Drawing.Size(104, 25);
            this.labelBeginDateTime.TabIndex = 5;
            this.labelBeginDateTime.Text = "Begin Date";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(622, 196);
            this.maskedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxEndDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(323, 27);
            this.maskedTextBoxEndDate.TabIndex = 6;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelEndDateTime
            // 
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEndDateTime.Location = new System.Drawing.Point(622, 167);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(88, 25);
            this.labelEndDateTime.TabIndex = 7;
            this.labelEndDateTime.Text = "End Date";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(732, 366);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(622, 406);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(323, 29);
            this.buttonList.TabIndex = 11;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(14, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Title";
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(622, 366);
            this.buttonAlter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(104, 32);
            this.buttonAlter.TabIndex = 16;
            this.buttonAlter.Text = "Alter";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(841, 366);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 32);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxUnity
            // 
            this.comboBoxUnity.AutoCompleteCustomSource.AddRange(new string[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxUnity.FormattingEnabled = true;
            this.comboBoxUnity.Items.AddRange(new object[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxUnity.Location = new System.Drawing.Point(622, 52);
            this.comboBoxUnity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnity.Name = "comboBoxUnity";
            this.comboBoxUnity.Size = new System.Drawing.Size(138, 28);
            this.comboBoxUnity.TabIndex = 19;
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnity.Location = new System.Drawing.Point(622, 12);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(63, 30);
            this.labelUnity.TabIndex = 20;
            this.labelUnity.Text = "Unity";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(795, 52);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTime.TabIndex = 21;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(795, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 30);
            this.labelTime.TabIndex = 22;
            this.labelTime.Text = "Time";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(622, 123);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(323, 27);
            this.textBoxType.TabIndex = 23;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(622, 85);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 30);
            this.labelType.TabIndex = 24;
            this.labelType.Text = "Type";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(742, 93);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(85, 24);
            this.checkBoxRepeat.TabIndex = 25;
            this.checkBoxRepeat.Text = "Repeat?";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(622, 331);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(323, 28);
            this.comboBoxPriority.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(622, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Priority";
            // 
            // dataGridViewJob
            // 
            this.dataGridViewJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJob.Location = new System.Drawing.Point(14, 281);
            this.dataGridViewJob.Name = "dataGridViewJob";
            this.dataGridViewJob.RowHeadersWidth = 51;
            this.dataGridViewJob.RowTemplate.Height = 29;
            this.dataGridViewJob.Size = new System.Drawing.Size(551, 154);
            this.dataGridViewJob.TabIndex = 28;
            // 
            // FormJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(955, 448);
            this.Controls.Add(this.dataGridViewJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.labelUnity);
            this.Controls.Add(this.comboBoxUnity);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAlter);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEndDateTime);
            this.Controls.Add(this.maskedTextBoxEndDate);
            this.Controls.Add(this.labelBeginDateTime);
            this.Controls.Add(this.dateTimePickerBeginDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormJob";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDate;
        private System.Windows.Forms.Label labelBeginDateTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.Label labelEndDateTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxUnity;
        private System.Windows.Forms.Label labelUnity;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewJob;
    }
}

