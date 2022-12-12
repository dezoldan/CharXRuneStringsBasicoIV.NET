using System.Globalization;
using System.Text;

namespace StringsBasico
{
    class Program
    {
        static void Main(string[] args)
        {            
            string str = "Aprender sobre strings é muito legal."; //🐂\u0000dan123
            //Char[] char1 = new char[]{'\ud83d', '\udc02', };
            CounterWords contapalavras = new();
            PrintCategoria categoria = new();
            RuneExample runes = new();
            PrintChars x = new();     
            PrintCharsText s = new();
            //x.Print(str);
            //s.grava(char1);
            Console.WriteLine($"O número de letras é : {runes.CountLetters(str)}\n");
            //categoria.PrintChars3("A");
            contapalavras.ContaPalavras(str);
        }       
    }
}      