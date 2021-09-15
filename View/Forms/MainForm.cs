using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communications;
using View.Controllers;

namespace View.Forms
{
    public partial class MainForm : Form
    {
        private MainController controller;
        public MainForm()
        {
            InitializeComponent();
            controller = new MainController();
        }

        private void addWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new AddWorkerForm());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Communication.Instance.Disconnect();
        }

        private void deleteWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new DeleteWorkerForm());
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new AddClientForm());
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new DeleteClientForm());
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new FindClientForm());
        }

        private void addConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new AddConsoleForm());
        }

        private void updateConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new UpdateConsoleForm());
        }

        private void deleteConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new DeleteConsoleForm());
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new AddAppointmentForm());
        }

        private void addConsoleTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ShowDialog(new AddConsoleTesting());
        }
    }
}
