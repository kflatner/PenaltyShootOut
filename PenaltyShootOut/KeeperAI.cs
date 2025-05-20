namespace PenaltyShootOut;

class KeeperAI
{
    private static readonly Random random = new Random();

    private readonly Dictionary<string, string> directions = new Dictionary<string, string>
    {
        { "A", "Venstre" },
        { "S", "Ble stående" },
        { "D", "Høyre" }
    };

    public (string Key, string Label) ChooseDirection()
    {
        var keys = directions.Keys.ToList();
        string chosenKey = keys[random.Next(keys.Count)];
        string label = directions[chosenKey];

        return (chosenKey, label);
    }
}
