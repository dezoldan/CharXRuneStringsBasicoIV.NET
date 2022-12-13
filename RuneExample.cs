using System.Text;
namespace StringsBasico
{
    public class RuneExample
    {
        // Saber quantas letras tem a string.
        public static int CountLetters(string s)
        {
            int letterCount = 0;
            foreach (Rune rune in s.EnumerateRunes())
            {
                if (Rune.IsLetter(rune))
                { letterCount++; }
            }

            return letterCount;
        }
    }
}