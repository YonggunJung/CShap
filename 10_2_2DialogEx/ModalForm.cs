using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_2_2DialogEx
{
    public partial class ModalForm : Form
    {
        public ModalForm()
        {
            InitializeComponent();
        }

        private void BtnOk_(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
