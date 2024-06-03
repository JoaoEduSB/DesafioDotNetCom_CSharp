// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar. 

using System;

class ParOuImpar{

static void Main (string[] args){
    
    Console.WriteLine("Vamos Verificar se é par ou ímpar");
    Console.Write("Digite um número inteiro: ");

    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)  {
        Console.WriteLine("O número " + numero + " é par.");
    }
    else {
        Console.WriteLine("O número " + numero + " é impar.");
    }
} 
}