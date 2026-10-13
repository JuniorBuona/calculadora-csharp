using System;

namespace CalculadoraCSharp
{
    // Classe principal com as operações - Mostrando POO
    public class Calculadora
    {
        public double Somar(double a, double b) => a + b;
        public double Subtrair(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero!");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            bool continuar = true;

            Console.WriteLine("=== Calculadora C# - Marcelo Buonadio ===\n");

            while (continuar)
            {
                try
                {
                    Console.Write("Digite o 1º número: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a operação (+, -, *, /): ");
                    string op = Console.ReadLine();

                    Console.Write("Digite o 2º número: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    switch (op)
                    {
                        case "+": resultado = calc.Somar(n1, n2); break;
                        case "-": resultado = calc.Subtrair(n1, n2); break;
                        case "*": resultado = calc.Multiplicar(n1, n2); break;
                        case "/": resultado = calc.Dividir(n1, n2); break;
                        default: Console.WriteLine("Operação inválida!"); continue;
                    }

                    Console.WriteLine($"\nResultado: {n1} {op} {n2} = {resultado}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}\n");
                }

                Console.Write("Deseja fazer outro cálculo? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s";
                Console.WriteLine();
            }

            Console.WriteLine("Obrigado por usar a calculadora! 👋");
        }
    }
}
