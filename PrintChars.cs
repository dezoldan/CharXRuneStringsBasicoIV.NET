public class PrintChars
{
    // Exibe o comprimento da string, e;
    // Os pontos de código unicode UTF-16 que são os objetos do tipo Char.
    public static void Print(string s)
    {
        Console.WriteLine($"\"{s}\".Length = {s.Length}");
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"s[{i}] = '{s[i]}' ('\\u{(int)s[i]:x4}')");
        }
        Console.WriteLine();
    }
}