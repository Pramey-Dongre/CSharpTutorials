namespace UserHere;
public class User
{
    public int UserChoice { get; set; }

    public User()
    {

    }
    public int GetUserChoice()
    {
        Console.WriteLine("Enter Your Choice: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int userInput))
        {
            if (userInput > 6 || userInput < 1) {
                Console.WriteLine("Please Enter a number from 1 to 6");
                return -1;
            }
            else return userInput;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return -1;
        }
    }
}
