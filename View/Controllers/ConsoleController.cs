using Domain.ConsoleNS;
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
using Console = Domain.ConsoleNS.Console;

namespace View.Controllers
{
    public class ConsoleController
    {
        private BindingList<Console> consoles;
        internal void AddConsole(ComboBox cbConsoleType, TextBox txtPrice)
        {
            Helper.EmptyField(txtPrice);
            double price = Helper.DobuleValue(txtPrice);
            Helper.ComboBoxUnselected(cbConsoleType);

            Console console = new Console
            {
                Price = price,
                Available = true,
                ConsoleType = (ConsoleType)cbConsoleType.SelectedItem
            };
            
            txtPrice.Text = "";
            cbConsoleType.SelectedIndex = -1;
            cbConsoleType.Text = "Select console type";
            Communication.Instance.AddConsole(console);
        }

        internal void DeleteConsole(DataGridView dgvConsoles)
        {
            try
            {
                Console console = (Console)dgvConsoles.CurrentRow.DataBoundItem;
                Communication.Instance.DeleteConsole(console);
                consoles.Remove(console);
            }
            catch (Exception ex)
            {
                throw new DeleteException(ex.Message);
            }
        }

        internal void ShowConsoleInfo(Console console, Label lblConsoleType, CheckBox ckbAvailable, TextBox txtPrice)
        {
            lblConsoleType.Text = console.ConsoleType.ToString();
            ckbAvailable.Checked = console.Available;
            txtPrice.Text = console.Price.ToString();
        }

        internal void UpdateConsole(Console console, CheckBox ckbAvailable, TextBox txtPrice)
        {
            Helper.EmptyField(txtPrice);
            double price = Helper.DobuleValue(txtPrice);

            console.Available = ckbAvailable.Checked;
            console.Price = price;
            consoles.Remove(console);
            Communication.Instance.UpdateConsole(console);
            consoles.Add(console);
        }

        internal bool FindConsoles(ComboBox cbConsoleType, DataGridView dgvConsoles)
        {
            Helper.ComboBoxUnselected(cbConsoleType);

            consoles = new BindingList<Console>(Communication.Instance.FindConsoles((int)((ConsoleType)cbConsoleType.SelectedItem)));

            if (consoles.Count == 0)
                return false;

            dgvConsoles.DataSource = consoles;
            MessageBox.Show("System found consoles with a given value");
            return true;
        }

        internal void ShowConsole(ConsoleController controller, DataGridView dgvConsoles)
        {
            try
            {
                Console console = (Console)dgvConsoles.CurrentRow.DataBoundItem;
                MainCoordinator.Instance.ShowDialog(new ShowConsoleForm(controller, console));
            }
            catch (Exception ex)
            {
                throw new FindException(ex.Message);
            }
        }

        internal void InitializeConsoleTypes(ComboBox cbConsoleType)
        {
            cbConsoleType.DataSource = Enum.GetValues(typeof(ConsoleType));
            cbConsoleType.SelectedIndex = -1;
            cbConsoleType.Text = "Select console type";
        }
    }
}
