using System;

namespace Enigma.Rotors
{
    /// <summary>
    /// Rotor IV.
    /// </summary>
    public class RotorIV: Rotor
    {
        /// <summary>
        /// Gets or sets the letters.
        /// </summary>
        /// <value>The letters.</value>
        public override string Letters { get; set; }
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public override int Position { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Enigma.Rotors.RotorIV"/> class.
        /// </summary>
        public RotorIV()
        {
            Letters = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            Position = 0;
        }
    }
}

