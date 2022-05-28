namespace Module_2_project.Models.Classes
{
    internal class Employee : Person
    {
        private double salary;
        private string type;
        public Employee(string name, DateTime dateOfBirth, bool isMarried, double salary, string type)
            : base(name, dateOfBirth, isMarried)
        {
            this.Salary = salary;
            this.Type = type;
        }
        public double Salary { get; set; }
        public string Type { get; set; }
        virtual public void DoesJob()
        {
            Console.Write("Does his/her job");
        }
    }
}
