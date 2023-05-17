using System;
using Game_RPG.src.Entitys;

namespace GAME_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new("Arus", 23, "Knight", 749, 72);
            Ninja wedge = new("Wedge", 23, "Ninja", 574, 89);
            Wizard wizard = new("Jenica", 23, "White Wizard", 601, 482);
            BlackWizard topapa = new("Topapa", 23, "Black Wizard", 385, 641);

            Console.WriteLine("Ataque da(o) {0}",arus.Name);
            Console.WriteLine("{0}",arus.Attack());
            Console.WriteLine("{0}",arus.Attack(4));
            Console.WriteLine("{0}",arus.Attack(6));
            Console.WriteLine("{0}",arus.Attack(10));
            Console.WriteLine("");
            
            Console.WriteLine("Ataque da(o) {0}",wizard.Name);
            Console.WriteLine("{0}",wizard.Attack());
            Console.WriteLine("{0}",wizard.Attack(4));
            Console.WriteLine("{0}",wizard.Attack(6));
            Console.WriteLine("{0}",wizard.Attack(10));
            Console.WriteLine("");
            
            Console.WriteLine("Ataque da(o) {0}",wedge.Name);
            Console.WriteLine("{0}",wedge.Attack());
            Console.WriteLine("{0}",wedge.Attack(4));
            Console.WriteLine("{0}",wedge.Attack(6));
            Console.WriteLine("{0}",wedge.Attack(10));
            Console.WriteLine("");

            Console.WriteLine("Ataque da(o) {0}",topapa.Name);
            Console.WriteLine("{0}",topapa.Attack());
            Console. WriteLine("{0}",topapa.Attack(4));
            Console.WriteLine("{0}",topapa.Attack(6));
            Console.WriteLine("{0}",topapa.Attack(10));
            Console.WriteLine("");
        }

    }

}