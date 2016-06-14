using System;

namespace Enigma.Rotors
{
    /// <summary>
    /// Char not found exception.
    /// </summary>
    public class CharNotFoundException : Exception
    {
        /// <summary>
        /// Gets the rotor.
        /// </summary>
        /// <value>The rotor.</value>
        public Rotor Rotor { get; private set; }
        /// <summary>
        /// Gets the char.
        /// </summary>
        /// <value>The char.</value>
        public char Char { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Enigma.Rotors.CharNotFoundException"/> class.
        /// </summary>
        /// <param name="rotor">Rotor.</param>
        /// <param name="c">C.</param>
        public CharNotFoundException(Rotor rotor, char c)
        {
            Rotor = rotor;
            Char = c;
        }
    }
}

