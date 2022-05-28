// See https://aka.ms/new-console-template for more information

namespace Module_2_project
{
    using hw8.Classes;
    using Hw8.Classes;
    using Module_2_project.Models.Classes;
    internal class Program
    {
        private static Employee[] company = new Employee[0];
        public static void Main(string[] args)
        {
            company = CreateACompany();

            CompanyInterface();
        }

        public static Employee[] CreateACompany()
        {
            Employee[] employees = new Employee[0];

            HireEmployees(ref employees, new Bookkeeper("Sanjey Kapur", new DateTime(1991, 1, 6), true, 2300.0, "bookkeeper"));
            HireEmployees(ref employees, new Security("Samasandaran Samalanbaman", new DateTime(1991, 1, 6), true, 1300.0, "security"));
            HireEmployees(ref employees, new Bookkeeper("Nikita Kornienko", new DateTime(1971, 7, 6), false, 2300.0, "bookkeeper"));
            HireEmployees(ref employees, new Lawyer("Aslan Maskhadov", new DateTime(1981, 3, 6), true, 3300.0, "lawyer"));
            HireEmployees(ref employees, new Security("Nina Grant", new DateTime(1991, 11, 4), true, 1300.0, "security"));
            HireEmployees(ref employees, new Bookkeeper("Andrey Organ", new DateTime(1989, 11, 7), true, 2300.0, "bookkeeper"));
            HireEmployees(ref employees, new Lawyer("Insane Cat", new DateTime(1991, 1, 6), true, 3300.0, "lawyer"));
            HireEmployees(ref employees, new Security("Princess Consuella Banannahammok", new DateTime(1969, 11, 1), false, 1300.0, "security"));
            HireEmployees(ref employees, new Bookkeeper("Stop This", new DateTime(1979, 11, 9), true, 2300.0, "bookkeeper"));
            HireEmployees(ref employees, new Lawyer("John Doe", new DateTime(1981, 11, 10), true, 3300.0, "lawyer"));
            HireEmployees(ref employees, new Security("Homer Simpson", new DateTime(1991, 3, 3), true, 1300.0, "security"));

            return employees;
        }
        public static int InteractionInterface()
        {
            int optionCounter = 4;
            Console.WriteLine(" Hi, let's create a Company");
            Console.WriteLine("\n");
            Console.WriteLine(" Let's look at our employees!");
            ListAllTheEmployees();
            Console.WriteLine("\n");
            Console.WriteLine(" Please choose what are going to do with them.");
            Console.WriteLine(" You can choose from: ");
            Console.WriteLine("\n");
            Console.WriteLine("1 - Sort by a parameter;");
            Console.WriteLine("\n");
            Console.WriteLine("2 - Find a person all multiple people by name;");
            Console.WriteLine("\n");
            Console.WriteLine("3 - Count each type of employee;");
            Console.WriteLine("\n");
            Console.WriteLine("4 - exit");
            string ingredientNumInput = Console.ReadLine();
            int n;
            bool isNumeric = int.TryParse(ingredientNumInput, out n);
            if(!isNumeric || n == 0 || n > optionCounter)
            {
                WrongInput();
            } 
            else
            {
                return n;
            }
            return 0;
        }
        public static void WrongInput()
        {
            Console.WriteLine("You've made a wrong input, please try again");
        }
        public static void CompanyInterface()
        {
            int option = InteractionInterface();
            if (option == 1)
            {
                Employee[] companyLocal = company.EmployeeSortingByType();
                CompanyInterface();
            }

            if (option == 2)
            {
                Console.WriteLine("Please enter the full name of the person");
                string? name = Console.ReadLine();
                if (name != null)
                {
                    Employee[] people = (Employee[])company.FindByName(name);

                    foreach (var person in people)
                    {
                        if (person != null)
                        {
                            Console.WriteLine(person.Name);
                        }
                        else
                        {
                            WrongInput();
                            CompanyInterface();
                        }
                    }
                }
                else
                {
                    WrongInput();
                    CompanyInterface();
                }
            }

            if (option == 3)
            {
                Console.WriteLine("Please enter the position of people in the company");
                string? job = Console.ReadLine();
                if (job != null)
                {
                    int numberOfPeopleByJob = company.EmployeeCountByJob(job);

                    Console.WriteLine($"There are {numberOfPeopleByJob} people of the {job} title in our company.");
                }
                else
                {
                    WrongInput();
                    CompanyInterface();
                }
            }

            if(option == 4)
            {
                return;
            }

            if (option == 0)
            {
                WrongInput();
                CompanyInterface();
            }
        }
        public static void ListAllTheEmployees()
        {
            foreach(Employee emp in company)
            {
                Console.WriteLine($"{emp.Name} - {emp.Type}");
            }
        }

        public static void HireEmployees(ref Employee[] ingredientTypes, Employee ingredientType)
        {
            ArrayPush(ref ingredientTypes, ingredientType);
        }
        public static void ArrayPush<T>(ref T[] table, object value)
        {
            Array.Resize(ref table, table.Length + 1); // Resizing the array for the cloned length (+-) (+1)
            table.SetValue(value, table.Length - 1); // Setting the value for the new element
        }
    }
}