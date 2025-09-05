class Program
{
    static void Main(string[] args)
    {
        //ask the user for their name.
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        //correct
        Console.WriteLine($"Your name is {firstname}, {lastname}.");
    }
}