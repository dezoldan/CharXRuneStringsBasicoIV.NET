namespace StringsBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "𐒻𐓟";
            PrintChars.Print(str);            
            CharXRune.CountLetters(str);
            CharXRune.CountLetter2(str);
        }       
    }
}      