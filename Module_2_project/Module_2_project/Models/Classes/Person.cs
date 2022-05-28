

namespace Module_2_project.Models.Classes
{
    using Module_2_project.Models.Interfaces;
    using System;

    internal class Person : PersonInterface
    {
        private string name = "John Doe";
        private DateTime dateOfBirth;
        private bool isMarried;

        public Person(string name, DateTime dateOfBirth, bool isMarried)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            IsMarried = isMarried;
        }

        public string Name { get => this.name; set => this.name = value; }
        public DateTime DateOfBirth { get => this.dateOfBirth; set => this.dateOfBirth = value; }
        public bool IsMarried { get => this.isMarried; set => this.isMarried = value; }
    }
}
