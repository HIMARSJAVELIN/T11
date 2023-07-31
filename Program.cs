namespace _016_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 7;

            Console.WriteLine("{0} + {1}", 5 > 6 && 6 < ++x, x);
            /*
            Console.WriteLine("Last name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Is {lastName} a Pensioner? y/n");
            bool isPensioner = Console.ReadLine().Contains("y");

            Console.WriteLine($"Is {lastName} attending bureau of unemployment? y/n");
            bool isUnemployed = Console.ReadLine().Contains("y");

            Console.WriteLine($"Is {lastName} employed? y/n");
            bool isEmployment = Console.ReadLine().Contains("y");

            bool subsidyAllowed = isPensioner ^ isUnemployed & !isEmployment;
            Console.WriteLine($"Subsidy is {subsidyAllowed}");
            */

            Console.WriteLine("Years of service: ");
            
            string yearsOfService = Console.ReadLine();
            int years = Convert.ToInt32(yearsOfService);

            bool q = years < 5;
            bool w = years >= 5 & years < 10;
            bool e = years >= 10 & years < 15;
            bool r = years >= 15 & years < 20;
            bool t = years >= 20 & years < 25;
            bool y = years >= 25;


            Console.WriteLine("The bonus is: " + "{0} {1}", 10, q);
            Console.WriteLine("The bonus is: " + "{0} {1}", 15, w);
            Console.WriteLine("The bonus is: " + "{0} {1}", 25, e);
            Console.WriteLine("The bonus is: " + "{0} {1}", 35, r);
            Console.WriteLine("The bonus is: " + "{0} {1}", 45, t);
            Console.WriteLine("The bonus is: " + "{0} {1}", 50, y);

        }
    }
}