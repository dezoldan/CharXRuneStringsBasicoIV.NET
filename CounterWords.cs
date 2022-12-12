class CounterWords
{
    public void ContaPalavras(string s1)
    {
        int nWords = 0;
        s1 = s1.Trim();      
        for (int ctr = 0; ctr < s1.Length; ctr++) {
        if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
            nWords++;              
        }
        Console.WriteLine("A frase contém {1} palavras.", s1, nWords);
    }
}