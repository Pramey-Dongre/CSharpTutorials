using DiceBase;
using UserHere;

namespace Game;
public class GameInstance
{
    private int Tries { get; init; } = 3;
    public void Start()
    {
        Dice m = new Dice();
        User u = new User();
        int count = 0;
        while (count != Tries)
        {
            int userChoice = u.GetUserChoice();
            if (userChoice == -1)
            {
                continue;
            }
            else 
            if (userChoice == m.RolledDice)
            {
                Console.WriteLine("You Win");
                break;
            }
            else
            {
                Console.WriteLine("You Loose");
            }
            count++;
        }
        Console.WriteLine($"The Number was {m.RolledDice}");
        Console.WriteLine("=====GAME OVER=====");
    }
}