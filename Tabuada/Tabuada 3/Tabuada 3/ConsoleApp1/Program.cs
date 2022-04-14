using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desligar = "0";

            Console.WriteLine("Calculadora");

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Operador: ");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado: " + Somar(num1, num2));
                    break;

                case "-":
                    Console.WriteLine("Resultado: " + Subtrair(num1, num2));
                    break;

                case "*":
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;

                case "/":
                    Console.WriteLine("Resultado: " +Dividir(num1, num2));
                    break;

                default:
                    Console.WriteLine("Operador Invalido");
                    break;
            }
            Console.WriteLine("Digite 0 para encerrar: ");
            desligar = Console.ReadLine();

            if (desligar =="0")
            {
               
            }
        }

        public static string Somar(int num1, int num2)
        {
            return (num1 + num2).ToString();
        }
        public static string Subtrair(int num1, int num2)
        {
            return (num1 - num2).ToString();
        }
        public static string Multiplicar(int num1, int num2)
        {
            return (num1 * num2).ToString();
        }
        public static string Dividir(int num1, int num2)
        {
            if(valorDividendoMenorOuIgualQueZero(num2))
            { 
              return "Não é possível dividir por zero ou menor que zero";
             }     

             return (num1 / num2).ToString();

            bool valorDividendoMenorOuIgualQueZero(int num2)
            {
                if (num2 <= 0)
                {
                    return true;
                }
                return false;
            }

        
        }
            
            
    }
}
