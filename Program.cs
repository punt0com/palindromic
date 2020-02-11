using System;

namespace palindromic
{
    class Program
    {
        static void Main(string[] args)
        {

            // This was originally made to know the highest polindrome number possible. 
            int numero = 0;
            for (int i = 900; i < 1000; i++)
            {
                for (int j = 901; j < 1000; j++)
                {
                    numero = i * j;
                    if (isPalondromic(numero) == true)
                    {
                        Console.WriteLine("i: " + i + " , " + "j: " + j);
                        Console.WriteLine(numero);
                    }
                }
            }
            //Console.WriteLine(isPalondromic(1001001));
            Console.WriteLine("Has llegado al final");
            Console.ReadLine();
        }
        public static bool isPalondromic(int numero)
        {
            char[] numeroString = numero.ToString().ToCharArray();
            int longitudInversa = numeroString.Length - 1;

                for (int i = 0; i < numeroString.Length; i++)
                {
                    if (numeroString[i] != numeroString[longitudInversa])
                        return false;
                    longitudInversa--;
                }
                return true;
            
            
        }
    }
}
