using System;

namespace Enigma.Rotors
{
    public class RotorIV: Rotor
    {
        public override string Letters { get; set; }
        public override int Position { get; set; }

        public RotorIV()
        {
            Letters = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            Position = 0;
        }
    }
}

