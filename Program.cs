// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace  Moedas
{
    class Program{
        static void Main(string[] args){
            Console.Clear();

            decimal valor =10.25m;
           
            Console.WriteLine(valor.ToString(
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR"))
                ); 
               decimal valor2 = 10536.25m;

                Math.Round(valor2);
                Console.WriteLine(valor2);
                Math.Ceiling(valor2);
                 Console.WriteLine(valor2);
                 Math.Floor(valor2);
                 Console.WriteLine(valor2);


         }
    }
    
}
