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
    public partial class DeleteConsoleForm : Form
    {
        private ConsoleController controller;
        public DeleteConsoleForm()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!controller.FindConsoles(cbConsoleType, dgvConsoles))
                    MessageBox.Show("System can't find consoles with a given value");
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
        }

        private void btnDeleteConsole_Click(object sender, EventArgs e)
        {
            try
            {
                controller.DeleteConsole(dgvConsoles);
                MessageBox.Show("System deleted console");
            }
            catch (DeleteException ex)
            {
                MessageBox.Show("System can't delete console");
                MessageBox.Show(ex.Message);
            }
        }

    }
}
