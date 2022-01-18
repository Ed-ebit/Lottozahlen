public class Lotto
{
    public static void Main()
    {
        Console.WriteLine("Willkommen zum Lottozahlengenerator mit Gewinn...wahrscheinlichkeit :D");
        Console.WriteLine("zum Zahlen generieren bitte 'j' eingeben, zum beenden 'x'.");
        string eingabe = Console.ReadLine();

        while (eingabe != "x")
        {
            if (eingabe == "j")
            {
                Random rnd = new Random();
                int[] guteZahlen = { 45, 13, 28, 21, 20, 8, 12, 15, 46, 14, 30, 34, 37, 23, 40, 29, 35, 10, 17, 39, 44, 5, 24, 48, 49 };
                int[] normaleZahlen = { 1, 2, 3, 4, 6, 7, 9, 11, 15, 16, 17, 18, 19, 22, 25, 26, 27, 31, 32, 33, 35, 36, 38, 41, 42, 43, 47, 49 };
                for (int i = 0; i < 4; i++)
                {
                    int guteNummer = rnd.Next(guteZahlen.Length);
                    Console.Write("{0,4}", guteZahlen[guteNummer]);
                }
                for (int i = 0; i < 2; i++)
                {
                    int normaleNummer = rnd.Next(normaleZahlen.Length);
                    Console.Write("{0,4}", normaleZahlen[normaleNummer]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("ungültige Eingabe");
            }
            eingabe = Console.ReadLine();
        }
    }
}
