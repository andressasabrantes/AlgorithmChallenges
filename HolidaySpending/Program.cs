internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to calculate how much money is spent on holiday
        //ask the user what their starting budget is.
        //How much was spent on food.
        //How much was spent on trips.
        //How much was spent on presents.
        //How much is left?

        Console.WriteLine("Welcome to your budget manager! Follow the instructions bellow!");

        Console.Write("How much is your starting budget for this trip? ");
        int budget = int.Parse(Console.ReadLine());

        Console.Write("How much did you spend on food? ");
        int foodCosts = int.Parse(Console.ReadLine());

        Console.Write("How much did you spend on trips? ");
        int tripsCosts = int.Parse(Console.ReadLine());

        Console.Write("How much did you spend on presents? ");
        int presentsCosts = int.Parse(Console.ReadLine());

        double leftOfTheBudget = (double)budget - (foodCosts + presentsCosts + tripsCosts);

        Console.WriteLine($"The starting budget is {budget} and now you have left ${leftOfTheBudget}.");
    }
}