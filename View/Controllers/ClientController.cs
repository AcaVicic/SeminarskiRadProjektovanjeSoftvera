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
    public class ClientController
    {
        private BindingList<Client> clients;
        internal void AddClient(TextBox txtFirstName, TextBox txtLastName, TextBox txtBirthDate)
        {
            Helper.EmptyField(txtFirstName, txtLastName, txtBirthDate);
            DateTime birthDate = Helper.DateFormat(txtBirthDate);

            Client client = new Client
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DateOfBirth = birthDate
            };
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtBirthDate.Text = "";
            Communication.Instance.AddClient(client);
        }

        internal bool FindClients(TextBox txtSearch, DataGridView dgvClient)
        {
            clients = new BindingList<Client>(Communication.Instance.FindClients(txtSearch.Text));

            if (clients.Count == 0)
                return false;

            dgvClient.DataSource = clients;
            MessageBox.Show("System found clients with a given value");
            return true;
        }

        internal void DeleteClient(DataGridView dgvClient)
        {
            Client client = (Client)dgvClient.CurrentRow.DataBoundItem;
            Communication.Instance.DeleteClient(client);
            clients.Remove(client);
        }

    }
}
