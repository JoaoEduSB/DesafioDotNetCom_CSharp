// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 11) Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive). 

using System;

class Validacao {
    static void Main(string[] args) {
        Console.WriteLine("");

        Console.WriteLine("Vamos validar se um número está entre 10 e 20");

        Console.WriteLine("");
        
        Console.Write("Digite o número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if ((numero < 10) || (numero > 20)) {
            Console.WriteLine("O número " + numero + " não está entre 10 e 20");
        } 
        else {
            Console.WriteLine("O número " + numero + " está entre 10 e 20");
        }
    }
}