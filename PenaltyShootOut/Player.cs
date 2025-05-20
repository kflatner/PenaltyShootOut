namespace PenaltyShootOut;

class Player
{
    public string ChooseDirection()
    {
        Console.Write("\nVelg skuddretning (A/S/D): ");
        string input = Console.ReadLine().ToUpper();

        while (input != "A" && input != "S" && input != "D")
        {
            Console.Write("Ugyldig valg. Bruk A, S eller D: ");
            input = Console.ReadLine().ToUpper();
        }

        return input;
    }
}
