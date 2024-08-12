namespace DiceBase;
public class Dice
{
    public int RolledDice { get; init; }
    private const int SidesCount = 6;

    public Dice()
    {
        Random random = new Random();
        RolledDice = random.Next(1, SidesCount+1);
    }
    public void Describe() => Console.WriteLine($"Dice with {SidesCount} sides");
}