
using System.Text;

public class RuneExample{
    // Retorna o conteúdo linguístico presente na string. (O número de caracteres).
    public int CountLetters(string s)
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