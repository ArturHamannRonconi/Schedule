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
    public partial class FormNotification : Form
    {
        private List<Notification> Notifications { get; set; }

        public FormNotification(List<Notification> notifications)
        {
            Notifications = notifications;
            InitializeComponent();
        }

        private void comboBoxUnity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUnity.DataSource = Enum.GetValues(typeof(Unity));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var time = (short) numericUpDownTime.Value;
                var unity = (Unity) comboBoxUnity.SelectedIndex;
                var type = textBoxType.Text;
                var repeat = checkBoxRepeat.Checked;

                var timeIsZeroOrNegative = time <= 0;
                var typeIsNullOrEmpty = string.IsNullOrEmpty(type);

                if (timeIsZeroOrNegative) throw new Exception("Time doesn't zero or negative!");
                if (typeIsNullOrEmpty) throw new Exception("Type doesn't null or empty!");

                var notification = new Notification(unity, time, type, repeat);

                Notifications.Add(notification);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void FormNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
