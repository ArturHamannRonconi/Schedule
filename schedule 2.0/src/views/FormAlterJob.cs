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
    public partial class FormAlterJob : Form
    {
        private Job AlterJob { get; set; }
        private int JobIndex { get; set; }

        public FormAlterJob(Job job, int index)
        {
            AlterJob = job;
            JobIndex = index;
            InitializeComponent();
        }

        private void FormAlterJob_Load(object sender, EventArgs e)
        {
            comboBoxPriority.DataSource = Enum.GetValues(typeof(Priority));
            textBoxTitle.Text = AlterJob.Title;
            textBoxDescription.Text = AlterJob.Description;
            dateTimePickerBeginDate.Value = AlterJob.BeginDateTime;
            maskedTextBoxEndDate.Text = AlterJob.EndDateTime.ToString();
            comboBoxPriority.SelectedItem = AlterJob.Priorityy;
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var isValidEndDate = DateTime.TryParse(
                    maskedTextBoxEndDate.Text,
                    out DateTime endDateTime
                );

                if (!isValidEndDate) throw new Exception("Invalid end date");

                var job = FormJob.Jobs[JobIndex];


                job.Title = textBoxTitle.Text;
                job.Description = textBoxDescription.Text;
                job.BeginDateTime = dateTimePickerBeginDate.Value;
                job.Priorityy = (Priority)comboBoxPriority.SelectedItem;
                job.EndDateTime = endDateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }
    }
}
