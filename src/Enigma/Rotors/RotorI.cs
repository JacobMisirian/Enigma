using System;

namespace Enigma.Rotors
{
    public class RotorI: Rotor
    {
        public override string Letters { get; set; }
        public override int Position { get; set; }

        public RotorI()
        {
            Letters = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            Position = 0;
        }
    }
}

