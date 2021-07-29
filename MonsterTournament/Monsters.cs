using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTournament
{
    public class Monster
    {
        public string Name;
        public int Hp;
        public int Dmg;
        public bool IsAlive;

        public Monster(string name, int hp, int dmg)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
            IsAlive = true;
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
