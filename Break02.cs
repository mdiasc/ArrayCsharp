using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTeste
{
    internal class Break02
    {
        public static void Main(string[] args)
        {
            for (int i = 10; i < 20; i++)
            {
                if (i == 16)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
