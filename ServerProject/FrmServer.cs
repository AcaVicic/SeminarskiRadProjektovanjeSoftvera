using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerProject
{
    public partial class FrmServer : Form
    {
        private Server server;
        public FrmServer()
        {
            InitializeComponent();
            server = new Server();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();

            Thread t = new Thread(server.Listen);
            t.IsBackground = true;
            t.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblStatus.Text = "ON";
            lblStatus.ForeColor = Color.Green;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "OFF";
            lblStatus.ForeColor = Color.Red;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            server.Stop();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "OFF";
            lblStatus.ForeColor = Color.Red;
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
        }
    }
}
