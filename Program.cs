using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] tools = new string[] { "Patish", "Izmel", "chevel", "bag", "meimiya" };
            Commando com = new Commando("Menachem", "Colonel", tools);
            Weapon wep = new Weapon("f16", "idf", 40);

            AirCommando air = new AirCommando("yossef", "general", tools);
            SeaCommando sea = new SeaCommando("daniel", "general", tools);

            Commando[] coms = new Commando[3] { com, air, sea};
            
            foreach (Commando c in coms)
            {
                c.Attack();
            }
        }
    }
}
