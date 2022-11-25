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

        public int CalculateStats(int stat, int level)
        {

        }

    }
}
