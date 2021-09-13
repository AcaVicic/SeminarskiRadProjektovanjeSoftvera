using System;
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
                throw new ValidationException();
        }
    }
}
