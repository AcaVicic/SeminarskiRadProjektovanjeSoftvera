﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;

namespace View.Helpers
{
    public class Helper
    {
        public static void EmptyField(params TextBox[] textBoxes)
        {
            bool isEmpty = false;
            textBoxes.ToList().ForEach(tb =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.BackColor = Color.Red;
                    isEmpty = true;
                }
                else
                {
                    tb.BackColor = Color.White;
                    isEmpty = false;
                }
            });

            if (isEmpty)
                throw new ValidationException("Fields must not be empty");
        }

        internal static double DobuleValue(TextBox txtPrice)
        {
            double price;
            bool isDouble = Double.TryParse(txtPrice.Text, out price);

            if (!isDouble)
                throw new ValidationException("Price must be number");
            else if(price <= 0)
            {
                throw new ValidationException("Price must must not be less then or equals 0");
            }

            return price;
        }

        internal static void DateCheck(DateTime dateOfTesting)
        {
            if (dateOfTesting < DateTime.Now)
                throw new ValidationException("Console testing must take place in future");
        }

        internal static void ComboBoxUnselected(ComboBox cbConsoleType)
        {
            if (cbConsoleType.SelectedIndex == -1)
                throw new ValidationException("Console type is not selected");
        }

        internal static DateTime DateFormat(TextBox txtBirthDate)
        {
            try
            {
                DateTime birthDate = DateTime.ParseExact(txtBirthDate.Text, "dd.MM.yyyy.", null);
                return birthDate;
            }
            catch (Exception)
            {
                throw new ValidationException("Date format must be dd.MM.yyyy.");
            }
        }
    }
}
