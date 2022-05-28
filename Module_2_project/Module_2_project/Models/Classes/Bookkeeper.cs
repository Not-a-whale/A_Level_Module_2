namespace Module_2_project.Models.Classes
{
    internal class Bookkeeper : Employee
    {
        public Bookkeeper(string name, DateTime dateOfBirth, bool isMarried, double salary, string type)
            : base(name, dateOfBirth, isMarried, salary, type)
        {
        }

        public override void DoesJob()
        {
            Console.WriteLine("I settle debit with credit");
        }
    }
}
