using System;
namespace DesafioFinalCodingTank;

public class DesafioFinalCodingTank
{
    public static void Main()
    {
        List<string> questions = new List<string>()
        {
            "Questão 1",
            "Questão 2",
            "Questão 3",
            "Questão 4",
            "Questão 5",
        };
        foreach (var question in questions.Select((name, index) => (name, index)))
        {
            Console.WriteLine($"{question.index + 1} - {question.name}");
        }

        Console.Write("Escolha uma questão: ");
        int.TryParse(Console.ReadLine(), out int input);
        if (input < 1 || input > questions.Count)
        {
            Console.WriteLine($"ERROR: Insira um numero entre 1 e {questions.Count}");
            Main();
        }
        switch (input)
        {
            case 1:
                Question1();
                break;
            case 2:
                Question2();
                break;
            case 3:
                Question3();
                break;
            case 4:
                Question4();
                break;
            case 5:
                Question5();
                break;
            default:
                break;
        }
    }

    static void Question1()
    {
        int evenTotal = 0;
        int oddTotal = 0;
        int positiveTotal = 0;
        int negativeTotal = 0;
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Insira o {i}° valor: ");
            if(int.TryParse(Console.ReadLine(), out int input))
            {
                if (input % 2 == 0)
                {
                    evenTotal++;
                }
            
                if (input % 2 != 0)
                {
                    oddTotal++;
                }
                
                if (input < 0)
                {
                    negativeTotal++;
                }
            
                if (input > 0)
                {
                    positiveTotal++;
                }
            } else
            {
                Console.WriteLine("\nERROR: Insira um número válido!");
                i--;
            }
        }
        
        Console.WriteLine($"Número de valores pares: {evenTotal}\n" +
                          $"Número de valores ímpares: {oddTotal}\n" +
                          $"Número de valores negativos: {negativeTotal}\n" +
                          $"Número de valores positivos: {positiveTotal}");
    }

    static void Question2()
    {
        Console.Write($"Insira o 1° valor: ");
        int.TryParse(Console.ReadLine(), out int n1);
        
        Console.Write($"Insira o 2° valor: ");
        int.TryParse(Console.ReadLine(), out int n2);
        
        Console.WriteLine($"{n1} vezes {n2} é igual a {Multiply(n1, n2)}");
        Console.WriteLine($"{n1} dividido por {n2} é igual a {Divide(n1, n2)}");
        
        static int Multiply(int n1, int n2)
        {
            int mul = 0;
            for (int i = 1; i <= n2; i++)
            {
                mul += n1;
            }

            return mul;
        }

        static int Divide(int n1, int n2)
        {
            int div = n1;
            int i = 0;
            while (div - n2 > 0)
            {
                div -= n2;
                i++;
            }

            return i;
        }
    }

    static void Question3()
    {
        int uppercaseWords = 0;
        int lowercaseWords = 0;
        int firstLetterUpperWords = 0;
        int firstLetterLowerWords = 0;

        Console.Write("Escreva uma frase: ");
        var input = Console.ReadLine() == null ? "" : Console.ReadLine();
        if (input == null)
        {
            input = "";
        }
        string[] sentence = input.Split(" ");
        foreach (string word in sentence)
        {
            if (IsANumber(word))
            {
                continue;
            }
            
            string firstLetter = word.Substring(0, 1);
            if (word == word.ToUpper())
            {
                uppercaseWords++;
            }
            
            if (word == word.ToLower())
            {
                lowercaseWords++;
            }
            
            if (firstLetter == firstLetter.ToUpper())
            {
                firstLetterUpperWords++;
            }
            
            if (firstLetter == firstLetter.ToLower())
            {
                firstLetterLowerWords++;
            }
        }
        
        Console.WriteLine($"Palavras maiúsculas: {uppercaseWords}\n" +
                          $"Palavras minúsculas: {lowercaseWords}\n" +
                          $"Palavras que iniciam com letra maiúsculas: {firstLetterUpperWords}\n" +
                          $"Palavras que iniciam com letra minúsculas: {firstLetterLowerWords}\n");
        
        static bool IsANumber(string word)
        {
            return long.TryParse(word, out _) || double.TryParse(word, out _);
        }
    }

    static void Question4()
    {
        Console.WriteLine("Alternativa C)1");
        Console.WriteLine("Durante a conversão de um numero inteiro de 32 bits para um inteiro" +
                          " de 16 bits foi passada para a função Convert.ToInt16() uma condicional" +
                          " falsa que foi invertida para positivo pelo operador lógico !.\n" +
                          "Quando um valor booleano precisa ser representando em valores" +
                          " inteiros, o numero escolhido para valores positivos é o 1.");
       
    }

    static void Question5()
    {
        Console.WriteLine("Alternativa E) –5, –2, 1, 4, 7");
        Console.WriteLine("O programa é um for loop cuja variavel inicial i é igual a -5." +
                          " A condição para que o loop continue é de que o valor de i permaneça" +
                          " menor ou igual a 7, e após cada repetição o valor de i incrementará em 3." +
                          " O resultado do programa apresenta os valores de i durante o loop no" +
                          " terminal, com cada valor sendo escrito em linhas diferentes");
        
    }
    
}