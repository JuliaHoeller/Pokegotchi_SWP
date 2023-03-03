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
    public partial class f_NewPokegotchi : Form
    {
        public f_NewPokegotchi()
        {
            InitializeComponent();
        }

        private void pbPokegotchiEgg1_Click(object sender, EventArgs e)
        {
            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();

            f_Start start = new f_Start();
            start.ShowDialog();
        }

        private void pbPokegotchiEgg2_Click(object sender, EventArgs e)
        {
            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();

            f_Start start = new f_Start();
            start.ShowDialog();
        }

        private void pbPokegotchiEgg3_Click(object sender, EventArgs e)
        {
            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();

            f_Start start = new f_Start();
            start.ShowDialog();
        }
    }
}
