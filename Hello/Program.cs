using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for ( ; ; )
            {
                Greeting();
                Age();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long Maxlong = long.MaxValue;
            long Minlong = long.MinValue;
            double MinDouble = double.MaxValue;
            double MaxDouble = double.MaxValue;

            Console.WriteLine("max int = {0}\n min int = {1}\n max long = {2}\n min long = {3}\nmax double = {4}\nmin double = {5}", maxInt, minInt, Maxlong, Minlong, MinDouble, MaxDouble);
        }

        /// <summary>
        /// Ustaiwenia Console Tekst
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Petla ktora zadba o wiek
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");

            bool result = int.TryParse(Console.ReadLine(), out int age); // jawne przypisanie metodą parse ?

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Śmiało pij browara");
            }
            else if (result == false)
            {
                Console.WriteLine("Błąd ziomeczku ");
            }
            else
            {
                Console.WriteLine("Pij mleko stary");
            }
        }

        /// <summary>
        ///  Metoda wypisuje powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj Imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
