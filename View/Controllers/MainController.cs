using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Forms;

namespace View.Controllers
{
    public class MainController
    {
        internal void ShowDialog(Form form)
        {
            MainCoordinator.Instance.ShowDialog(form);
        }

        
    }
}
