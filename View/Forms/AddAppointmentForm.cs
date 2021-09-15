using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controllers;
using View.Exceptions;

namespace View.Forms
{
    public partial class AddAppointmentForm : Form
    {
        private AppointmentController controller;
        public AddAppointmentForm()
        {
            InitializeComponent();
            controller = new AppointmentController();
            try
            {
                controller.InitializeConsoles(cbConsole);
                controller.InitializeClients(cbClient);
                controller.InitializeWorkers(cbWorker);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddAppointment(cbConsole, cbClient, txtDays, cbWorker);
                MessageBox.Show("System saved appointment");
            }
            catch (AddException ex)
            {
                MessageBox.Show("System can't save appointment");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }
    }
}
