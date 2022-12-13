using System.Globalization;
using System.Text;

namespace StringsBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            //🐂.
            string str = "🐂.\u0000";             
            PrintChars.Print(str);
            CountChar.ContaCaracteres(str);            
        }       
    }
}      