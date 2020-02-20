
using System;

namespace Array_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInteiros = new int[3];

            arrayInteiros[0] = 10;
            arrayInteiros[1] = 55;
            arrayInteiros[2] = 78;

            Console.WriteLine($"{0} {1} {2}", arrayInteiros);

            for(var i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine($"Número: {arrayInteiros[i]}");
            }

            foreach(var valor in arrayInteiros)
            {
                Console.WriteLine($"Número: {valor}");
            }
        }
    }
}
