namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My games");
            Console.WriteLine();
            List<string> games = new List<string>
            {
                "Devil May Cry",
                "Call Of Duty",
                "Apex",
                "Star Wars"
            };

            var listGames = games.OrderBy(game => game.Length);
            
            foreach( var myGames in listGames)
            {
                Console.WriteLine(myGames);
            }
        }
    }
}
