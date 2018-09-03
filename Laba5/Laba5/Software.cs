using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public abstract class Software
    {
        public string Name { get; set; }
        public string Developer { get; set; }
        public Software(string Name, string Developer)
        {
            this.Name = Name;
            this.Developer = Developer;
        }
        public abstract void ShowInfo();
        public abstract bool CheckIfCanUse(DateTime current);
    }
}
