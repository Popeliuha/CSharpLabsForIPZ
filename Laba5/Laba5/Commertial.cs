using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    public class Commertial : Software
    {
        
        public Commertial(string Name, string Developer, DateTime DateOfInstalation, int TimeToUse) : base(Name, Developer)
        {
            this.DateOfInstalation = DateOfInstalation;
            this.TimeToUse = TimeToUse;
        }


        public override bool CheckIfCanUse()
        {
            if (DateOfInstalation.Year + TimeToUse <= DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name is {Name}. developer is {Developer}. Date of instalation is {DateOfInstalation} and time to use is {TimeToUse}.");
        }
    }
}
