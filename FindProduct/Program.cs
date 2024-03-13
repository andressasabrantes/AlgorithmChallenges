internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to read in two numbers and print their product

        Console.Write("Digite um número: ");
        int primeiroNumero = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int segundoNumero = int.Parse(Console.ReadLine());

        int produto = (primeiroNumero * segundoNumero);

        Console.WriteLine($"o produto dos números {primeiroNumero} e {segundoNumero} é: {produto}");
    }
}