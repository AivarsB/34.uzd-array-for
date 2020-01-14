using System;

namespace _34.uzd_array_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
// Definēt int tipa masīvu, kurā būs 10 elementi. 
// Izveidot for ciklu, kurš aizpildīs šo masīvu ar skaitļiem. Masīvā ir jāieraksta for cikla mainīgā vērtība.