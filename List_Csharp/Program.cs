using System;
using System.Collections.Generic;

namespace List_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListaMeses = new List<String>()
            {
             "Janeiro", 
              "Fevereiro", 
             "Março", 
             "Abril", 
              "Maio", 
              "Junho", 
              "Julho", 
              "Agosto", 
              "Setembro",
              "Outubro",
              "Novembro", 
            "Dezembro"
            };

            // ListaMeses.Add("Dezembro");

            //Console.WriteLine("Digite os meses do ano: ");

            //for (var i=1; i<=12; i++)
            //{
            //    ListaMeses.Add(Console.ReadLine());
            //}

            //for (var i = 1; i < ListaMeses.Count; i++)
            //{
            //    Console.WriteLine($"{ListaMeses[i]}");
            //}

            ListaMeses.Sort();

            foreach (var mes in ListaMeses)
            {
                Console.WriteLine($"{mes}");
            }


        }
    }
}
