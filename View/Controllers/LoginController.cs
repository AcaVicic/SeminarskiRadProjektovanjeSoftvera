using Domain;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using View.Communications;
using View.Forms;
using View.Helpers;

namespace View.Controllers
{
    public class LoginController
    {
        internal bool Connect()
        {
            try
            {
                Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Server error!");
                return false;
            }
        }

        internal void Login(TextBox username, TextBox password, LoginForm form)
        {
            Helper.EmptyField(username, password);

            Owner owner = new Owner
            {
                Username = username.Text,
                Password = password.Text
            };

            MainCoordinator.Instance.Owner = (Owner)Communication.Instance.Login(owner);
            MessageBox.Show($"Welcome, {MainCoordinator.Instance.Owner.Username}!");
            MainCoordinator.Instance.OpenMainForm(new MainForm(), form);
        }

        internal void FormClosing()
        {
            Environment.Exit(0);
        }
    }
}
