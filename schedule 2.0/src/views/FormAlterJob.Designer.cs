
namespace Schedule.views
{
    partial class FormAlterJob
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
            this.labelPriority = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.labelEndDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelBeginDateTime = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(400, 287);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(73, 25);
            this.labelPriority.TabIndex = 24;
            this.labelPriority.Text = "Priority";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(195, 316);
            this.maskedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxEndDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(199, 27);
            this.maskedTextBoxEndDate.TabIndex = 22;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // labelEndDateTime
            // 
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEndDateTime.Location = new System.Drawing.Point(208, 287);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(88, 25);
            this.labelEndDateTime.TabIndex = 21;
            this.labelEndDateTime.Text = "End Date";
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(12, 316);
            this.dateTimePickerBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(177, 27);
            this.dateTimePickerBeginDate.TabIndex = 20;
            // 
            // labelBeginDateTime
            // 
            this.labelBeginDateTime.AutoSize = true;
            this.labelBeginDateTime.BackColor = System.Drawing.SystemColors.Menu;
            this.labelBeginDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelBeginDateTime.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.labelBeginDateTime.Location = new System.Drawing.Point(12, 287);
            this.labelBeginDateTime.Name = "labelBeginDateTime";
            this.labelBeginDateTime.Size = new System.Drawing.Size(104, 25);
            this.labelBeginDateTime.TabIndex = 19;
            this.labelBeginDateTime.Text = "Begin Date";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 121);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(776, 151);
            this.textBoxDescription.TabIndex = 18;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDescription.Location = new System.Drawing.Point(12, 87);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 30);
            this.labelDescription.TabIndex = 17;
            this.labelDescription.Text = "Description";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(12, 43);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(776, 27);
            this.textBoxTitle.TabIndex = 16;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(371, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 41);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(259, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 41);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Title";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(400, 318);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(388, 28);
            this.comboBoxPriority.TabIndex = 25;
            // 
            // FormAlterJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 457);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.maskedTextBoxEndDate);
            this.Controls.Add(this.labelEndDateTime);
            this.Controls.Add(this.dateTimePickerBeginDate);
            this.Controls.Add(this.labelBeginDateTime);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormAlterJob";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormAlterJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.Label labelEndDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDate;
        private System.Windows.Forms.Label labelBeginDateTime;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxPriority;
    }
}