// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 12) Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número. 

using System;

class Dobro {
    static void Main(string[] args){
    Console.WriteLine("");

    Console.WriteLine("Vamos ler um número e validar se ele é maior que 100, caso não for, dobrar.");

    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 100) {
            Console.WriteLine($"Dobrando o número, temos: {numero * 2}");
        }
        else if (numero == 100){
        Console.WriteLine("O número " + numero + " é igual a 100.");
        }
        else {
            Console.WriteLine("O número " + numero + " é maior que 100.");
        }
    }
}