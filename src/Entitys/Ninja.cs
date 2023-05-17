using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_RPG.src.Entitys
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType; 
            base.HP = HP;
            base.MP = MP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou a Shuriken!";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.Name + " Lançou a shuriken super efetiva com bonus de ataque" + Bonus;
            else
                return this.Name + " Lançou a shuriken com bonus de ataque" + Bonus;

        }
    }
}