using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communications;
using View.Helpers;

namespace View.Controllers
{
    public class WorkerController
    {
        private BindingList<Worker> workers;
        internal void AddWorker(TextBox txtFirstName, TextBox txtLastName)
        {
            Helper.EmptyField(txtFirstName, txtLastName);

            Worker worker = new Worker
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            txtFirstName.Text = "";
            txtLastName.Text = "";
            Communication.Instance.AddWorker(worker);
        }

        internal bool FindWorkers(TextBox txtSearch, DataGridView dgvWorkers)
        {
            workers = new BindingList<Worker>(Communication.Instance.FindWorkers(txtSearch.Text));

            if (workers.Count == 0)
                return false;

            dgvWorkers.DataSource = workers;
            MessageBox.Show("System found workers with a given value");
            return true;
        }

        internal void DeleteWorker(DataGridView dgvWorkers)
        {
            Worker worker = (Worker)dgvWorkers.CurrentRow.DataBoundItem;
            Communication.Instance.DeleteWorker(worker);
            workers.Remove(worker);
        }
    }
}
