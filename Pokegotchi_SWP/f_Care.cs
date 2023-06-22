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
    public partial class f_Care : Form
    {
        public bool exit = false;
        public int timeLeft = 6 * 60 * 60;

        int count = 0;

        public f_Care()
        {
            InitializeComponent();

            if (f_NewPokegotchi.chosenpokegotchi == 1) //check which starter pokegotchi got chosen
            {
                pbPokegotchi.Image = Properties.Resources.WaterPlop_Wasser; //select mathching picture
            }
            else if (f_NewPokegotchi.chosenpokegotchi == 2)
            {
                pbPokegotchi.Image = Properties.Resources.Fireboy_Feuer;
            }
            else if (f_NewPokegotchi.chosenpokegotchi == 3)
            {
                pbPokegotchi.Image = Properties.Resources.venti;
            }

            foreach (Pokegotchi pokegotchi in f_Home.ListPokegotchi) //search for selected pokegotchi
            {
                if (pokegotchi.name.Equals(f_Home.pokegotchiName))
                {
                    lblFriendshiplevel.Text = "Freundschaftsstufe: " + pokegotchi.Friendship; //show current level
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Hide();
            this.Dispose();
        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            count++; //count to enable button in the right moment

            foreach(Pokegotchi pokegotchi in f_Home.ListPokegotchi) //search for selected pokegotchi
            {
                if(pokegotchi.name.Equals(f_Home.pokegotchiName))
                {
                    pokegotchi.Friendship += 1; //add frienshiplevel

                    lblFriendshiplevel.Text = "Freundschaftsstufe: " + pokegotchi.Friendship; //display new friendschip level
                }

                if (count >= 1)
                {
                    btnWash.Enabled = false; //buttons can not be used after you cared for your pokegotchi one time
                    btnCuddle.Enabled = false;
                    btnPlay.Enabled = false;

                    tmWaiting.Interval = 1000;
                    tmWaiting.Start(); //timer starts so you can care again in 6 hours
                    count = 0;

                    MessageBox.Show("Du musst 6 Stunden warten bis du dich wieder um dein Pokegotchi kümmern kannst!");
                }
            }
        }

        private void btnCuddle_Click(object sender, EventArgs e)
        {
            count++;

            foreach (Pokegotchi pokegotchi in f_Home.ListPokegotchi) //search for selected pokegotchi
            {
                if (pokegotchi.name.Equals(f_Home.pokegotchiName))
                {
                    pokegotchi.Friendship += 1; //add frienshiplevel

                    lblFriendshiplevel.Text = "Freundschaftsstufe: " + pokegotchi.Friendship; //display new friendschip level
                }

                if (count >= 1)
                {
                    btnWash.Enabled = false; //buttons can not be used after you cared for your pokegotchi one time
                    btnCuddle.Enabled = false;
                    btnPlay.Enabled = false;

                    count = 0;

                    tmWaiting.Interval = 1000;
                    tmWaiting.Start(); //timer starts so you can care again in 6 hours

                    MessageBox.Show("Du musst 6 Stunden warten bis du dich wieder um dein Pokegotchi kümmern kannst!");
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            count++;

            foreach (Pokegotchi pokegotchi in f_Home.ListPokegotchi) //search for selected pokegotchi
            {
                if (pokegotchi.name.Equals(f_Home.pokegotchiName))
                {
                    pokegotchi.Friendship += 1; //add frienshiplevel

                    lblFriendshiplevel.Text = "Freundschaftsstufe: " + pokegotchi.Friendship; //display new friendschip level
                }
            }

            if(count >= 1)
            {
                btnWash.Enabled = false;
                btnCuddle.Enabled = false;
                btnPlay.Enabled = false;

                tmWaiting.Interval = 1000;
                tmWaiting.Start();
                count = 0;

                MessageBox.Show("Du musst 6 Stunden warten bis du dich wieder um dein Pokegotchi kümmern kannst!");
            }
        }

        private void tmWaiting_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0) //when timer reaches zero, buttons get enabled again and user can care again
            {
                btnWash.Enabled = true;
                btnCuddle.Enabled = true;
                btnPlay.Enabled = true;

                tmWaiting.Stop(); //stop timer after 3 hours
            }

            lblTimeLeft.Text = "Verbleibende Zeit: " + timeLeft.ToString(); //show time till finished in seconds
        }
    }
}
