using System.Globalization;

namespace StringsBasico
{
    // Saber quantos caracteres unicode tem a string, ou seja, conta os elementos de exibição.
    public class CountChar
    {
        public static void ContaCaracteres(string s)
        {
            StringInfo si = new(s);
            Console.WriteLine($"=> A string contém: { si.LengthInTextElements} elementos de exibição, " +
                $"e o comprimento da string é: {s.Length}.");
        }
    }
}
