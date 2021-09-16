using System;
using Console = Domain.ConsoleNS.Console;
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
    public partial class ShowConsoleForm : Form
    {
        private ConsoleController controller;
        private Console console;
        public ShowConsoleForm(ConsoleController controller, Console console)
        {
            InitializeComponent();
            this.controller = controller;
            this.console = console;
        }

        private void ShowConsoleForm_Load(object sender, EventArgs e)
        {
            try
            {
                controller.ShowConsoleInfo(console, lblConsoleType, ckbAvailable, txtPrice);
                MessageBox.Show("System found console with a given value");
            }
            catch (Exception ex)
            {
                MessageBox.Show("System can't find console with a given value");
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.UpdateConsole(console, ckbAvailable, txtPrice);
                MessageBox.Show("System saved console");
            }
            catch (UpdateException ue)
            {
                MessageBox.Show("System can't save console");
                MessageBox.Show(ue.Message);
            }
        }
    }
}
