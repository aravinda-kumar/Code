using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guide_Load(object sender, EventArgs e)
        {

        }
    }
}
