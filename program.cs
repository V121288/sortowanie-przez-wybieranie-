internal class Program
{
    private static void Main(string[] args)
    {
        int[] tablica = new int[10];
        Random random = new Random();
        
        for (int i = 0; i < tablica.Length; i++)
        {
            int randomowa = random.Next(1, 21);
            tablica[i] = randomowa;
        }
        foreach (int i in tablica)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < tablica.Length; i++)
        {
            int najmniejszaLiczba = i;
            for (int j = i + 1; j < tablica.Length; j++)
            {
                if (tablica[j] < tablica[najmniejszaLiczba])
                {
                    najmniejszaLiczba = j;
                }
            }
            if (najmniejszaLiczba != i) 
            {
                int tymczasowa = tablica[i];
                tablica[i] = tablica[najmniejszaLiczba];
                tablica[najmniejszaLiczba] = tymczasowa;
            }
        }
        foreach(int i in tablica)
        {
            Console.WriteLine(i);
        }
    }
}