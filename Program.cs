using System;


namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anontmous Income Comparison Program \n");
           
            Console.WriteLine("||Person 1:");
            Console.WriteLine("Please enter Hourly Rate");
            string hRate1 = Console.ReadLine();
            Int16 hRateNum1 = Int16.Parse(hRate1);

            Console.WriteLine("Please enter Hours Worked Per Week");
            string hWorked1 = Console.ReadLine();
            short hWorkedNum1= Int16.Parse(hWorked1);

            Console.WriteLine("\n");

            Console.WriteLine("||Person 2:");
            Console.WriteLine("Please enter Hourly Rate");
            string hRate2 = Console.ReadLine();
            Int16 hRateNum2 = Int16.Parse(hRate2);

            Console.WriteLine("Please enter Hours Worked Per Week");
            string hWorked2 = Console.ReadLine();
            short hWorkedNum2 = Int16.Parse(hWorked2);

            Console.WriteLine("Annual Salary of Person 1");
            int total1 = hWorkedNum1 * hRateNum1 * 52;
            Console.WriteLine(total1);

            Console.WriteLine("Annual Salary of Person 2");
            int total2 = hWorkedNum2 * hRateNum2 * 52;
            Console.WriteLine(total2);

            Console.WriteLine("\n");


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool payCompare = total1 > total2;
            Console.WriteLine(payCompare.ToString());
            Console.ReadLine();
        }
    }
}
