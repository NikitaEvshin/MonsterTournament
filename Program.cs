using System;
using System.Collections.Generic;

namespace MonsterTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster monster1 = new Monster("Lex", 50, 22);
            Monster monster2 = new Monster("Nik", 120, 20);
            Monster monster3 = new Monster("Van", 120, 225);
            Monster monster4 = new Monster("Ser", 50, 30);
            Monster monster5 = new Monster("Tem", 50, 22);
            Monster monster6 = new Monster("Gur", 220, 20);
            Monster monster7 = new Monster("Grut", 120, 25);
            Monster monster8 = new Monster("Gustav", 500, 30);
            List<Monster> firstSelection = new List<Monster>() {monster1, monster2, monster3, monster4,
                monster5, monster6, monster7, monster8};
            Fight fight = new Fight(firstSelection, 3);
            fight.StartTournamemt();
        }
    }
}
