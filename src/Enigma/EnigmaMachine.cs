using System;
using System.Text;

using Enigma.Rotors;

namespace Enigma
{
    /// <summary>
    /// Enigma machine.
    /// </summary>
    public class EnigmaMachine
    {
        /// <summary>
        /// The rotor i.
        /// </summary>
        public static Rotor RotorI =    new RotorI();
        /// <summary>
        /// The rotor II.
        /// </summary>
        public static Rotor RotorII =   new RotorII();
        /// <summary>
        /// The rotor III.
        /// </summary>
        public static Rotor RotorIII =  new RotorIII();
        /// <summary>
        /// The rotor IV.
        /// </summary>
        public static Rotor RotorIV =   new RotorIV();
        /// <summary>
        /// The rotor V.
        /// </summary>
        public static Rotor RotorV =    new RotorV();
        /// <summary>
        /// Gets or sets the slow rotor.
        /// </summary>
        /// <value>The slow rotor.</value>
        public Rotor SlowRotor { get; set; }
        /// <summary>
        /// Gets or sets the medium rotor.
        /// </summary>
        /// <value>The medium rotor.</value>
        public Rotor MediumRotor { get; set; }
        /// <summary>
        /// Gets or sets the fast rotor.
        /// </summary>
        /// <value>The fast rotor.</value>
        public Rotor FastRotor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Enigma.EnigmaMachine"/> class.
        /// </summary>
        /// <param name="slow">Slow rotor.</param>
        /// <param name="medium">Medium rotor.</param>
        /// <param name="fast">Fast rotor.</param>
        public EnigmaMachine(Rotor slow, Rotor medium, Rotor fast)
        {
            SetRotors(slow, medium, fast);
        }
        /// <summary>
        /// Processes the char.
        /// </summary>
        /// <returns>The char.</returns>
        /// <param name="c">C.</param>
        public char ProcessChar(char c)
        {
            IncrementRotors();
            if (c > 96 && c < 123)
                c -= (char)32;
            else if (c < 65 || c > 91)
                return c;
            
            c = SlowRotor.Substitute(c);
            c = MediumRotor.Substitute(c);
            c = FastRotor.Substitute(c);
            c = MediumRotor.Substitute(c);
            c = SlowRotor.Substitute(c);

            return c;
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
        public void SetCode(int slow, int medium, int fast)
        {
            FastRotor.Position = fast;
            MediumRotor.Position = medium;
            SlowRotor.Position = slow;
        }
        /// <summary>
        /// Sets the rotors.
        /// </summary>
        /// <param name="slow">Slow.</param>
        /// <param name="medium">Medium.</param>
        /// <param name="fast">Fast.</param>
        public void SetRotors(Rotor slow, Rotor medium, Rotor fast)
        {
            SlowRotor = slow;
            MediumRotor = medium;
            FastRotor = fast;
        }
        /// <summary>
        /// Increments the rotors.
        /// </summary>
        public void IncrementRotors()
        {
            // The rotors are essentially a 3 digit, base 26 number
            // so when one number gets to 26, we must set it to 1 and
            // go onto the next number.
            if (FastRotor.Position == 26)
            {
                FastRotor.Position = 1;
                if (MediumRotor.Position == 26)
                {
                    MediumRotor.Position = 1;
                    if (SlowRotor.Position == 26)
                        SlowRotor.Position = 1;
                    else
                        SlowRotor.Position++;
                }
                else
                    MediumRotor.Position++;
            }
            else
                FastRotor.Position++;
        }
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents the current <see cref="Enigma.EnigmaMachine"/>.
        /// </summary>
        /// <returns>A <see cref="System.String"/> that represents the current <see cref="Enigma.EnigmaMachine"/>.</returns>
        public override string ToString()
        {
            return string.Format("| {0} | {1} | {2} |", SlowRotor.Position, MediumRotor.Position, FastRotor.Position);
        }
    }
}