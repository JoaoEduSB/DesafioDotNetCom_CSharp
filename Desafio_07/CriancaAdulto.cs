// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). 

using System;

class CriancaAdulto {
    static void Main(string[] args) {
        Console.WriteLine("Vamos verificar se a pessoa é uma criança, adolescente, adulto ou idoso");

        Console.Write("Digite a idade da pessoa: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            while (idade < 0) {
                Console.Write("A idade digitada não é valida, digite novamente: ");
            idade = Convert.ToInt32(Console.ReadLine());
            }

                if ((idade == 0) || (idade < 13)) {
                    Console.WriteLine("A pessoa é uma criança.");
                }
                else if ((idade == 13) || (idade < 18)) {
                    Console.WriteLine("A pessoa é adolescente.");
                }
                else if ((idade == 18) || (idade < 60)) {
                    Console.WriteLine("A pessoa é adulta.");
                }
                else {
                    Console.WriteLine("A pessoa é idosa.");
                }
        }
    }