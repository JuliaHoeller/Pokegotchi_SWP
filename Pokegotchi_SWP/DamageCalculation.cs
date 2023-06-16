using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi_SWP
{
    internal class DamageCalculation
    {
        public static int Calculate(int Attackstat, int EnemyDefense, int AttackDamage, int Critchance, string AttackType, string UserType, string DefenseTyp)
        {
            int Damage = 0;
            double CritMultipliyer = 1;
            double STAB = 1;
            double TypeMultipliyer = 1; ;

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
            TypeMultipliyer = Pokegotchi.TypeAdvantege(AttackType, DefenseTyp);

            Damage = Convert.ToInt32(Base * Attackstat / EnemyDefense * CritMultipliyer * TypeMultipliyer * (rnd.Next(85, 100) / 100) * STAB);
            
            return Damage;
        }
        public static int Calculate(int Attackstat, int EnemyDefense, Attacks attack, string UserType, string DefenseTyp, int level)
        {
            double Damage = 0;
            double CritMultipliyer = 1;
            double STAB = 1;
            double TypeMultipliyer = 1; ;

            double Base = attack.damage;

            Random rnd = new Random();
            //int CritOrNot = rnd.Next(1, 100);
            //if (CritOrNot <= 20)
            //{
            //    CritMultipliyer = 1.35;
            //}
            //else
            //{
            //    CritMultipliyer = 1;
            //}

            if (attack.typ.Equals(UserType))
            {
                STAB = 1.5;
            }
            else
            {
                STAB = 1;
            }
            TypeMultipliyer = Pokegotchi.TypeAdvantege(attack.typ, DefenseTyp);
            double atk = Convert.ToDouble(Attackstat);
            double eDef = Convert.ToDouble(EnemyDefense);
            double DoubleLevel = Convert.ToDouble(level) * 4;
            double RandomValue = rnd.Next(85, 100);
            RandomValue = RandomValue / 100;

            Damage = ((DoubleLevel / 5 + 2) * Base * 1.4 * atk / eDef) / 50 * CritMultipliyer * TypeMultipliyer * RandomValue * STAB;

            int returnDamage = Convert.ToInt32(Damage);

            return returnDamage;
        }
    }
}
