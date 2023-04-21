﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class Attacks
    {
        //The attack Class is new, here will happend much in the future
        private string _attackname, _typ, _sideeffect;
        private int _damage, _PercentageOfSideeffect;
        public static List<Attacks> AllAttacks = new List<Attacks>();

       #region Getter & Setter
		 public string attackname
        {
            get { return _attackname; }
            set { _attackname = value; }
        }
        public string typ
        {
            get { return _typ; }
            set { _typ = value; }
        }
        public string sideeffect
        {
            get { return _sideeffect; }
            set { _sideeffect = value; }
        }
        public int damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int percentageOfSideeffect
        {
            get { return _PercentageOfSideeffect;}
            set { _PercentageOfSideeffect = value; }
        } 
	#endregion

        public Attacks(string attackname, string typ, string sideeffect, int damage, int percentageOfSideeffect)
        {
            this.attackname = attackname;
            this.typ = typ;
            this.sideeffect = sideeffect;
            this.damage = damage;
            this.percentageOfSideeffect = percentageOfSideeffect;

            AllAttacks.Add(this);
        }



    }
}
