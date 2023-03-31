using System;

namespace ProjetoSoloCalc
{
    class Program
    {
        static void Main()
        {
            decimal PrimeiroNum = 0;
            decimal SegundoNum = 0;
            string Operador;
            string Final = "A";
            decimal Valor;
            
            while(Final.ToUpper() != "#FIM")
                {
                     Console.WriteLine();
                        Console.WriteLine("Informe um número: ");
                        

                        if (decimal.TryParse(Console.ReadLine(), out decimal PrimeiroNumwk))
                        {
                            PrimeiroNum = PrimeiroNumwk;
                        }
                        else
                        {
                            throw new ArgumentException("O valor deve ser decimal");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Informe a operação: ");
                        Operador = Console.ReadLine()!;
                        if (Operador != "*" && Operador != "-" && Operador != "+" && Operador != "/")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite uma operação válida (* , + , - , /)"); 
                            break;
                        }
                        
                        Console.WriteLine();
                        Console.WriteLine("Informe outro número: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal SegundoNumwk))
                        {
                            SegundoNum = SegundoNumwk;
                        }
                        else
                        {
                            throw new ArgumentException("O valor deve ser decimal");
                        }

                        switch(Operador)

                        {
                                case "*":
                                    Valor = PrimeiroNum * SegundoNum;
                                    Console.WriteLine();
                                    Console.WriteLine($"Resultado da Multiplicação: {PrimeiroNum} * {SegundoNum} = {Valor}");
                                    Console.WriteLine();
                                    Console.WriteLine("Para finalizar digite #FIM ou para continuar clique no ENTER ");
                                
                                break;

                                case "+":
                                    Valor = PrimeiroNum + SegundoNum;
                                    Console.WriteLine();
                                    Console.WriteLine($"Resultado da Soma: {PrimeiroNum} + {SegundoNum} = {Valor}");
                                    Console.WriteLine();
                                    Console.WriteLine("Para finalizar digite #FIM ou para continuar clique no ENTER ");
                                
                                break;

                                case "-":
                                    Valor = PrimeiroNum - SegundoNum;
                                    Console.WriteLine();
                                    Console.WriteLine($"Resultado da Subtração: {PrimeiroNum} - {SegundoNum} = {Valor}");
                                    Console.WriteLine();
                                    Console.WriteLine("Para finalizar digite #FIM ou para continuar clique no ENTER ");
                                
                                break;

                                case "/":
                                    Valor = PrimeiroNum / SegundoNum;
                                    Console.WriteLine();
                                    Console.WriteLine($"Resultado da Subtração: {PrimeiroNum} / {SegundoNum} = {Valor}");
                                    Console.WriteLine();
                                    Console.WriteLine("Para finalizar digite #FIM ou para continuar clique no ENTER");
                                break;

                                default:
                                    throw new ArgumentOutOfRangeException();

                        }

                    Final = Console.ReadLine()!;
                }
            
        }
    }
}
           