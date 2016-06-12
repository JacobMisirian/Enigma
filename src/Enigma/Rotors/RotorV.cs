using System;

namespace Enigma.Rotors
{
    public class RotorV: Rotor
    {
        public override string Letters { get; set; }
        public override int Position { get; set; }

        public RotorV()
        {
            Letters = "VZBRGITYUPSDNHLXAWMJQOFECK";
            Position = 0;
        }
    }
}

