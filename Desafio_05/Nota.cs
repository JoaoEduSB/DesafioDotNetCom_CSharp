// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 5) Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). 

using System;

class Notas {

    static void Main (string[] args) {
        Console.WriteLine("Vamos calcular a nota média de um aluno, serão digitadas 3 notas.");

        Console.Write("Digite a primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7) {
            Console.WriteLine("O aluno está aprovado, com média: " + Math.Round(media, 2));
        }
        else if (media >= 5) {
            Console.WriteLine("O aluno está de recuperação, com média: " + Math.Round(media, 2));
        }
        else {
            Console.WriteLine("O aluno está reprovado, com média: " + Math.Round(media, 2));
        }
    }
}