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
    public partial class f_Home : Form
    {
        public bool exit = false;

        public f_Home()
        {
            InitializeComponent();
        }

        private void btnCare_Click(object sender, EventArgs e)
        {
            f_Care care = new f_Care();
            this.Hide();
            care.ShowDialog();
            
            if(care.exit == true)
            {
                this.Show();
            }

            else if(care.exit == false)
            {
                Environment.Exit(3);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Close();
            this.Dispose();
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            f_Fight fight = new f_Fight();
            this.Hide();
            fight.ShowDialog();

            if(fight.exit == true)
            {
                this.Show();
            }

            else if(fight.exit == false)
            {
                Environment.Exit(4);
            }

        }
    }
}
