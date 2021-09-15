using Domain;
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

namespace View.Forms
{
    public partial class ShowClientForm : Form
    {
        private ClientController controller;
        private Client client;
        public ShowClientForm(Client client)
        {
            InitializeComponent();
            controller = new ClientController();
            this.client = client;
        }

        private void ShowClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                controller.ShowClientInfo(client, lblFirstName, lblLastName, lblDateOfBirth);
                MessageBox.Show("System found client with a given value");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
