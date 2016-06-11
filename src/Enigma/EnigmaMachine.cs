using System;
using System.Text;

namespace Enigma
{
    /// <summary>
    /// Enigma machine.
    /// </summary>
    public class EnigmaMachine
    {
        /// <summary>
        /// Gets or sets the slow rotor.
        /// </summary>
        /// <value>The slow rotor.</value>
        public uint SlowRotor { get; set; }
        /// <summary>
        /// Gets or sets the medium rotor.
        /// </summary>
        /// <value>The medium rotor.</value>
        public uint MediumRotor { get; set; }
        /// <summary>
        /// Gets or sets the fast rotor.
        /// </summary>
        /// <value>The fast rotor.</value>
        public uint FastRotor { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Enigma.EnigmaMachine"/> class.
        /// </summary>
        /// <param name="slow">Slow rotor.</param>
        /// <param name="medium">Medium rotor.</param>
        /// <param name="fast">Fast rotor.</param>
        public EnigmaMachine(uint slow, uint medium, uint fast)
        {
            SetCode(slow, medium, fast);
        }
        /// <summary>
        /// Calculates the seed.
        /// </summary>
        /// <returns>The seed.</returns>
        public uint CalculateSeed()
        {
            // Grab a snapshot of the rotors as unsigned (to prevent negatives).
            uint one = SlowRotor;
            uint two = MediumRotor;
            uint three = FastRotor;
            // Do math to obscure the numbers.
            one = (one ^ two) - three;
            two = (one + two) & three;
            three ^= one - two;

            return ((one * two) ^ three) % 26;
        }
        /// <summary>
        /// Processes the char.
        /// </summary>
        /// <returns>The char.</returns>
        /// <param name="c">C.</param>
        public char ProcessChar(char c)
        {
            // If we got a lowercase char, turn it uinto an uppercase.
            // If we got something that isn't a letter or at all, just
            // return it. The Enigma didn't process spaces or punctuation.
            if (c > 96 && c < 123)
                c -= (char)32;
            else if (c < 65 || c > 90)
                return (char)c;
            // Get the numerical value which is in range 65-90 on ASCII Table.
            int ch = c - 64;
            // Generate our seed within the bounds of 1-26.
            int seed = (int)CalculateSeed();
            // Calculate return value by subtracting a combo of our seed
            // and our character within the confines of 1-26 and add 64 to
            // bring it to an uppercase ASCII char.
            int ret = (26 - ((seed + ch) % 26)) + 64;
            IncrementRotors();

            return (char)ret;
        }
        /// <summary>
        /// Processes the string.
        /// </summary>
        /// <returns>The string.</returns>
        /// <param name="str">String.</param>
        public string ProcessString(string str)
        {
            StringBuilder sb = new StringBuilder();
            // Iterate through and process chars in str.
            foreach (char c in str)
                sb.Append(ProcessChar(c));
            return sb.ToString();
        }
        /// <summary>
        /// Sets the code.
        /// </summary>
        /// <param name="fast">Fast rotor.</param>
        /// <param name="medium">Medium rotor.</param>
        /// <param name="slow">Slow rotor.</param>
        public void SetCode(uint fast, uint medium, uint slow)
        {
            FastRotor = fast;
            MediumRotor = medium;
            SlowRotor = slow;
        }
        /// <summary>
        /// Increments the rotors.
        /// </summary>
        public void IncrementRotors()
        {
            // The rotors are essentially a 3 digit, base 26 number
            // so when one number gets to 26, we must set it to 1 and
            // go onto the next number.
            if (FastRotor == 26)
            {
                FastRotor = 1;
                MediumRotor++;
                if (MediumRotor == 26)
                {
                    MediumRotor = 1;
                    SlowRotor++;
                    if (SlowRotor == 26)
                        SlowRotor = 1;
                }
            }
            else
                FastRotor++;
        }
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="Enigma.EnigmaMachine"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="Enigma.EnigmaMachine"/>.</returns>
        public override string ToString()
        {
            return string.Format("| {0} | {1} | {2} |", SlowRotor, MediumRotor, FastRotor);
        }
    }
}