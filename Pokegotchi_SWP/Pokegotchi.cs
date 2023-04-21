using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class Pokegotchi
    {
        //define all needed Variables
        //Some of them can be missing or not used, it depends on future devolpment
        private string _race, _name, _typ1, _typ2;
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
        public string typ1
        {
            get { return _typ1; }
            set { _typ1 = value; }
        }
        public string typ2
        {
            get { return _typ2; }
            set { _typ2 = value; }
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

        //Create a new Pokegotchi
        //All this stats are needed, because no Pokegotchi can exists without an HP Value or a ATK Value
        public Pokegotchi(string race, string name, string typ1, string typ2, int level, int Friendship, int EXPHave, int HPbase, int ATKbase, int DEFbase, int SATKbase, int SDEFbase, int INITbase)
        {
            this.race = race;
            this.name = name;
            this.typ1 = typ1;
            this.typ2 = typ2;
            this.level = level;
            this.Friendship = Friendship;
            this.EXPhave = EXPhave;
            this.typ1 = typ1;
            this.typ2 = typ2;

            this.HPbase = HPbase;
            this.ATKbase = ATKbase;
            this.DEFbase = DEFbase;
            this.SATKbase = SATKbase;
            this.SDEFbase = SDEFbase;
            this.INITbase = INITbase;

            this.HP = CalculateHP(HPbase, level);
            this.ATK = CalculateStats(ATKbase, level);
            this.DEF = CalculateStats(DEFbase, level);
            this.SATK = CalculateStats(SATKbase, level);
            this.SDEF = CalculateStats(SDEFbase, level);
            this.INIT = CalculateStats(INITbase, level);
        }

        //The Method in which the Stats are calculated out of the baseStats
        //Diffrence between HP and the other stats: HP-Stat will be higher so its a other method
        private int CalculateStats(int basestat, int level)
        {
            double stat;

            if (level < 10)
            {
                stat = Math.Round((basestat * (1.5 + (level / 20) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 20)
            {
                stat = Math.Round((basestat * (1.49 + (level / 20) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 30)
            {
                stat = Math.Round((basestat * (1.48 + (level / 21) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 40)
            {
                stat = Math.Round((basestat * (1.47 + (level / 21) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 50)
            {
                stat = Math.Round((basestat * (1.46 + (level / 22) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 60)
            {
                stat = Math.Round((basestat * (1.45 + (level / 22) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 70)
            {
                stat = Math.Round((basestat * (1.44 + (level / 23) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 80)
            {
                stat = Math.Round((basestat * (1.43 + (level / 23) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else if (level < 90)
            {
                stat = Math.Round((basestat * (1.42 + (level / 24) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
            }
            else
            {
                stat = Math.Round((basestat * (1.41 + (level / 24) * (level / 15)) * (1 + Friendship / 3000) * 0.08 + level * 2), 2);
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
                stat = Math.Round((basestat * (1.55 + (level / 18) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 20)
            {
                stat = Math.Round((basestat * (1.54 + (level / 18) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 30)
            {
                stat = Math.Round((basestat * (1.53 + (level / 19) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 40)
            {
                stat = Math.Round((basestat * (1.52 + (level / 19) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 50)
            {
                stat = Math.Round((basestat * (1.51 + (level / 20) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 60)
            {
                stat = Math.Round((basestat * (1.50 + (level / 20) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 70)
            {
                stat = Math.Round((basestat * (1.49 + (level / 21) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 80)
            {
                stat = Math.Round((basestat * (1.48 + (level / 21) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else if (level < 90)
            {
                stat = Math.Round((basestat * (1.47 + (level / 22) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }
            else
            {
                stat = Math.Round((basestat * (1.46 + (level / 22) * (level / 15)) * (1 + Friendship / 2500) * 0.1 + level * 2), 2);
            }

            int statrounded;
            statrounded = Convert.ToInt32(stat);
            return statrounded;
        }

        //Following Methods are Work in Progress, something like LevelUp will need the EXP System which will be done later
        #region Work in Progress
        private void LevelUP()
        {
            if (EXPhave < EXPneeded)
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
        public static double TypeAdvantege(string Attacktype, string Defensetype)
        {
            double multiplyier = 1;
            List<string> StrongTypes = new List<string>();
            List<string> WeakTypes = new List<string>();
            List<string> ImmunTypes = new List<string>();
            List<string> Neutraltypes = new List<string>();

            switch (Attacktype)
            {
                case "water":
                    Neutraltypes.AddRange(new List<string>() { "water", "wind", "ghost", "time"});
                    WeakTypes.AddRange(new List<string>() { "fire", "ground", "magma", "rock", "obi", "smoke", "crystal" });
                    StrongTypes.AddRange(new List<string>() { "grass", "ice", "steam", "poison", "bug", "fairy", "psycho", "electric", "sound" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                   break;

                case "fire":
                    Neutraltypes.AddRange(new List<string>() { "fire", "ground", "steam", "smoke", "fairy", "electric", "time" });
                    WeakTypes.AddRange(new List<string>() { "wind", "grass", "ghost", "ice", "bug", "psycho", "sound"});
                    StrongTypes.AddRange(new List<string>() { "water", "magma", "rock", "obi", "poison", "crystal"});

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "ground":
                    Neutraltypes.AddRange(new List<string>() { "ground", "ghost", "steam", "obi", "bug", "smoke", "crystal", "fairy", "psycho", "time" });
                    WeakTypes.AddRange(new List<string>() { "fire", "magma", "rock", "poison", "electric" });
                    StrongTypes.AddRange(new List<string>() { "water", "grass", "ice", "sound" });
                    ImmunTypes.AddRange(new List<string> () { "wind"});

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "wind":
                    Neutraltypes.AddRange(new List<string>() { "water", "ground", "wind", "magma", "ice", "poison", "fairy", "time" });
                    WeakTypes.AddRange(new List<string>() { "fire", "grass", "steam", "bug", "smoke", "sound" });
                    StrongTypes.AddRange(new List<string>() { "rock", "ghost", "obi", "crystal", "psycho", "electric" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "grass":
                    Neutraltypes.AddRange(new List<string>() { "grass", "steam", "poison", "smoke", "psycho", "electric", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "water", "ground", "rock", "obi", "crystal" });
                    StrongTypes.AddRange(new List<string>() { "fire", "wind", "magma", "ghost", "ice", "bug", "fairy" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "magma":
                    Neutraltypes.AddRange(new List<string>() { "fire", "ground", "wind", "magma", "steam", "ghost", "fairy", "psycho", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "grass", "rock", "ice", "bug" });
                    StrongTypes.AddRange(new List<string>() { "water", "obi", "poison", "smoke", "crystal", "electric" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "rock":
                    Neutraltypes.AddRange(new List<string>() { "ground", "magma", "rock", "fairy", "electric", "sound", "time"});
                    WeakTypes.AddRange(new List<string>() { "fire", "wind", "ice", "poison", "bug", "psycho"});
                    StrongTypes.AddRange(new List<string>() { "water", "grass", "smoke", "steam", "obi", "crystal" });
                    ImmunTypes.AddRange(new List<string>() { "ghost" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "ghost":
                    Neutraltypes.AddRange(new List<string>() { "water", "fire", "ground", "wind", "grass", "magma", "rock", "ice", "steam", "obi", "poison", "bug", "smoke", "crystal", "electric" });
                    WeakTypes.AddRange(new List<string>() { "ghost", "psycho" });
                    StrongTypes.AddRange(new List<string>() { "fairy", "sound", "time" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "ice":
                    Neutraltypes.AddRange(new List<string>() { "rock", "ghost", "ice", "obi", "poison", "bug", "smoke", "crystal", "fairy", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "water", "ground", "wind", "grass" });
                    StrongTypes.AddRange(new List<string>() { "fire", "magma", "steam", "psycho", "electric" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "steam":
                    Neutraltypes.AddRange(new List<string>() { "ground", "water", "grass", "magma", "rock", "ghost", "steam", "smoke", "fairy", "psycho", "electric", "time" });
                    WeakTypes.AddRange(new List<string>() { "ice", "bug" });
                    StrongTypes.AddRange(new List<string>() { "water", "fire", "obi", "poison", "crystal", "sound" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "obi":
                    Neutraltypes.AddRange(new List<string>() { "grass", "magma", "ice", "obi", "poison", "bug", "smoke", "psycho", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "fire", "rock", "wind", "fairy" });
                    StrongTypes.AddRange(new List<string>() { "water", "ground", "steam", "crystal", "electric" });
                    ImmunTypes.AddRange(new List<string>() { "ghost" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "poison":
                    Neutraltypes.AddRange(new List<string>() { "water", "ground", "wind", "ghost", "ice", "steam", "poison", "smoke", "electric", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "grass", "fairy", "psycho" });
                    StrongTypes.AddRange(new List<string>() { "fire", "magma", "rock", "obi", "bug", "crystal" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "bug":
                    Neutraltypes.AddRange(new List<string>() { "water", "ground", "rock", "ghost", "ice", "obi", "poison", "bug", "crystal", "electric", "sound", "time"  });
                    WeakTypes.AddRange(new List<string>() { "grass", "fairy", "psycho" });
                    StrongTypes.AddRange(new List<string>() { "fire", "wind", "magma", "steam", "smoke" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "smoke":
                    Neutraltypes.AddRange(new List<string>() { "water", "fire", "ground", "grass", "magma", "ghost", "ice", "steam", "poison", "smoke", "psycho", "electric", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "wind", "bug", "fairy" });
                    StrongTypes.AddRange(new List<string>() { "rock", "obi", "crystal" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "crystal":
                    Neutraltypes.AddRange(new List<string>() { "ground", "rock", "ice", "steam", "obi", "bug", "smoke", "crystal", "fairy", "electric", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "fire", "wind" });
                    StrongTypes.AddRange(new List<string>() { "water", "grass", "magma", "poison", "psycho" });
                    ImmunTypes.AddRange(new List<string>() { "ghost" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "fairy":
                    Neutraltypes.AddRange(new List<string>() { "water", "ground", "wind", "grass", "magma", "rock", "obi", "bug", "smoke", "crystal", "fairy", "electric", "time" });
                    WeakTypes.AddRange(new List<string>() { "psycho", "sound" });
                    StrongTypes.AddRange(new List<string>() { "fire", "ghost", "ice", "steam", "poison" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "psycho":
                    Neutraltypes.AddRange(new List<string>() { "water", "fire", "ground", "wind", "grass", "magma", "rock", "steam", "obi", "smoke", "crystal", "psycho", "electric", "sound", "time" });
                    WeakTypes.AddRange(new List<string>() { "poison", "fairy" });
                    StrongTypes.AddRange(new List<string>() { "ghost", "ice", "bug" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "electric":
                    Neutraltypes.AddRange(new List<string>() { "fire", "magma", "rock", "ghost", "ice", "obi", "poison", "bug", "crystal", "fairy", "psycho" });
                    WeakTypes.AddRange(new List<string>() { "water", "wind", "steam", "smoke", "electric", "sound", "time" });
                    StrongTypes.AddRange(new List<string>() { "grass" });
                    ImmunTypes.AddRange(new List<string>() { "ground" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "sound":
                    Neutraltypes.AddRange(new List<string>() { "ground", "grass", "magma", "rock", "obi", "poison", "bug", "crystal", "fairy", "psycho" });
                    WeakTypes.AddRange(new List<string>() { "water", "fire", "wind", "ghost", "ice", "steam", "smoke", "electric", "sound", "time" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;

                case "time":
                    Neutraltypes.AddRange(new List<string>() { "water", "fire", "ground", "wind", "grass", "magma", "rock", "ghost", "ice", "steam", "obi", "poison", "bug", "smoke", "crystal", "fairy", "psycho"});
                    WeakTypes.AddRange(new List<string>() { "electric", "sound", "time" });

                    if (Neutraltypes.Contains(Defensetype))
                        multiplyier = 1;
                    else if (WeakTypes.Contains(Defensetype))
                        multiplyier = 2;
                    else if (StrongTypes.Contains(Defensetype))
                        multiplyier = 0.5;
                    else if (ImmunTypes.Contains(Defensetype))
                        multiplyier = 0;
                    else
                        multiplyier = 0;
                    break;
            }


            return multiplyier;
        } 
        #endregion
    }
}
