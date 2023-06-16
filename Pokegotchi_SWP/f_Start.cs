using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

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

            if (credits.exit == true)
            {
                this.Show();
            }

            else if (credits.exit == false)
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

        private void f_Start_Load(object sender, EventArgs e)
        {
            Attacks.AllAttacks.Add(new Attacks(1, "Wasserstoß", "water", 50, 100, "none", 0, "p"));
            Attacks.AllAttacks.Add(new Attacks(2, "Aquastoß", "water", 85, 90, "Defesnse fall 1", 20, "p"));
            Attacks.AllAttacks.Add(new Attacks(3, "Wasserklinge", "water", 120, 80, "Defense fall 1", 15, "p"));
            Attacks.AllAttacks.Add(new Attacks(4, "Wasserspritzer", "water", 50, 100, "none", 0, "s"));
            Attacks.AllAttacks.Add(new Attacks(5, "Wellenbruch", "water", 90, 100, "none", 0, "s"));
            Attacks.AllAttacks.Add(new Attacks(6, "Hochdruckstrahl", "water", 115, 90, "none", 0, "s"));
            Attacks.AllAttacks.Add(new Attacks(7, "Siedewasser", "water", 85, 100, "Burn", 20, "s"));
            Attacks.AllAttacks.Add(new Attacks(8, "Hydration", "water", 0, 100, "Heal", 25, "b"));
            Attacks.AllAttacks.Add(new Attacks(9, "Aquarisierung", "water", 0, 100, "Heal", 60, "b"));
            Attacks.AllAttacks.Add(new Attacks(10, "Feuerwirbel", "fire", 60, 90, "none", 0, "s"));
            Attacks.AllAttacks.Add(new Attacks(11, "Flammenwurf", "fire", 85, 100, "Burn", 10, "s"));
            Attacks.AllAttacks.Add(new Attacks(12, "Flammentornado", "fire", 110, 80, "Burn", 25, "s"));
            Attacks.AllAttacks.Add(new Attacks(13, "Hitzestoß", "fire", 150, 90, "SpezAttack fell 2", 0, "s"));
            Attacks.AllAttacks.Add(new Attacks(14, "Feuerrad", "fire", 55, 100, "Defense fall 1", 0, "p"));
            Attacks.AllAttacks.Add(new Attacks(15, "Flammenpeitsche", "fire", 75, 95, "Defense fall 1", 75, "p"));
            Attacks.AllAttacks.Add(new Attacks(16, "Flammenklinge", "fire", 100, 100, "Defense fall 1", 50, "p"));
            Attacks.AllAttacks.Add(new Attacks(17, "Hochofen", "fire", 0, 100, "Attack raise 1", 100, "b"));
            Attacks.AllAttacks.Add(new Attacks(18, "Anzünden", "fire", 0, 70, "Burn", 100, "b"));
            Attacks.AllAttacks.Add(new Attacks(19, "Erschütterung", "ground", 60, 100, "none", 0, "p"));
            Attacks.AllAttacks.Add(new Attacks(20, "Intensität", "ground", 75, 100, "Speed fell 1", 30, "p"));
            Attacks.AllAttacks.Add(new Attacks(21, "Erdbeben", "ground", 105, 100, "none", 0, "p"));
            Attacks.AllAttacks.Add(new Attacks(22, "Brandsand", "ground", 70, 100, "Burn", 30, "s"));
            Attacks.AllAttacks.Add(new Attacks(23, "Erdkräfte", "ground", 95, 100, "SpezDefense fell 1", 50, "s"));
            Attacks.AllAttacks.Add(new Attacks(24, "Steinhaupt", "ground", 0, 100, "Defense raise 1", 0, "b"));

            //Random rnd = new Random();
            //MessageBox.Show(Attacks.AllAttacks[rnd.Next(Attacks.AllAttacks.Count)].AttackInformation());


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter writer = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true);

            for (int i = 1; i <= 100; i++)
            {
                Pokegotchi test = new Pokegotchi("Testing Mon", "test", "ghost", i, 100, 100, 100, 100, 100, 100, 100, 100);
                int damage = DamageCalculation.Calculate(test.ATK, test.DEF, Attacks.AllAttacks[1], test.typ1, "wind", test.level);
                int damage2 = DamageCalculation.Calculate(test.ATK, test.DEF, Attacks.AllAttacks[0], test.typ1, "wind", test.level);
                int damage3 = DamageCalculation.Calculate(test.ATK, test.DEF, Attacks.AllAttacks[2], test.typ1, "wind", test.level);


                //writer.WriteLine("Level:" + i + ", Health: " + test.HP + ", Damage: " + damage2 + ", Attack: " + Attacks.AllAttacks[0].attackname + ", Basepower: " + Attacks.AllAttacks[0].damage);
                writer.WriteLine("Level:" + i + ", Health: " + test.HP + ", Attackstat: " + test.ATK + ", Damage: " + damage + ", Attack: " + Attacks.AllAttacks[1].attackname + ", Basepower: " + Attacks.AllAttacks[1].damage);
                //writer.WriteLine("Level:" + i + ", Health: " + test.HP + ", Damage: " + damage3 + ", Attack: " + Attacks.AllAttacks[2].attackname + ", Basepower: " + Attacks.AllAttacks[2].damage);

            }
            writer.Flush();
            writer.Close();


        }
    }
}