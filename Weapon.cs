using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    class Weapon
    {
        public string name;
        public string manufacturer;
        public int bullets;

        public Weapon(string name, string manufacturer, int bullets)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.bullets = bullets;
        }
        public void Shoot()
        {
            bullets--;
            Console.WriteLine("Shoot!");
        }

    }
}
