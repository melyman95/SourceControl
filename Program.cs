using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string getName() {
                string name;
                Console.Write("Hey! What's your name? ");
                name = Console.ReadLine();

                return name;
            }
        }
    }
}
