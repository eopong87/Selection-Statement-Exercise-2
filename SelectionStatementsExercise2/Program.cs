namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your favorite school subject?");
            var subject = Console.ReadLine();

            switch(subject)
            {
                case "Math":
                    Console.WriteLine("Math is my favorite also");
                    break;

                case "English":
                    Console.WriteLine("My least fav.");
                    break;
                case "Science":
                    Console.WriteLine("Nice");
                    break;

                case "History":
                    Console.WriteLine("Thats a good ne");
                    break;

                case "Language Arts":
                    Console.WriteLine("Great!!!!");
                    break;
                default:
                    Console.WriteLine($"I was never a fanofthat class!");
                    break;
            }
        }
    }
}