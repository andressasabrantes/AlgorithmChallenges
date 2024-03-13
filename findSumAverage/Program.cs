internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to read in two numbers and print their sum and average

        Console.WriteLine("Digite um número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        int sum = numero1 + numero2;
        double average = (double)sum / 2;

        Console.WriteLine($"A soma dos números {numero1} e {numero2} é: {sum} e o average é: {average}");
    }
}