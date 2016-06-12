using System;

namespace Enigma.Rotors
{
    public class RotorII: Rotor
    {
        public override string Letters { get; set; }
        public override int Position { get; set; }

        public RotorII()
        {
            Letters = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            Position = 0;
        }
    }
}

