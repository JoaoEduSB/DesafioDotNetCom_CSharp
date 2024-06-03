// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 6) Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 

using System;
 
    class Desafio6
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Escreva o Ano: ");
            int anoDigitado = Convert.ToInt32(Console.ReadLine());
 
            if (anoDigitado % 4 == 0) {
                if (anoDigitado % 100 != 0) {
                    Console.WriteLine("O ano digitado é bissexto.");
                } else if (anoDigitado % 400 == 0) {
                     Console.WriteLine("O ano digitado é bissexto.");
                } else {
                    Console.WriteLine("O ano digitado não é bissexto.");
                }
            } else {
                Console.WriteLine("O ano digitado não é bissexto.");
            }
        }
    }