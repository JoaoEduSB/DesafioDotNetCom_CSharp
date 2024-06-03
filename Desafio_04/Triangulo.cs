// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 4) Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado.

using System;

class Triangulo {

static void Main (string[] args) {
    Console.WriteLine("Vamos verificar se um triângulo é válido ou não");
    
    Console.Write("Digite o valor do lado esquerdo triângulo: ");
    int ladoA = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor do lado direito do triângulo: ");
    int ladoB = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite o valor da base do triângulo: ");
    int ladoC = Convert.ToInt32(Console.ReadLine());

    if (((ladoA + ladoB) > ladoC)  && ((ladoB + ladoC) > ladoA) && ((ladoA + ladoC) > ladoB)) {
        Console.WriteLine("As medidas formam um triângulo.");
    }
    else {
        Console.WriteLine("As medidas não formam um triângulo.");
    }
}
}