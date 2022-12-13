using System.Text;

namespace StringsBasico
{
    public class CharXRune
    {
        // Saber quantas letras tem a string com Rune.
        public static void CountLetters(string s)
        {
            int letterCount = 0;
            foreach (Rune rune in s.EnumerateRunes())
            {
                if (Rune.IsLetter(rune))
                {
                    letterCount++;
                    Console.WriteLine($"Rune disse: A categoria unicode associada é: " +
                        $"{Rune.GetUnicodeCategory(rune)}");
                }
            }
            Console.WriteLine($"Rune disse: O número de letras da string é :{letterCount}");
        }

        // Saber quantas letras tem a string com Char.
        public static void CountLetter2(string s)
        {
            int letterCount2 = 0;
            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    letterCount2++;
                }
            }
            Console.WriteLine($"Char disse: O número de letras da string é: {letterCount2}");
        }
    }
}
