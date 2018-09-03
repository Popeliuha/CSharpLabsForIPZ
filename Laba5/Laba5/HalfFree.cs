using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class HalfFree : Software
    {
        public DateTime DateOfInstalation { get; set;  }
        public int TimeToUse { get; set; }
        public HalfFree(string Name, string Developer, DateTime DateOfInstalation, int TimeToUse) : base(Name, Developer)
        {
            this.DateOfInstalation = DateOfInstalation;
            this.TimeToUse = TimeToUse;
        }

        public override bool CheckIfCanUse(DateTime current)
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
