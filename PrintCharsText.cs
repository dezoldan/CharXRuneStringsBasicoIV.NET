public class PrintCharsText
{
    // Converte para elemento de exibição os pontos de código unicode UTF-16.
    public static void grava(Char[] char1)
    {
        StreamWriter sw = new("chars1.txt");        
        string strng = new String(char1);
        sw.WriteLine(strng);
        sw.Close();                    
    }
}