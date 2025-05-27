using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string _name, string _codeName, string[] _tools) : base(_name, _codeName, _tools)
        {
        }
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
        public override void Attack() {
            Console.WriteLine("SeaCommando attacking");
        }
    }
}
