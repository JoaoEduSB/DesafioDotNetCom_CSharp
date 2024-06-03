// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 9)Escreva um programa que leia o código de um produto e informe a sua categoria: 
// 1 a 10: Alimento não-perecível 
// 11 a 20: Alimento perecível 
// 21 a 30: Vestuário 
// 31 a 40: Eletrônicos 
// Outros: Código inválido 

using System;

class CodigoDoProduto {
    static void Main(string[] args) {
        Console.WriteLine("Vamos verificar a categoria do produto de acordo com o seu código");

        Console.Write("Digite um número de 1 a 40:");

        int codigo = Convert.ToInt32(Console.ReadLine());

            while ((codigo < 0) || (codigo > 40)) {
                Console.WriteLine("O produto procurado pelo código digitado não existe.");
                Console.Write("Digite novamente o código: ");
                codigo = Convert.ToInt32(Console.ReadLine());
            }

            if ((codigo >= 1) && (codigo <= 10)) {
                Console.WriteLine("O Produto é um alimento não-perecível.");
            }
            else if ((codigo >= 11) && (codigo <= 20)) {
                Console.WriteLine("O Produto é um alimento perecível.");
            }
            else if ((codigo >= 21) && (codigo <= 30)) {
                Console.WriteLine("O Produto é um vestuário.");
            }
            else if ((codigo >= 31) && (codigo <= 40)) {
                Console.WriteLine("O Produto é um eletrônico.");
            }
        }
    }
