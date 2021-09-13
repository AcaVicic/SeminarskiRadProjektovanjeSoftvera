using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using View.Forms;

namespace View
{
    public class MainCoordinator
    {
        public Owner Owner { get; internal set; }
        private static MainCoordinator instance;

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainCoordinator();
                return instance;
            }
        }

        internal void ShowDialog(Form form)
        {
            form.ShowDialog();
        }

        private MainCoordinator()
        {

        }

        public void OpenForm(Form form, Form closingForm)
        {
            form.Show();
            closingForm.Dispose();
        }

        internal void OpenMainForm(MainForm mainForm, LoginForm form)
        {
            form.Visible = false;
            mainForm.ShowDialog();
            form.Visible = true;
        }
    }
}
