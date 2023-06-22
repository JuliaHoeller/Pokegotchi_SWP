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
    public partial class f_PokegotchiSelection : Form
    {
        public bool exit = false;
        public f_PokegotchiSelection()
        {
            InitializeComponent();


            cblSelectPokegotchi.Items.Add("");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Hide();
           this.Dispose();
        }

        private void btnStartFight_Click(object sender, EventArgs e)
        {
            f_Fight fight = new f_Fight();

            this.Hide();
            fight.ShowDialog();
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            exit = true;
            this.Hide();
            this.Dispose();
        }

        private void btnStartFight_Click_1(object sender, EventArgs e)
        {
            f_Fight fight = new f_Fight();

            this.Hide();
            fight.ShowDialog();
        }
    }
}
