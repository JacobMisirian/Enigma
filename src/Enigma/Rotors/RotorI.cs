using System;

namespace Enigma.Rotors
{
    /// <summary>
    /// Rotor I.
    /// </summary>
    public class RotorI: Rotor
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
        /// Initializes a new instance of the <see cref="Enigma.Rotors.RotorI"/> class.
        /// </summary>
        public RotorI()
        {
            Letters = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            Position = 0;
        }
    }
}

