using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_project.Models.Interfaces
{
    internal interface PersonInterface
    {
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        bool IsMarried { get; set; }
    }
}
