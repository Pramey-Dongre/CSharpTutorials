using DiceBase;
using UserHere;

namespace Game;
public class GameInstance
{
    private int tries { get; init; } = 3;
    public void StartGame(Dice dice,User user)
    {
        Console.WriteLine("=====GAME BEGINS=====");
        int count = 0;
        while (count != tries)
        {
            int userChoice = user.GetUserChoice();
            if (userChoice == -1)
            {
                continue;
            }
            else 
            if (userChoice == dice.RolledDice)
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
        Console.WriteLine($"You have exhausted {tries} tries. The Number was {dice.RolledDice}");
        Console.WriteLine("=====GAME OVER=====");
    }
}