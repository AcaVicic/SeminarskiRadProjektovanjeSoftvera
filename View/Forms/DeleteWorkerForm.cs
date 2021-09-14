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
    public partial class DeleteWorkerForm : Form
    {
        private WorkerController controller;
        public DeleteWorkerForm()
        {
            InitializeComponent();
            controller = new WorkerController();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(!controller.FindWorkers(txtSearch, dgvWorkers))
                MessageBox.Show("System can't find workers with a given value");
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                controller.DeleteWorker(dgvWorkers);
                MessageBox.Show("System deleted worker");
            }
            catch (DeleteException ex)
            {
                MessageBox.Show("System can't delete worker");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
