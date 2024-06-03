// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. 

using System;

class PositivoNegativoOuZero{

static void Main (string[] args) {
    Console.WriteLine("Vamos validar se um número é positivo, negativo ou zero");
    Console.Write("Digite um número: ");

    double numero = Convert.ToDouble(Console.ReadLine());

    if (numero == 0) {
        Console.WriteLine("O número " + numero + " é igual a zero");
    }
    else if (numero < 0) {
        Console.WriteLine("O número " + numero + " é negativo");
    }
    else {
        Console.WriteLine("O número " + numero + " é positivo");
    }
}
}



