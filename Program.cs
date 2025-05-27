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
            Commando com = new Commando("Menachem", "Colonel", new string[]{"Patish", "Izmel", "chevel", "bag", "meimiya"});
            Weapon wep = new Weapon("f16", "idf", 40);


        }
    }
}
