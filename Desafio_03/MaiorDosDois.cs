// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 3) Escreva um programa que leia dois números inteiros e informe qual deles é o maior. 

using System;

class MaiorDosDois{

static void Main (string[] args) {
    Console.WriteLine("Vamos verificar qual dos dois números digitados é maior");

    Console.Write("Digite o primeiro número: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2) {
        Console.WriteLine("O número " + numero1 + " é maior do que o número " + numero2);
    }
    else {
        Console.WriteLine("O número " + numero2 + " é maior do que o número " + numero1);
    }
}
}