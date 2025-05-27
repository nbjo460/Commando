using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Commando
    {
        public string name;
        public string codeName;
        public string[] tools = new string[5];
        public string status;

        public Commando(string _name, string _codeName, string[] _tools)
        {
            name = _name;
            codeName = _codeName;
            tools = _tools;
            status = "walk";
        }
        public void Walk()
        {
            Console.WriteLine("Walkilng");
        }
        public void Hide()
        {
            status = "hide";
            Console.WriteLine("Status Changed to Hide");
        }
        public void Attack()
        {
            Console.WriteLine("Code x is attacking");
        }

    }
}
