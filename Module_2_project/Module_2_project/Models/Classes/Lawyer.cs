using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_project.Models.Classes
{
    internal class Lawyer : Employee
    {
        public Lawyer(string name, DateTime dateOfBirth, bool isMarried, double salary, string type)
            : base(name, dateOfBirth, isMarried, salary, type)
        {
        }

        public override void DoesJob()
        {
            Console.WriteLine("Defend people at court");
        }
    }
}
