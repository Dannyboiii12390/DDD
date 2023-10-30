namespace Solution
{
    public class Program
    {
        static void Main(string[] args)
        {






            Menu menu = new Menu();
            menu.AddOption("Book Meeting");
            menu.AddOption("Enter Log");
            int choice = menu.GetChoice();
            Console.WriteLine(choice);








        }
    }
}