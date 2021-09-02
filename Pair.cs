using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Pair
    {
        public List<Monster> FirstSelection;

        public Pair(List<Monster> firstSelection)
        {
            FirstSelection = firstSelection;
        }

        public static (List<Monster> firsthalf, List<Monster> secondhalf) Selection(List<Monster> monster)
        {
            List<Monster> firsthalf = new List<Monster>();
            List<Monster> secondhalf = new List<Monster>();

            for (int i = 0; i < monster.Count; i++)
            {
                if (i % 2 == 0)
                {
                    firsthalf.Add(monster[i]);
                }
                else
                {
                    secondhalf.Add(monster[i]);
                }
            }
            return (firsthalf, secondhalf);
        }
    }
}
