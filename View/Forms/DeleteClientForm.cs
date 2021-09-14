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
    public partial class DeleteClientForm : Form
    {
        private ClientController controller;
        public DeleteClientForm()
        {
            InitializeComponent();
            controller = new ClientController();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!controller.FindClients(txtSearch, dgvClient))
                MessageBox.Show("System can't find clients with a given value");
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                controller.DeleteClient(dgvClient);
                MessageBox.Show("System deleted client");
            }
            catch (DeleteException ex)
            {
                MessageBox.Show("System can't delete client");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
