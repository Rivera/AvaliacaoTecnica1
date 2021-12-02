using System;

namespace AvaliacaoTecnica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int div;
            int result = 9;

            do
            {
                div = 0;
                result++;
                for (i = 1; i <= 10; i++)
                {
                    if (result % i == 0)
                    {
                        div++;

                    }
                }

            }
            while (div != 10);

            Console.WriteLine("Menor número divisível por 1 a 20 = " + result);

            Console.ReadLine();
        }
    }
}
