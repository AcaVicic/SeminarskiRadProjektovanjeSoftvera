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
    public class WorkerController
    {
        internal void AddWorker(TextBox txtFirstName, TextBox txtLastName)
        {
            Helper.EmptyField(txtFirstName, txtLastName);

            Worker worker = new Worker
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };

            Communication.Instance.AddWorker(worker);
        }
    }
}
