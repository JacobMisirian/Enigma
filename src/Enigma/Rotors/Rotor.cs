using System;
using System.Text;

namespace Enigma.Rotors
{
    /// <summary>
    /// Rotor.
    /// </summary>
    public abstract class Rotor
    {
        /// <summary>
        /// Alphabet.
        /// </summary>
        public static string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public abstract int Position { get; set; }
        /// <summary>
        /// Gets or sets the letters.
        /// </summary>
        /// <value>The letters.</value>
        public abstract string Letters { get; set; }
        /// <summary>
        /// Substitute the specified char.
        /// </summary>
        /// <param name="c">Char.</param>
        public char Substitute(char c)
        {
            if (!LETTERS.Contains(c.ToString()))
                throw new CharNotFoundException(this, c);
            return shiftStringRight(Letters, Position)[LETTERS.IndexOf(c)];
        }

        private string shiftStringLeft(string str, int amount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = amount; i < str.Length; i++)
                sb.Append(str[i]);
            for (int i = 0; i < amount; i++)
                sb.Append(str[i]);

            return sb.ToString();
        }

        private string shiftStringRight(string str, int amount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - amount; i < str.Length; i++)
                sb.Append(str[i]);
            for (int i = 0; i < str.Length - amount; i++)
                sb.Append(str[i]);
            return sb.ToString();
        }
    }
}