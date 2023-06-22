using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokegotchi_SWP
{
    public partial class f_Fight : Form
    {
        public bool exit1 = false;

        public f_Fight()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            exit1 = true;
            this.Hide();
            this.Dispose();

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            exit1 = true;
            this.Hide();
            this.Dispose();
        }
    }
}
