// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 10) Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente. 

using System;

class Operacao {
    static void Main(string[] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos fazer uma operação matemática, basta digitar o primeiro número, \n" + 
        "selecionar o operador e digitar o segundo número, então terá o resultado.");

        Console.WriteLine("");

        Console.WriteLine("Os operadores são: \n" +
        "+ (soma) \n" +
        "- (subtração) \n" +
        "/ (divisão) \n" +
        "x (multiplicação)");

        Console.WriteLine("");

        Console.Write("Digite o primeiro valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador matemático: ");
        string operador = (Console.ReadLine());
        
                while ((operador != "+") && (operador != "-") && (operador != "x") && (operador != "/")) {
                Console.Write("Operador inválido, digite novamente: ");
                operador = (Console.ReadLine());
            }

        Console.Write("Digite o segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        if (operador == "+") {
            Console.Write($"{valor1} + {valor2} = {valor1 + valor2}");
        }
            else if (operador == "-") {
                Console.Write($"{valor1} - {valor2} = {valor1 - valor2}");
            }

            else if (operador == "x") {
                Console.Write($"{valor1} x {valor2} = {valor1 * valor2}");
            }

            else if (operador == "/") {
                Console.Write($"{valor1} / {valor2} = {valor1 / valor2}");
            }

        Console.WriteLine("");
        }
    }
