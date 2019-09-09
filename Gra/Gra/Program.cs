using System;

class Program
{
    static void Main(string[] args)
    {
        // imiona graczy
        string player1, player2;
        // gra zakończona (true) czy nie (false)
        bool Done = false;
        // liczba podana przez użytkownika
        int Number;

        Console.Write("Podaj imię gracza nr 1:  ");
        player1 = Console.ReadLine();

        Console.Write("Podaj imię gracza nr 2:  ");
        player2 = Console.ReadLine();

        // tworzenie nowej instancji klasy
        Random RandomObj = new Random();

        // wylosowanie liczby z zakresu 0-999
        int X = RandomObj.Next(1000);

        // zmienna przechowuje imię gracza, który wykonuje „ruch”
        string player = player1;

        while (!Done)
        {
            // zamiana graczy
            player = player == player1 ? player2 : player1;

            Console.WriteLine(player + ", strzelaj!");
            // należy przekonwertować tekst na liczbę
            Number = Convert.ToInt32(Console.ReadLine());

            if (X > Number)
            {
                Console.WriteLine("Strzelaj wyżej!");
            }
            else if (X < Number)
            {
                Console.WriteLine("Strzelaj niżej!");
            }
            else
            {
                Console.WriteLine("Gratulacje! Wygrał gracz " + player);
                Console.Beep();

                Done = true;
            }
        }
        Console.Read();
    }
}
