using System;
using System.Collections.Generic;

namespace MonsterTaurment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monsters monster1 = new Monsters("Lex", 50, 22, true);
            Monsters monster2 = new Monsters("Nik", 120, 20, true);
            Monsters monster3 = new Monsters("Van", 120, 225, true);
            Monsters monster4 = new Monsters("Ser", 50, 30, true);
            Monsters monster5 = new Monsters("Tem", 50, 22, true);
            Monsters monster6 = new Monsters("Gur", 220, 20, true);
            Monsters monster7 = new Monsters("Grut", 120, 25, true);
            Monsters monster8 = new Monsters("Gustav", 500, 30, true);
            List<Monsters> firstSelection = new List<Monsters>() {monster1, monster2, monster3, monster4,
                monster5, monster6, monster7, monster8};
            Fight fight = new Fight(firstSelection, 3);
            fight.StartTournamemt();
        }
    }
}
