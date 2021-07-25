using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTaurment2
{
    public class Pair
    {
        public List<Monsters> FirstSelection;

        public Pair(List<Monsters> firstSelection)
        {
            FirstSelection = firstSelection;
        }

        public static (List<Monsters> firsthalf, List<Monsters> secondhalf) Selection(List<Monsters> monster)
        {
            List<Monsters> firsthalf = new List<Monsters>();
            List<Monsters> secondhalf = new List<Monsters>();

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
