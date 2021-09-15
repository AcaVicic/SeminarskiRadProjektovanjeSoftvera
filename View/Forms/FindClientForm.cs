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
    public partial class FindClientForm : Form
    {
        private ClientController controller;
        public FindClientForm()
        {
            InitializeComponent();
            controller = new ClientController();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!controller.FindClients(txtSearch, dgvClients))
                MessageBox.Show("System can't find clients with a given value");
        }

        private void btnShowClient_Click(object sender, EventArgs e)
        {
            try
            {
                controller.ShowClient(dgvClients);
                
            }
            catch (FindException ex)
            {
                MessageBox.Show("System can't find client with a given value");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
