using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTeste
{
    internal class Continue02
    {
        public static void Main(string[] args)
        {
            for (int i = 10; i < 50; i++)
            {
                if (i == 21)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
