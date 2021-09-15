using Domain;
using Console = Domain.ConsoleNS.Console;
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
    public class ConsoleTestingController
    {
        internal void InitializeConsoles(ComboBox cbConsole)
        {
            cbConsole.DataSource = Communication.Instance.GetAllAvailableConsoles();
            cbConsole.SelectedIndex = -1;
            cbConsole.Text = "Select console";
        }

        internal void InitializeWorkers(ComboBox cbWorker)
        {
            cbWorker.DataSource = Communication.Instance.GetAllWorkers();
            cbWorker.SelectedIndex = -1;
            cbWorker.Text = "Select worker";
        }

        internal void AddConsoleTesting(ComboBox cbConsole, ComboBox cbWorker, TextBox txtDateOfTesting)
        {
            Helper.EmptyField(txtDateOfTesting);
            DateTime dateOfTesting = Helper.DateFormat(txtDateOfTesting);
            Helper.DateCheck(dateOfTesting);
            Helper.ComboBoxUnselected(cbConsole);
            Helper.ComboBoxUnselected(cbWorker);

            ConsoleTesting consoleTesting = new ConsoleTesting
            {
                Worker = (Worker)cbWorker.SelectedItem,
                Console = (Console)cbConsole.SelectedItem,
                DateOfTesting = dateOfTesting
            };

            Communication.Instance.AddConsoleTesting(consoleTesting);
            txtDateOfTesting.Text = "";
            InitializeConsoles(cbConsole);
            cbWorker.SelectedIndex = -1;
            cbWorker.Text = "Select worker";
        }
    }
}
