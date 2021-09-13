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
    public partial class LoginForm : Form
    {
        private LoginController controller;

        public LoginForm()
        {
            InitializeComponent();

            controller = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (controller.Connect())
                    controller.Login(txtUsername, txtPassword, this);

            }
            catch (LoginException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (ValidationException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.FormClosing();
        }
    }
}
