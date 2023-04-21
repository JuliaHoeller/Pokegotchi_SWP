using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class DamageCalculation
    {
        public int Calculate(int Attackstat, int EnemyDefense, int AttackDamage, int Critchance, string AttackType, string UserType, string DefenseTyp1)
        {
            int Damage = 0;
            double CritMultipliyer = 1;
            double STAB = 1;
            double TypeMultipliyer;

            int Base = AttackDamage;

            Random rnd = new Random();
            int CritOrNot = rnd.Next(1, 100);
            if(CritOrNot <= Critchance)
            {
                CritMultipliyer = 1.35;
            }
            else
            {
                CritMultipliyer = 1;
            }

            if (AttackType.Equals(UserType))
            {
                STAB = 1.5;
            }
            else
            {
                STAB = 1;
            }

            Damage = Convert.ToInt32(Base * Attackstat / EnemyDefense * CritMultipliyer);
            
            



            return Damage;
        }
    }
}
