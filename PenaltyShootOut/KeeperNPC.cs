namespace PenaltyShootOut;

class KeeperNPC
{
    private static readonly Random Random = new Random();

    private readonly Dictionary<string, string> _directions = new Dictionary<string, string>
    {
        { "A", "Venstre" },
        { "S", "Ble stående" },
        { "D", "Høyre" }
    };

    public (string Key, string Label) ChooseDirection()
    {
        var keys = _directions.Keys.ToList();
        string chosenKey = keys[Random.Next(keys.Count)];
        string label = _directions[chosenKey];

        return (chosenKey, label);
    }
}
