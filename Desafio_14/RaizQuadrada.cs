// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 14) Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado. 

using System;

class RaizQuadrada {
    static void Main (string [] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos ler um número, informar se ele é positivo ou negativo e tratar a sua condição");
        Console.WriteLine("Caso o número seja negativo, vamos calcular o quadrado do número, \n"+ 
        "caso seja positivo, a raiz quadrada.");

        Console.WriteLine("");

        Console.Write("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero == 0) {
            Console.WriteLine("O número" + numero + " é positivo");
        }
        else if (numero < 0) {
            double potencia = Math.Pow(numero, 2);
            Console.WriteLine("O número " + numero + " é negativo.");
            Console.Write("O quadrado do " + numero + " é: " + potencia);
        }
        else {
            double raizQuadrada = Math.Sqrt(numero);
            Console.WriteLine("O número " + numero + " é positivo.");
            Console.Write("A raiz quadrada de " + numero + " é: " + Math.Round(raizQuadrada,2));
        }

        Console.WriteLine("");
    }
}