using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        public static string pokegotchiName; //for other forms to search the right pokegotchi

        public static List<object>ListPokegotchi = new List<object>(); //creating list to safe all pokegotchi needed (which the user has)

        Pokegotchi Fireboy = new Pokegotchi("Fire", "Fireboy", "Feuer", 1, 1, 1, 50, 60, 30, 40, 30, 3); //creating new objects of starter pokegotchi
        Pokegotchi Wasser = new Pokegotchi("Water", "Wasser", "Wasser", 1, 1, 1, 70, 20, 50, 20, 50, 4);
        Pokegotchi VentiStone = new Pokegotchi("Platzhalter", "Vent", "Luft", 100, 100, 100, 100, 100, 100, 100, 100, 100);

        public f_Home()
        {
            InitializeComponent();

            if (f_NewPokegotchi.chosenpokegotchi == 1)//show the matching picture to the chosen pokegotchi
            {
                pbFavPokegotchi.Image = Properties.Resources.WaterPlop_Wasser;
                ListPokegotchi.Add(Wasser);

                pokegotchiName = Wasser.name;
            }
            else if (f_NewPokegotchi.chosenpokegotchi == 2)
            {
                pbFavPokegotchi.Image = Properties.Resources.Fireboy_Feuer;
                ListPokegotchi.Add(Fireboy);

                pokegotchiName = Fireboy.name;
            }
            else if (f_NewPokegotchi.chosenpokegotchi == 3)
            {
                pbFavPokegotchi.Image = Properties.Resources.venti;
                ListPokegotchi.Add(VentiStone);

                pokegotchiName = VentiStone.name;
            }
        }

        private void btnCare_Click(object sender, EventArgs e) //go to diffrent forms
        {
            f_Care care = new f_Care();
            this.Hide();
            care.ShowDialog();

            if (care.exit == true)
            {
                this.Show();
                care.Dispose();
                care.Close();

            }

            else if (care.exit == false)
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
            f_PokegotchiSelection fightselection = new f_PokegotchiSelection();
            this.Hide();
            fightselection.ShowDialog();

            if (fightselection.exit == true)
            {
                this.Show();
            }

            else if (fightselection.exit == false)
            {
                Environment.Exit(4);
            }

        }

        private void btnBreed_Click(object sender, EventArgs e)
        {
            f_Breed breed = new f_Breed();
            this.Hide();
            breed.ShowDialog();

            if (breed.exit == true)
            {
                this.Show();
            }

            else if (breed.exit == false)
            {
                Environment.Exit(4);
            }
        }
    }
}
