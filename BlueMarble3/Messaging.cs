using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarble
{
    public partial class Messaging : Form
    {
        public Messaging(string msg)
        {
            InitializeComponent();
            lblMsg.Text = msg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
