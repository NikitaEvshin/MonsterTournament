using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTaurment2
{
    public class Monsters
    {
        public string Name;
        public int Hp;
        public int Dmg;
        public bool IsAlive;

        public Monsters(string name, int hp, int dmg, bool isAlive)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
            IsAlive = isAlive;
        }

        public void GetDamage(int Dmg)
        {
            Hp = Hp - Dmg;
            if (Hp < 0)
            {
                IsAlive = false;
            }
        }
        public override string ToString()
        {
            return "Имя " + Name;
        }
    }
}
