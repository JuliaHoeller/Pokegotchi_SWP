using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class Attacks
    {
        //The attack Class is new, here will happend much in the future
        private string _attackname, _typ, _sideeffect, _PhyOrSpez;
        private int _damage, _PercentageOfSideeffect, _accurancy, _id;
        public static List<Attacks> AllAttacks = new List<Attacks>();

       #region Getter & Setter
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
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
        public int accurancy
        {
            get { return _accurancy; }
            set { _accurancy = value; }
        }
        public string PhyOrSpez
        {
            get { return _PhyOrSpez; }
            set { _PhyOrSpez = value;}
        }
	#endregion

        public Attacks(int id, string attackname, string typ, int damage, int accurancy, string sideeffect, int percentageOfSideeffect, string PhyOrSpez)
        {
            this.id = id;
            this.attackname = attackname;
            this.typ = typ;
            this.accurancy = accurancy;
            this.sideeffect = sideeffect;
            this.damage = damage;
            this.percentageOfSideeffect = percentageOfSideeffect;
            this.PhyOrSpez=PhyOrSpez;
        }

        public string AttackInformation()
        {
            string info = string.Empty;

            string damagetype;
            switch(PhyOrSpez)
            {
                case "p":
                    damagetype = "Physisch";
                    break;
                case "s":
                    damagetype = "Speziell";
                    break;
                case "b":
                    damagetype = "buff";
                    break;
                default:
                    damagetype = "nix";
                    break;
            }
            
            info += "ID: " + id + ", Name: " + attackname + ", Type: " + typ + ", Damage: " + damage + ", Genauigkeit: " + accurancy + ", Sideeffect: " + sideeffect + ", PercentageSideeffect: " + percentageOfSideeffect + ", PhyOrSpez: " + damagetype;

            return info;
        }



    }
}
