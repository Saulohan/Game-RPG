using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game_RPG.src.Entitys
{
    public class Wizard :Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP) : base(Name, Level, HeroType, HP, MP)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType; 
            base.HP = HP;
            base.MP = MP;
        }

       public override string Attack(){
            return this.Name + " Lançou uma magia!";
        }   
        public string Attack(int Bonus){
            
            if(Bonus > 6)
                return this.Name + " Lançou uma magia super efetiva com bonus" + Bonus;
            else
                return this.Name + " Lançou uma magia fraca com bonus de" + Bonus;
        }
    }
}