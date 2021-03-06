using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Fight
    {
        public List<Monster> Monsters;
        private int TourCount;

        public Fight(List<Monster> monsters, int tourCount)
        {
            TourCount = tourCount;
            Monsters = monsters;
            if (TourCount < 0 && TourCount > 0 && (TourCount & (TourCount - 1)) == 0)
            {
                throw new ArgumentException("Количество туров должно быть больше нуля и кратно 2");
            }
        }
        public void StartTournamemt()
        {
            for (int i = 0; i < TourCount; i++)
            {
                (List<Monster> firsthalf, List<Monster> secondhalf) twoLists = Pair.Selection(Monsters);
                Battle(twoLists.firsthalf, twoLists.secondhalf);
            }

        }
        private void Battle(List<Monster> firsthalf, List<Monster> secondhalf)
        {
            List<Monster> winners = new List<Monster>();
            for (int i = 0; i < firsthalf.Count; i++)
            {
                while (firsthalf[i].IsAlive&& secondhalf[i].IsAlive)
                {
                    if (firsthalf[i].Hp > 0 && secondhalf[i].Hp > 0)
                    {
                        firsthalf[i].GetDamage(secondhalf[i].Dmg);
                        secondhalf[i].GetDamage(firsthalf[i].Dmg);
                        Console.WriteLine($"{firsthalf[i].Name} Здоровье {firsthalf[i].Hp}, {secondhalf[i].Name} Здоровье {secondhalf[i].Hp}");
                    }
                    if (firsthalf[i].Hp <= 0)
                    {
                        firsthalf[i].IsAlive = false;
                    }
                    else if (secondhalf[i].Hp <= 0)
                    {
                        secondhalf[i].IsAlive = false;
                    }
                }
            }

            for (int i = 0; i < firsthalf.Count; i++)
            {
                if (firsthalf[i].IsAlive)
                {
                    winners.Add(firsthalf[i]);
                }

                if (secondhalf[i].IsAlive)
                {
                    winners.Add(secondhalf[i]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\t Победители этого тура");
            foreach (var i in winners)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Monsters = winners;
        }
    }
}
