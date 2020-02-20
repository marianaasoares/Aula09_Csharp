using System;
using System.Collections.Generic;

namespace Dictionary_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedidos = new Dictionary<string, int>();

            pedidos.Add("Banana", 3);
            pedidos.Add("Mamão", 4);
            pedidos.Add("Lichia", 10);

            foreach(var pedido in pedidos)
            {
                Console.WriteLine($"Nome: {pedido.Key} - Quantidade: {pedido.Value}");
            }


        }
    }
}
