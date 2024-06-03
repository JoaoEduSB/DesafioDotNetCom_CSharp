// Exercícios de Lógica com C#
// Professor Jailson
// Data: 03/06/2024
// 15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 

// Abaixo do peso: IMC < 18.5 

// Peso normal: 18.5 <= IMC < 24.9 

// Sobrepeso: 25 <= IMC < 29.9 

// Obesidade grau I: 30 <= IMC < 34.9 

// Obesidade grau II: 35 <= IMC < 39.9 

// Obesidade grau III: IMC >= 40 

using System;

class Imc {
    static void Main(string[] args) {
        Console.WriteLine("");
        
        Console.WriteLine("Vamos calcular o IMC de uma pessoa");

        Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("");
        
        Console.WriteLine("OBS: Cuidado ao digitar a altura e o peso, utilizar vírgula para separar - , ");
        Console.Write("Digite a sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine()); 
        
        double imc = peso / (altura * altura); 

        if (imc < 18.5) {
            Console.WriteLine("Você está abaixo do peso\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        else if ((imc >= 18.5) && (imc < 24.9)) {
            Console.WriteLine("Você está com o peso ideal\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        else if ((imc >= 25) && (imc <= 29.9)) {
            Console.WriteLine("Você está com sobrepeso\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        else if ((imc <= 30) && (imc <= 34.9)) {
            Console.WriteLine("Você está com obesidade grau I\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        else if ((imc <= 35) && (imc <= 39.9)) {
            Console.WriteLine("Você está com obesidade grau II\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        else {
            Console.WriteLine("Você está com obesidade grau III\n" +
            "O seu IMC é: " + Math.Round(imc,2));
        }
        Console.WriteLine("");
    }
}