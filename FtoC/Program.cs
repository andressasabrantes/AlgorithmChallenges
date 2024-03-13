internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to input a Fahrenheit and output the equivalent temperature in Centigrade
        //Temperature can be converted from Fahrenheit to Centigrade using the following formula
        //F is the temperature in Fahrenheit and C the temperature in Centigrade: C = 5(F - 32) / 9

        Console.Write("Digite uma temperatura em Fahrenheit: ");
        double temperatureFahrenheit = double.Parse(Console.ReadLine());

        double temperatureCentigrade = (double)((5 * (temperatureFahrenheit - 32)) / 9);
        Console.WriteLine($"A temperatura em Centígrados é de {temperatureCentigrade:.##}");
    }
}