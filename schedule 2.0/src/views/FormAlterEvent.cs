using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Schedule.entities;

namespace Schedule.views
{
    public partial class FormAlterEvent : Form
    {
        private Event AlterEvent { get; set; }
        private int EventIndex { get; set; }

        public FormAlterEvent(Event eventt, int index)
        {
            AlterEvent = eventt;
            EventIndex = index;
            InitializeComponent();
        }

        private void FormAlterCommitment_Load(object sender, EventArgs e)
        { 
            textBoxTitle.Text = AlterEvent.Title;
            textBoxDescription.Text = AlterEvent.Description;
            dateTimePickerBeginDate.Value = AlterEvent.BeginDateTime;
            maskedTextBoxEndDate.Text = AlterEvent.EndDateTime.ToString();
            textBoxLocal.Text = AlterEvent.Local;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var isValidEndDate = DateTime.TryParse(
                    maskedTextBoxEndDate.Text,
                    out DateTime endDateTime
                );

                if (!isValidEndDate) throw new Exception("Invalid end date");

                var eventt = FormEvent.Eventss[EventIndex];


                eventt.Title = textBoxTitle.Text;
                eventt.Description = textBoxDescription.Text;
                eventt.BeginDateTime = dateTimePickerBeginDate.Value;
                eventt.Local = textBoxLocal.Text;
                eventt.EndDateTime = endDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
