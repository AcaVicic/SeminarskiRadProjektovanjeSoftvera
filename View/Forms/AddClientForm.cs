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
    public partial class AddClientForm : Form
    {
        private ClientController controller;
        public AddClientForm()
        {
            InitializeComponent();
            controller = new ClientController();
        }

        private void btnSaveWorker_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddClient(txtFirstName, txtLastName, txtBirthDate);
                MessageBox.Show("System saved client");
            }
            catch (AddException ex)
            {
                MessageBox.Show("System can't save worker");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }
    }
}
