namespace DiceBase;
class Dice
{
    public int RolledDice { get; init; }

    public Dice()
    {
        Random random = new Random();
        RolledDice = random.Next(1, 7);
    }
}