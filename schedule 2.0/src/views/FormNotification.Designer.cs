
namespace Schedule.views
{
    partial class FormNotification
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
            this.comboBoxUnity = new System.Windows.Forms.ComboBox();
            this.labelUnity = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRepeat = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.SuspendLayout();
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
            this.comboBoxUnity.Location = new System.Drawing.Point(10, 48);
            this.comboBoxUnity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxUnity.Name = "comboBoxUnity";
            this.comboBoxUnity.Size = new System.Drawing.Size(138, 28);
            this.comboBoxUnity.TabIndex = 0;
            this.comboBoxUnity.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnity_SelectedIndexChanged);
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnity.Location = new System.Drawing.Point(10, 9);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(63, 30);
            this.labelUnity.TabIndex = 1;
            this.labelUnity.Text = "Unity";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(165, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(61, 30);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(165, 48);
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTime.TabIndex = 4;
            // 
            // checkBoxRepeat
            // 
            this.checkBoxRepeat.AutoSize = true;
            this.checkBoxRepeat.Location = new System.Drawing.Point(386, 49);
            this.checkBoxRepeat.Name = "checkBoxRepeat";
            this.checkBoxRepeat.Size = new System.Drawing.Size(85, 24);
            this.checkBoxRepeat.TabIndex = 5;
            this.checkBoxRepeat.Text = "Repeat?";
            this.checkBoxRepeat.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 195);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(229, 29);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(224, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(10, 90);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(60, 30);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(10, 123);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(461, 27);
            this.textBoxType.TabIndex = 9;
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 247);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxRepeat);
            this.Controls.Add(this.numericUpDownTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelUnity);
            this.Controls.Add(this.comboBoxUnity);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormNotification";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnity;
        private System.Windows.Forms.Label labelUnity;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.CheckBox checkBoxRepeat;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
    }
}