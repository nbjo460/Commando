using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class AirCommando : Commando
    {
        public AirCommando(string _name, string _codeName, string[] _tools) : base(_name, _codeName, _tools)
        {
        }
        public void Parachut()
        {
            Console.WriteLine("parachuting");
        }
        public override void Attack()
        {
            Console.WriteLine("AirCommando attacking");
        }
    }
}
