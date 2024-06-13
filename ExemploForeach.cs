using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTeste
{
    internal class ExemploForeach
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Jaguar", "Porshe" };
            foreach (string contadora in carro)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}
