using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class Freeware : Software
    {
        public Freeware(string Name, string Developer) : base(Name, Developer)
        {
        }

        public override bool CheckIfCanUse()
        {
            return true;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name is {Name}. developer is {Developer}.");
        }
    }
}
