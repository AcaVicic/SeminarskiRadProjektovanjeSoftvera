using Domain;
using System;
using System.Collections.Generic;
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
    }
}
