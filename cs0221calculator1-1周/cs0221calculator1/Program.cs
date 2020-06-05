using System;

namespace cs0221calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls enter number 1");
            string num1 = Console.ReadLine();
            Console.WriteLine("pls enter number 2");
            string num2 = Console.ReadLine();
            Console.WriteLine("pls enter op");
            string op = Console.ReadLine();

            double answer = 0;

            switch (op)
            {
                case "+":
                    answer = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                    break;
                case "-":
                    answer = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                    break;
                case "*":
                    answer = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                    break;
                case "/":
                    answer = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                    break;
            }
            Console.WriteLine("the answer is:");
            Console.WriteLine(Convert.ToString(answer));

        }
    }
    
}
