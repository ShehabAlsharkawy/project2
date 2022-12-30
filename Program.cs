namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0, secondnumber = 0;
            bool isPrime = true;

            Console.WriteLine("Enter the lower bound first number:");
            firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound second number:");
            secondnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", firstnumber, secondnumber);

            for (int i = firstnumber; i <= secondnumber; i++)
            {
                isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
        
    
