public class PrintCharsText
{
    // Converte para elemento de visualização os pontos de código unicode UTF-16.
    public void grava(Char[] char1)
    {
        StreamWriter sw = new StreamWriter("chars1.txt");        
        string strng = new String(char1);
        sw.WriteLine(strng);
        sw.Close();                    
    }
}