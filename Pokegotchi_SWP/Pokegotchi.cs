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
        public int friendship
        {
            get { return _Friendship; }
            set { 
                if(_Friendship + value > 1000)
                {
                    _Friendship = 1000;
                }
                else
                {
                    _Friendship = _Friendship + value;
                }
                }
        }
        public int HPbase
        {
            get { return _HPbase; }
            set { _HPbase = value; }
        }
        public int ATKbase
        {
            get { return _ATKbase; }
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
            this.friendship = Friendship;
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

        private int CalculateStats(int basestat, int level)
        {
            double stat;

            if (level < 10)
            {
                stat = Math.Round((basestat * (1.5 + (level / 20) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 20)
            {
                stat = Math.Round((basestat * (1.49 + (level / 20) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 30)
            {
                stat = Math.Round((basestat * (1.48 + (level / 21) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 40)
            {
                stat = Math.Round((basestat * (1.47 + (level / 21) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 50)
            {
                stat = Math.Round((basestat * (1.46 + (level / 22) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 60)
            {
                stat = Math.Round((basestat * (1.45 + (level / 22) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 70)
            {
                stat = Math.Round((basestat * (1.44 + (level / 23) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 80)
            {
                stat = Math.Round((basestat * (1.43 + (level / 23) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 90)
            {
                stat = Math.Round((basestat * (1.42 + (level / 24) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }
            else
            {
                stat = Math.Round((basestat * (1.41 + (level / 24) * (level / 15)) * (1 + friendship / 3000) * 0.08 + level * 2), 2);
            }

            int statrounded;
            statrounded = Convert.ToInt32(stat);
            return statrounded;
        }
        private int CalculateHP(int basestat, int level)
        {
            double stat;

            if (level < 10)
            {
                stat = Math.Round((basestat * (1.55 + (level / 18) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 20)
            {
                stat = Math.Round((basestat * (1.54 + (level / 18) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 30)
            {
                stat = Math.Round((basestat * (1.53 + (level / 19) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 40)
            {
                stat = Math.Round((basestat * (1.52 + (level / 19) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 50)
            {
                stat = Math.Round((basestat * (1.51 + (level / 20) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 60)
            {
                stat = Math.Round((basestat * (1.50 + (level / 20) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 70)
            {
                stat = Math.Round((basestat * (1.49 + (level / 21) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 80)
            {
                stat = Math.Round((basestat * (1.48 + (level / 21) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 90)
            {
                stat = Math.Round((basestat * (1.47 + (level / 22) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }
            else
            {
                stat = Math.Round((basestat * (1.46 + (level / 22) * (level / 15)) * (1 + friendship / 2500) * 0.1 + level * 2), 2);
            }

            int statrounded;
            statrounded = Convert.ToInt32(stat);
            return statrounded;
        }
        private void LevelUP()
        {
            if(EXPhave < EXPneeded)
            {
                return;
            }

            do
            {
                EXPhave = EXPhave - EXPneeded;
                level++;
                ATK = CalculateStats(ATKbase, level);

            } while (EXPhave > EXPneeded);
        }

    }
}
