using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTeste
{
    internal class Forech02
    {
        public static void Main(string[] args)
        {
            string[] mimi = {"Milena", "Linda", "Perfeita", "Inteligente", "Bem Sucedida", "Aura exala boas energias" };
            foreach (string contadora in mimi)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}
