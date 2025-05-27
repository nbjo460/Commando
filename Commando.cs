using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commando
{
    public class Commando
    {
        private string name;
        public string codeName { get; set; }
        private string[] tools = new string[5];
        private string status;

        public Commando(string _name, string _codeName, string[] _tools)
        {
            name = _name;
            codeName = _codeName;
            tools = _tools;
            status = "walk";
        }
        public void Walk()
        {
            status = "walk";
            Console.WriteLine(status);
        }
        public void Hide()
        {
            status = "hide";
            Console.WriteLine(status);
        }
        public void Attack()
        {
            Console.WriteLine("Code x is attacking");
        }
        public string SayName(string commanderRank) 
        {
            if(commanderRank == "GENERAL")
            {
                return name;
            }
            else if(commanderRank == "COLONEL")
            {
                return codeName;
            }
            else
            {
                return "classified";
            }
        }
         

    }
}
