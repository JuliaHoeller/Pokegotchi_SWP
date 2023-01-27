namespace Pokegotchi_SWP
{
    public partial class f_Start : Form
    {
        public f_Start()
        {
            InitializeComponent();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            f_Credits credits = new f_Credits();

            this.Hide();
            credits.ShowDialog();
            
            if(credits.exit == true)
            {
                this.Show();
            }

            else if(credits.exit == false)
            {
                Environment.Exit(2);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            f_NewPokegotchi newPokegotchi = new f_NewPokegotchi();
            this.Hide();
            newPokegotchi.ShowDialog();

            Environment.Exit(5);         
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            f_Home home = new f_Home();
            this.Hide();
            home.ShowDialog();

            if (home.exit == true)
            {
                this.Show();
            }

            else if (home.exit == false)
            {
                Environment.Exit(1);
            }

        }
    }
}