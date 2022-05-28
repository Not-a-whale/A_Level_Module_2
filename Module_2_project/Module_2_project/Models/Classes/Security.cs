using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_project.Models.Classes
{
    internal class Security : Employee
    {
        public Security(string name, DateTime dateTime, bool isMarried, double sallary, string type)
            : base(name, dateTime, isMarried, sallary, type)
        {
        }

        public override void DoesJob()
        {
            Console.WriteLine("I suppress any physical threats to the company");
        }
    }
}
