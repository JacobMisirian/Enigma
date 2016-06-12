using System;

namespace Enigma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EnigmaMachine machine = new EnigmaMachine(EnigmaMachine.RotorI, EnigmaMachine.RotorII, EnigmaMachine.RotorIII);
            machine.SetCode(1, 1, 1);
            while (true)
            {
                Console.WriteLine(machine.ToString());
                Console.WriteLine(machine.ProcessString(Console.ReadLine()));
            }
        }
    }
}
