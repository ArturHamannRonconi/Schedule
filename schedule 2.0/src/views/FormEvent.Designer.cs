
namespace Schedule.views
{
    partial class FormEvent
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
            this.labelFirstGuest = new System.Windows.Forms.Label();
            this.textBoxFirstGuest = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
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
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstGuest
            // 
            this.labelFirstGuest.AutoSize = true;
            this.labelFirstGuest.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstGuest.Location = new System.Drawing.Point(625, 376);
            this.labelFirstGuest.Name = "labelFirstGuest";
            this.labelFirstGuest.Size = new System.Drawing.Size(100, 25);
            this.labelFirstGuest.TabIndex = 53;
            this.labelFirstGuest.Text = "First Guest";
            // 
            // textBoxFirstGuest
            // 
            this.textBoxFirstGuest.Location = new System.Drawing.Point(625, 404);
            this.textBoxFirstGuest.Name = "textBoxFirstGuest";
            this.textBoxFirstGuest.Size = new System.Drawing.Size(323, 27);
            this.textBoxFirstGuest.TabIndex = 52;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(625, 337);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(323, 27);
            this.textBoxLocal.TabIndex = 51;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocal.Location = new System.Drawing.Point(625, 309);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(56, 25);
            this.labelLocal.TabIndex = 50;
            this.labelLocal.Text = "Local";
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(745, 91);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(85, 24);
            this.checkBoxRepeat.TabIndex = 49;
            this.checkBoxRepeat.Text = "Repeat?";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(625, 83);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 30);
            this.labelType.TabIndex = 48;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(625, 121);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(323, 27);
            this.textBoxType.TabIndex = 47;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(798, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 30);
            this.labelTime.TabIndex = 46;
            this.labelTime.Text = "Time";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(798, 50);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTime.TabIndex = 45;
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnity.Location = new System.Drawing.Point(625, 10);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(63, 30);
            this.labelUnity.TabIndex = 44;
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
            this.comboBoxUnity.Location = new System.Drawing.Point(625, 50);
            this.comboBoxUnity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnity.Name = "comboBoxUnity";
            this.comboBoxUnity.Size = new System.Drawing.Size(138, 28);
            this.comboBoxUnity.TabIndex = 43;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(844, 455);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 32);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonAlter
            // 
            this.buttonAlter.Location = new System.Drawing.Point(625, 455);
            this.buttonAlter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAlter.Name = "buttonAlter";
            this.buttonAlter.Size = new System.Drawing.Size(104, 32);
            this.buttonAlter.TabIndex = 40;
            this.buttonAlter.Text = "Alter";
            this.buttonAlter.UseVisualStyleBackColor = true;
            this.buttonAlter.Click += new System.EventHandler(this.buttonAlter_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(17, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTitle.TabIndex = 39;
            this.labelTitle.Text = "Title";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(625, 495);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(323, 29);
            this.buttonList.TabIndex = 38;
            this.buttonList.Text = "List";
            this.buttonList.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(735, 455);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 32);
            this.buttonSave.TabIndex = 37;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // labelEndDateTime
            // 
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEndDateTime.Location = new System.Drawing.Point(625, 165);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(88, 25);
            this.labelEndDateTime.TabIndex = 36;
            this.labelEndDateTime.Text = "End Date";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(625, 194);
            this.maskedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxEndDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(323, 27);
            this.maskedTextBoxEndDate.TabIndex = 35;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelBeginDateTime
            // 
            this.labelBeginDateTime.AutoSize = true;
            this.labelBeginDateTime.BackColor = System.Drawing.SystemColors.Menu;
            this.labelBeginDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelBeginDateTime.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelBeginDateTime.Location = new System.Drawing.Point(625, 234);
            this.labelBeginDateTime.Name = "labelBeginDateTime";
            this.labelBeginDateTime.Size = new System.Drawing.Size(104, 25);
            this.labelBeginDateTime.TabIndex = 34;
            this.labelBeginDateTime.Text = "Begin Date";
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(625, 263);
            this.dateTimePickerBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(323, 27);
            this.dateTimePickerBeginDate.TabIndex = 33;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDescription.Location = new System.Drawing.Point(17, 83);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 30);
            this.labelDescription.TabIndex = 32;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(17, 121);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(551, 151);
            this.textBoxDescription.TabIndex = 31;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(17, 49);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(551, 27);
            this.textBoxTitle.TabIndex = 30;
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Location = new System.Drawing.Point(17, 279);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowHeadersWidth = 51;
            this.dataGridViewEvent.RowTemplate.Height = 29;
            this.dataGridViewEvent.Size = new System.Drawing.Size(551, 245);
            this.dataGridViewEvent.TabIndex = 54;
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 538);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.labelFirstGuest);
            this.Controls.Add(this.textBoxFirstGuest);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.labelLocal);
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
            this.Name = "FormEvent";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstGuest;
        private System.Windows.Forms.TextBox textBoxFirstGuest;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
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
        private System.Windows.Forms.DataGridView dataGridViewEvent;
    }
}