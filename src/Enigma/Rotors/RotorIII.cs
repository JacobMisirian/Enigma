using System;

namespace Enigma.Rotors
{
    public class RotorIII: Rotor
    {
        public override string Letters { get; set; }
        public override int Position { get; set; }

        public RotorIII()
        {
            Letters = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            Position = 0;
        }
    }
}

