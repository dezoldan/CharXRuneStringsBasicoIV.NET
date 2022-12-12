public class PrintCategoria
{
    // Retorna a categoria de cada objeto Char presente na string.
    public void PrintChars3(string s)
    {
        foreach (var item in s)
        {
            Console.WriteLine("'{0}' : {1}", item, char.GetUnicodeCategory(item));
        }
    }
}