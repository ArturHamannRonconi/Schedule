
namespace Schedule.views
{
    partial class FormReminder
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
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.labelUnity = new System.Windows.Forms.Label();
            this.comboBoxUnity = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAlter = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelEndDateTime = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.labelBeginDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelUnityReminder = new System.Windows.Forms.Label();
            this.comboBoxUnityReminder = new System.Windows.Forms.ComboBox();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.labelEndWhen = new System.Windows.Forms.Label();
            this.comboBoxEnd = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(11, 277);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowHeadersWidth = 51;
            this.dataGridViewEvent.RowTemplate.Height = 29;
            this.dataGridViewEvent.Size = new System.Drawing.Size(551, 245);
            this.dataGridViewEvent.TabIndex = 78;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(739, 89);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(85, 24);
            this.checkBoxRepeat.TabIndex = 73;
            this.checkBoxRepeat.Text = "Repeat?";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(619, 81);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 30);
            this.labelType.TabIndex = 72;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(619, 119);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(323, 27);
            this.textBoxType.TabIndex = 71;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(792, 8);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 30);
            this.labelTime.TabIndex = 70;
            this.labelTime.Text = "Time";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(792, 48);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTime.TabIndex = 69;
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnity.Location = new System.Drawing.Point(619, 8);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(63, 30);
            this.labelUnity.TabIndex = 68;
            this.labelUnity.Text = "Unity";
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
            this.comboBoxUnity.Location = new System.Drawing.Point(619, 48);
            this.comboBoxUnity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnity.Name = "comboBoxUnity";
            this.comboBoxUnity.Size = new System.Drawing.Size(138, 28);
            this.comboBoxUnity.TabIndex = 67;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(838, 453);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 32);
            this.buttonDelete.TabIndex = 66;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(619, 453);
            this.buttonAlter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(104, 32);
            this.buttonAlter.TabIndex = 65;
            this.buttonAlter.Text = "Alter";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(11, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTitle.TabIndex = 64;
            this.labelTitle.Text = "Title";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(619, 493);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(323, 29);
            this.buttonList.TabIndex = 63;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(729, 453);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 32);
            this.buttonSave.TabIndex = 62;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelEndDateTime
            // 
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEndDateTime.Location = new System.Drawing.Point(619, 163);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(88, 25);
            this.labelEndDateTime.TabIndex = 61;
            this.labelEndDateTime.Text = "End Date";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(619, 192);
            this.maskedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxEndDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(323, 27);
            this.maskedTextBoxEndDate.TabIndex = 60;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelBeginDateTime
            // 
            this.labelBeginDateTime.AutoSize = true;
            this.labelBeginDateTime.BackColor = System.Drawing.SystemColors.Menu;
            this.labelBeginDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelBeginDateTime.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelBeginDateTime.Location = new System.Drawing.Point(619, 232);
            this.labelBeginDateTime.Name = "labelBeginDateTime";
            this.labelBeginDateTime.Size = new System.Drawing.Size(104, 25);
            this.labelBeginDateTime.TabIndex = 59;
            this.labelBeginDateTime.Text = "Begin Date";
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(619, 261);
            this.dateTimePickerBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(323, 27);
            this.dateTimePickerBeginDate.TabIndex = 58;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDescription.Location = new System.Drawing.Point(11, 81);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 30);
            this.labelDescription.TabIndex = 57;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(11, 119);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(551, 151);
            this.textBoxDescription.TabIndex = 56;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(11, 47);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(551, 27);
            this.textBoxTitle.TabIndex = 55;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(573, 292);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(90, 30);
            this.labelAmount.TabIndex = 80;
            this.labelAmount.Text = "Amount";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(573, 329);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownAmount.TabIndex = 79;
            // 
            // labelUnityReminder
            // 
            this.labelUnityReminder.AutoSize = true;
            this.labelUnityReminder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnityReminder.Location = new System.Drawing.Point(739, 292);
            this.labelUnityReminder.Name = "labelUnityReminder";
            this.labelUnityReminder.Size = new System.Drawing.Size(63, 30);
            this.labelUnityReminder.TabIndex = 82;
            this.labelUnityReminder.Text = "Unity";
            // 
            // comboBoxUnityReminder
            // 
            this.comboBoxUnityReminder.AutoCompleteCustomSource.AddRange(new string[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxUnityReminder.FormattingEnabled = true;
            this.comboBoxUnityReminder.Items.AddRange(new object[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxUnityReminder.Location = new System.Drawing.Point(739, 327);
            this.comboBoxUnityReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnityReminder.Name = "comboBoxUnityReminder";
            this.comboBoxUnityReminder.Size = new System.Drawing.Size(203, 28);
            this.comboBoxUnityReminder.TabIndex = 81;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDayOfWeek.Location = new System.Drawing.Point(571, 359);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(141, 30);
            this.labelDayOfWeek.TabIndex = 84;
            this.labelDayOfWeek.Text = "Day Of Week";
            // 
            // comboBoxDayOfWeek
            // 
            this.comboBoxDayOfWeek.AutoCompleteCustomSource.AddRange(new string[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxDayOfWeek.FormattingEnabled = true;
            this.comboBoxDayOfWeek.Items.AddRange(new object[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(571, 399);
            this.comboBoxDayOfWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(138, 28);
            this.comboBoxDayOfWeek.TabIndex = 83;
            this.comboBoxDayOfWeek.SelectedIndexChanged += new System.EventHandler(this.comboBoxDayOfWeek_SelectedIndexChanged);
            // 
            // labelEndWhen
            // 
            this.labelEndWhen.AutoSize = true;
            this.labelEndWhen.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndWhen.Location = new System.Drawing.Point(830, 359);
            this.labelEndWhen.Name = "labelEndWhen";
            this.labelEndWhen.Size = new System.Drawing.Size(112, 30);
            this.labelEndWhen.TabIndex = 86;
            this.labelEndWhen.Text = "End When";
            // 
            // comboBoxEnd
            // 
            this.comboBoxEnd.AutoCompleteCustomSource.AddRange(new string[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxEnd.FormattingEnabled = true;
            this.comboBoxEnd.Items.AddRange(new object[] {
            "SECONDS",
            "MINUTES",
            "HOURS",
            "DAYS",
            "WEEKS",
            "MONTHS",
            "YEARS"});
            this.comboBoxEnd.Location = new System.Drawing.Point(715, 399);
            this.comboBoxEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEnd.Name = "comboBoxEnd";
            this.comboBoxEnd.Size = new System.Drawing.Size(109, 28);
            this.comboBoxEnd.TabIndex = 85;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(830, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 87;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnd.Location = new System.Drawing.Point(718, 359);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(49, 30);
            this.labelEnd.TabIndex = 88;
            this.labelEnd.Text = "End";
            // 
            // FormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 539);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelEndWhen);
            this.Controls.Add(this.comboBoxEnd);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.comboBoxDayOfWeek);
            this.Controls.Add(this.labelUnityReminder);
            this.Controls.Add(this.comboBoxUnityReminder);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.dataGridViewEvent);
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
            this.Name = "FormReminder";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.Label labelUnity;
        private System.Windows.Forms.ComboBox comboBoxUnity;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAlter;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelEndDateTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.Label labelBeginDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDate;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelUnityReminder;
        private System.Windows.Forms.ComboBox comboBoxUnityReminder;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.Label labelEndWhen;
        private System.Windows.Forms.ComboBox comboBoxEnd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEnd;
    }
}