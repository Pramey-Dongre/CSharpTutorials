namespace Polymorphism.Extesnions
{
    public static class StringExtension
    {
        public static int CountLines(this string input) =>
            input.Split(Environment.NewLine).Count();

        public static void PrintStrings(this string input)
        {
            int i = 1;
            foreach (string s in input.Split(Environment.NewLine)) 
            {
                Console.WriteLine(i + "."+ s);
                i++;
            }
        }
    }
}
