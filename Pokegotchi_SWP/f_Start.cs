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

            credits.ShowDialog();
            this.Hide();
            this.Show();
        }
    }
}