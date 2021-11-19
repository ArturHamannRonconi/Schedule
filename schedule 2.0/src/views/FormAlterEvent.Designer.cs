
namespace Schedule.views
{
    partial class FormAlterEvent
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelBeginDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDateTime = new System.Windows.Forms.Label();
            this.maskedTextBoxEndDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(259, 397);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 41);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(371, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 41);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Location = new System.Drawing.Point(12, 43);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(776, 27);
            this.textBoxTitle.TabIndex = 3;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDescription.Location = new System.Drawing.Point(12, 87);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(122, 30);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 121);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(776, 151);
            this.textBoxDescription.TabIndex = 5;
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
            this.labelBeginDateTime.TabIndex = 6;
            this.labelBeginDateTime.Text = "Begin Date";
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(12, 316);
            this.dateTimePickerBeginDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(177, 27);
            this.dateTimePickerBeginDate.TabIndex = 7;
            // 
            // labelEndDateTime
            // 
            this.labelEndDateTime.AutoSize = true;
            this.labelEndDateTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelEndDateTime.Location = new System.Drawing.Point(208, 287);
            this.labelEndDateTime.Name = "labelEndDateTime";
            this.labelEndDateTime.Size = new System.Drawing.Size(88, 25);
            this.labelEndDateTime.TabIndex = 8;
            this.labelEndDateTime.Text = "End Date";
            // 
            // maskedTextBoxEndDate
            // 
            this.maskedTextBoxEndDate.Location = new System.Drawing.Point(195, 316);
            this.maskedTextBoxEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maskedTextBoxEndDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxEndDate.Name = "maskedTextBoxEndDate";
            this.maskedTextBoxEndDate.Size = new System.Drawing.Size(199, 27);
            this.maskedTextBoxEndDate.TabIndex = 9;
            this.maskedTextBoxEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLocal.Location = new System.Drawing.Point(400, 318);
            this.textBoxLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(388, 27);
            this.textBoxLocal.TabIndex = 10;
            this.textBoxLocal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocal.Location = new System.Drawing.Point(400, 287);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(56, 25);
            this.labelLocal.TabIndex = 12;
            this.labelLocal.Text = "Local";
            // 
            // FormAlterEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.textBoxLocal);
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
            this.Name = "FormAlterEvent";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.FormAlterCommitment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelBeginDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDate;
        private System.Windows.Forms.Label labelEndDateTime;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndDate;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
    }
}