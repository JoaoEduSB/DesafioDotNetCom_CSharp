// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 13) Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: 

// Comum: Sem desconto 

// Associado: 10% de desconto 

// VIP: 20% de desconto 

// Informe o valor final da compra. 

using System;

class Compra {

    static void Main (string [] args) {
        Console.WriteLine("");
        
        Console.WriteLine("Vamos validar a categoria do cliente e o valor de sua compra");

        Console.WriteLine("Categorias Disponíveis: \n" +
                      "1 - Comum \n" +
                      "2 - Associado \n" +
                      "3 - VIP \n");

        Console.Write("Digite o valor da sua compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.Write("");

        Console.Write("Digite a sua categoria com um número inteiro: ");

        int categoria = Convert.ToInt32(Console.ReadLine());

        while ((categoria != 1) && (categoria != 2) && (categoria != 3)) {
            Console.Write("Categoria inválida. Digite novamente: ");
            categoria = Convert.ToInt32(Console.ReadLine());
        }

        if (categoria == 2) {

            valorCompra = valorCompra - (valorCompra * 0.1);
            Console.WriteLine("O valor da sua compra foi: R$" + valorCompra);
        }

        else if (categoria == 3) {

            valorCompra = valorCompra - (valorCompra * 0.2);
            Console.WriteLine("O valor da sua compra foi: R$" + valorCompra);
        }
        else {
            Console.WriteLine("O valor da sua compra foi: R$" + valorCompra);
        }
    }
}