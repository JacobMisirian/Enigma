using System;

namespace Enigma.Rotors
{
    public abstract class Rotor
    {
        public static string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYYZ";
        public abstract int Position { get; set; }
        public abstract string Letters { get; set; }

        public char Substitute(char c)
        {
            for (int i = 0; i < LETTERS.Length; i++)
                if (LETTERS[i] == c)
                    return Letters[mod((i - Position), 26)];
            throw new CharNotFoundException(this, c);
        }

        private int mod(int n, int m)
        {
            int r = n % m;
            return r < 0 ? r + m : r;
        }
    }
}

