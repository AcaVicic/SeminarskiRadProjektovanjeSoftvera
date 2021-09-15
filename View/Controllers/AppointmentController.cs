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
    public class AppointmentController
    {
        internal void InitializeConsoles(ComboBox cbConsole)
        {
            cbConsole.DataSource = Communication.Instance.GetAllAvailableConsoles();
            cbConsole.SelectedIndex = -1;
            cbConsole.Text = "Select console";
        }

        internal void InitializeClients(ComboBox cbClient)
        {
            cbClient.DataSource = Communication.Instance.GetAllClients();
            cbClient.SelectedIndex = -1;
            cbClient.Text = "Select client";
        }

        internal void InitializeWorkers(ComboBox cbWorker)
        {
            cbWorker.DataSource = Communication.Instance.GetAllWorkers();
            cbWorker.SelectedIndex = -1;
            cbWorker.Text = "Select worker";
        }

        internal void AddAppointment(ComboBox cbConsole, ComboBox cbClient, TextBox txtDays, ComboBox cbWorker)
        {
            Helper.EmptyField(txtDays);
            double days = Helper.DobuleValue(txtDays);
            Helper.ComboBoxUnselected(cbConsole);
            Helper.ComboBoxUnselected(cbClient);
            Helper.ComboBoxUnselected(cbWorker);

            int discount = CheckBirthday(cbClient);

            DateTime end = DateTime.Now;
            end = end.AddDays(days);

            Appointment appointment = new Appointment
            {
                Console = (Console)cbConsole.SelectedItem,
                Client = (Client)cbClient.SelectedItem,
                AppointmentDate = DateTime.Now,
                EndOfAppointment = end,
                Discount = discount,
                Worker = (Worker)cbWorker.SelectedItem
            };
            appointment.Price = days * CalculatePrice(appointment);

            Communication.Instance.AddAppointment(appointment);
            txtDays.Text = "";
            InitializeConsoles(cbConsole);
            cbClient.SelectedIndex = -1;
            cbClient.Text = "Select client";
            cbWorker.SelectedIndex = -1;
            cbWorker.Text = "Select worker";
        }

        private double CalculatePrice(Appointment appointment)
        {
            return appointment.Console.Price * (100 - appointment.Discount) / 100;
        }

        private int CheckBirthday(ComboBox cbClient)
        {
            Client client = (Client)cbClient.SelectedItem;
            DateTime today = DateTime.Now;
            if (client.DateOfBirth.DayOfYear == today.DayOfYear)
                return 20;
            else
                return 0;
        }
    }
}
