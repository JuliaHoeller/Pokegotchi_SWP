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
        public static int chosenpokegotchi;

        public f_NewPokegotchi()
        {
            InitializeComponent();
        }

        private void pbPokegotchiEgg1_Click(object sender, EventArgs e)
        {
            chosenpokegotchi = 1;

            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();
        }

        private void pbPokegotchiEgg2_Click(object sender, EventArgs e)
        {
            chosenpokegotchi = 2;

            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();

        }

        private void pbPokegotchiEgg3_Click(object sender, EventArgs e)
        {
            chosenpokegotchi = 3;
            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();
        }
    }
}
