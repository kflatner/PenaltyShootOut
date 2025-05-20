using PenaltyShootOut;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.Clear();
            var match = new PenaltyMatch();
            match.Start();
           

            Console.Write("\nVil du spille igjen? (J/N): ");
            string input = Console.ReadLine().Trim().ToUpper();

            while (input != "J" && input != "N")
            {
                Console.Write("Ugyldig valg. Skriv J for å spille igjen eller N for å avslutte: ");
                input = Console.ReadLine().Trim().ToUpper();
            }

            playAgain = input == "J";
            Console.Clear(); 
        }

        Console.WriteLine("Takk for at du spilte! ");
    }
}
