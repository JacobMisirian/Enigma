using System;

namespace Enigma.Rotors
{
    /// <summary>
    /// Rotor II.
    /// </summary>
    public class RotorII: Rotor
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
        /// Initializes a new instance of the <see cref="Enigma.Rotors.RotorII"/> class.
        /// </summary>
        public RotorII()
        {
            Letters = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            Position = 0;
        }
    }
}

