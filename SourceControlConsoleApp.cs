using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class SourceControlConsoleApp
    {
        static void Main(string[] args)
        {
            string getName() {
                string name;
                Console.Write("Hey! What's your name? ");
                name = Console.ReadLine();

                return name;
            }

            string getAge() {
                string age;
                Console.Write("How old are you? ");
                age = Console.ReadLine();

                return age;
            }

            string userName = getName();
            Console.Write("Hello " + userName + ", that's a great name.");

            string userAge = getAge();
            if (Int32.Parse(userAge) >= 65) {
                Console.Write(userAge + "?! Wow, you're old.");
            }
        }
    }
}
