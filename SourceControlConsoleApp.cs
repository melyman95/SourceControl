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

            Console.Write("Hello " + userName + ", that's a great name. ");

            string userAge = getAge();
            if (Int32.Parse(userAge) >= 65) {
                Console.WriteLine(userAge + "?! Wow, you're old.");
                Console.WriteLine(" Here's as many smiley faces as you are old.");

                for (int i = 1; i < Int32.Parse(userAge); i++) {
                    makeSmiley();
                }

                Console.ReadKey();
            }

            if (Int32.Parse(userAge) <= 64 && Int32.Parse(userAge) >= 21) {
                Console.WriteLine(userAge + " huh? You're not very old or very young.");
                Console.WriteLine(" Here's as many smiley faces as you are old.");

                for (int i = 1; i < Int32.Parse(userAge); i++)
                {
                    makeSmiley();
                }
                Console.ReadKey();
            }

            if (Int32.Parse(userAge) <= 20) {
                Console.WriteLine(userAge + " ? Shouldn't you be in school or something?");
                Console.WriteLine(" Here's as many smiley faces as you are old.");

                for (int i = 1; i < Int32.Parse(userAge); i++)
                {
                    makeSmiley();
                }
                Console.ReadKey();
            }

            void makeSmiley() {
                Console.Write("☺ ");
            }
        }
    }
}
