namespace Polymorphism.Extesnions
{
    public static class SeasonExtension
    {
        public static Season NextSeason( this Season season )
        {
            int seasonAsInt = (int)season;
            int nextSeason = (seasonAsInt + 1) % (Enum.GetValues(typeof(Season)).Length);
            return (Season)nextSeason;
        }
        public static List<int> TakeEverySecond(this List<int> input)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                res.Add(input[i]);
            }
            return res;
        }
    }
}
 