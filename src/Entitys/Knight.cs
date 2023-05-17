using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_RPG.src.Entitys
{
    public class Knight :Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType; 
            base.HP = HP;
            base.MP = MP;
        }

       public override string Attack(){
            return this.Name + " Fez um ataque de espada!";
        }   
        public string Attack(int Bonus){
            if(Bonus > 6)
                return this.Name + " Fez um ataque de espada super efetivo com bonus de" + Bonus;
            else
                return this.Name + " Fez um ataque de espada com bonus de ataque" + Bonus;
        }
    }
}