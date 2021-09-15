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
    public partial class AddConsoleTesting : Form
    {
        private ConsoleTestingController controller;
        public AddConsoleTesting()
        {
            InitializeComponent();
            controller = new ConsoleTestingController();
            try
            {
                controller.InitializeConsoles(cbConsole);
                controller.InitializeWorkers(cbWorker);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveConsoleTesting_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddConsoleTesting(cbConsole, cbWorker, txtDateOfTesting);
                MessageBox.Show("System saved console testing");
            }
            catch (AddException ex)
            {
                MessageBox.Show("System can't save console testing");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }
    }
}
