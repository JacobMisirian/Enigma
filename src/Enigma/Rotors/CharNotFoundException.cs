using System;

namespace Enigma.Rotors
{
    public class CharNotFoundException : Exception
    {
        public Rotor Rotor { get; private set; }
        public char Char { get; private set; }

        public CharNotFoundException(Rotor rotor, char c)
        {
            Rotor = rotor;
            Char = c;
        }
    }
}

