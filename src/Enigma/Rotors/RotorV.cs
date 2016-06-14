using System;

namespace Enigma.Rotors
{
    /// <summary>
    /// Rotor V.
    /// </summary>
    public class RotorV: Rotor
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
        /// Initializes a new instance of the <see cref="Enigma.Rotors.RotorV"/> class.
        /// </summary>
        public RotorV()
        {
            Letters = "VZBRGITYUPSDNHLXAWMJQOFECK";
            Position = 0;
        }
    }
}

