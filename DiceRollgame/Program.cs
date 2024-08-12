using DiceBase;
using Game;
using UserHere;
class Program
{
    static void Main()
    {
        GameInstance game = new GameInstance();
        Dice dice = new Dice();
        User user = new User();
        game.StartGame(dice,user);
    }
}

