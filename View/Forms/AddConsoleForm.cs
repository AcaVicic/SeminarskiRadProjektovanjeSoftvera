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
    public partial class AddConsoleForm : Form
    {
        private ConsoleController controller;
        public AddConsoleForm()
        {
            InitializeComponent();
            controller = new ConsoleController();
            try
            {
                controller.InitializeConsoleTypes(cbConsoleType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveConsole_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddConsole(cbConsoleType, txtPrice);
                MessageBox.Show("System saved console");
            }
            catch (AddException ex)
            {
                MessageBox.Show("System can't save console");
                MessageBox.Show(ex.Message);
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }
    }
}
