using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace socket_Client
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            FormClient fc = new FormClient();
            fc.Show();
        }
    }
}
