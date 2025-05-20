namespace PenaltyShootOut;

class PenaltyMatch
{
    private int goals = 0;
    private int saves = 0;
    private int attempts = 0;
    private readonly int maxAttempts;
    private readonly Player player;
    private readonly KeeperNPC keeper;

    public PenaltyMatch(int maxAttempts = 5)
    {
        this.maxAttempts = maxAttempts;
        player = new Player();
        keeper = new KeeperNPC();
    }

    public void Start()
    {
        Console.WriteLine(" Velkommen til Straffeskyting!");
        Console.WriteLine("Gyldige skudd:\n- Venstre (A)\n- Midt i (S)\n- Høyre (D)");

        while (attempts < maxAttempts)
        {
            string playerShot = player.ChooseDirection();

            var (keeperKey, keeperLabel) = keeper.ChooseDirection();
            Console.WriteLine($"Keeper kaster seg til: {keeperLabel} ({keeperKey})");

            attempts++;

            if (playerShot != keeperKey)
            {
                goals++;
                Console.WriteLine(" Mål!");
            }
            else
            {
                saves++;
                Console.WriteLine(" Redning!");
            }

            Console.WriteLine($" Scoreboard: Du {goals} - {saves} Keeper");
        }

        EndMatch();
    }

    private void EndMatch()
    {
        Console.WriteLine("\n Kampen er over!");
        Console.WriteLine($" Sluttresultat: Du {goals} - {saves} Keeper");

        if (goals > saves)
        {
            Console.WriteLine(" Du vant!");
        }
        else if (goals < saves)
        {
            Console.WriteLine(" Keeper vant!");
        }
        else
        {
            Console.WriteLine(" Uavgjort!");
        }
    }
}
