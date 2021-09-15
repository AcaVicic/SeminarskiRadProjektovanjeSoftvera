using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Communications;
using View.Exceptions;
using View.Forms;
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

        internal void ShowClientInfo(Client client, params Label[] labels)
        {
            labels[0].Text = client.FirstName;
            labels[1].Text = client.LastName;
            labels[2].Text = client.BirthDate;
        }

        internal void ShowClient(DataGridView dgvClients)
        {
            try
            {
                Client client = (Client)dgvClients.CurrentRow.DataBoundItem;
                MainCoordinator.Instance.ShowDialog(new ShowClientForm(client));
            }
            catch (Exception ex)
            {
                throw new FindException(ex.Message);
            }
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
            try
            {
                Client client = (Client)dgvClient.CurrentRow.DataBoundItem;
                Communication.Instance.DeleteClient(client);
                clients.Remove(client);
            }
            catch (Exception ex)
            {
                throw new DeleteException(ex.Message);
            }
        }

    }
}
