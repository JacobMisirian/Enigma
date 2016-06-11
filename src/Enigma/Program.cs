using System;

namespace Enigma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EnigmaMachine machine = new EnigmaMachine(3, 8, 24);

            while (true)
                Console.WriteLine(machine.ProcessString(Console.ReadLine()));
        }
    }
}
