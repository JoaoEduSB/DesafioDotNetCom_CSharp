// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). 

using System;

class NotaConceito {

    static void Main (string[] args) {
        Console.WriteLine ("Vamos ler a nota de um aluno e converter para uma letra");

        Console.Write("Digite a nota do aluno: ");

        double notaAluno = Convert.ToDouble(Console.ReadLine());

            while ((notaAluno < 0) || (notaAluno > 10)) {
            Console.WriteLine("A nota digitada é inválida. Digite novamente: ");
            notaAluno = Convert.ToDouble(Console.ReadLine());
            }

            if (notaAluno < 3) {
                Console.WriteLine ("A nota do aluno é F (" + notaAluno + ").");
            }
            else if ((notaAluno >= 3) && (notaAluno < 5)) {
                Console.WriteLine ("A nota do aluno é D (" + notaAluno + ").");
            }
            else if ((notaAluno >= 5) && (notaAluno < 7)) {
                Console.WriteLine ("A nota do aluno é C (" + notaAluno + ").");
            }
            else if ((notaAluno >= 7) && (notaAluno <= 9)) {
                Console.WriteLine ("A nota do aluno é B (" + notaAluno + ").");
            }
            else {
                Console.WriteLine("A nota do aluno é A (" + notaAluno + ").");
            }
        }
    }