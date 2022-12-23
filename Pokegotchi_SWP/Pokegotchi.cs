using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class Pokegotchi
    {
        private string _race, _name;
        private int _level, _EXPhave, _EXPneeded, _Friendship, _HPbase, _ATKbase, _DEFbase, _SATKbase, _SDEFbase, _INITbase, _HP, _ATK, _DEF, _SATK, _SDEF, _INIT;

        #region Getter & Setter

        public string race
        {
            get { return _race; }
            set { _race = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int level
        {
            get { return _level; }
            set { _level = value; }
        }
        public int EXPhave
        {
            get { return _EXPhave; }
            set { _EXPhave = value; }
        }
        public int EXPneeded
        {
            get { return _EXPneeded; }
            set { _EXPneeded = value; }
        } 
        public int Friendship
        {
            get { return _Friendship}
            set { _Friendship = value; }
        }
        public int HPbase
        {
            get { return _HPbase; }
            set { _HPbase = value; }
        }
        public int ATKbase
        {
            get { return _ATKbase}
            set { _ATKbase = value; }
        }
        public int DEFbase
        {
            get { return _DEFbase; }
            set { _DEFbase = value; }
        }
        public int SATKbase
        {
            get { return _SATKbase; }
            set { _SATKbase = value; }
        }
        public int SDEFbase
        {
            get { return _SDEFbase; }
            set { _SDEFbase = value; } 
        }
        public int INITbase
        {
            get { return _INITbase; }
            set { _INITbase = value; }
        }
        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }
        public int ATK
        {
            get { return _ATK; }
            set { _ATK = value; }
        }
        public int DEF
        {
            get { return _DEF; }
            set { _DEF = value; }
        }
        public int SATK
        {
            get { return _SATK; }
            set { _SATK = value; }
        }
        public int SDEF
        {
            get { return _SDEF; }
            set { _SDEF = value; } 
        }
        public int INIT
        {
            get { return _INIT; }
            set { _INIT = value; }
        }

        #endregion

        public Pokegotchi(string race, string name, int level, int Friendship, int EXPHave, int HPbase, int ATKbase, int DEFbase, int SATKbase, int SDEFbase, int INITbase)
        {
            this.race = race;
            this.name = name;
            this.level = level;
            this.Friendship = Friendship;
            this.EXPhave = EXPhave;

            this.HPbase = HPbase;
            this.ATKbase = ATKbase;
            this.DEFbase = DEFbase;
            this.SATKbase = SATKbase;
            this.SDEFbase = SDEFbase;
            this.INITbase = INITbase;

            
            this.ATK = CalculateStats(ATKbase, level);
            this.DEF = CalculateStats(DEFbase, level);
            this.SATK = CalculateStats(SATKbase, level);
            this.SDEF = CalculateStats(SDEFbase, level);
            this.INIT = CalculateStats(INITbase, level);
        }

        public int CalculateStats(int basestat, int level)
        {
            double stat;
            if (i < 10)
            {
                stat = Math.Round((basestat * (1 + (level / 30) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.1), 2);
            }
            else if (i < 20)
            {
                stat = Math.Round((basestat * (1 + (level / 32) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.2), 2);
            }
            else if (i < 30)
            {
                stat = Math.Round((basestat * (1 + (level / 34) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.3), 2);
            }
            else if (i < 40)
            {
                stat = Math.Round((basestat * (1 + (level / 36) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.4), 2);
            }
            else if (i < 50)
            {
                stat = Math.Round((basestat * (1 + (level / 38) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.5), 2);
            }
            else if (i < 60)
            {
                stat = Math.Round((basestat * (1 + (level / 40) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.6), 2);
            }
            else if (i < 70)
            {
                stat = Math.Round((basestat * (1 + (level / 42) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.7), 2);
            }
            else if (i < 80)
            {
                stat = Math.Round((basestat * (1 + (level / 44) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.8), 2);
            }
            else if (i < 90)
            {
                stat = Math.Round((basestat * (1 + (level / 46) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 2.9), 2);
            }
            else
            {
                stat = Math.Round((basestat * (1 + (level / 48) * (level / 15)) * (1 + friendship / 3000) * 0.12 + level * 3), 2);
            }

            int statrounded;
            statrounded = stat;
            return statrounded;
        }

    }
}
