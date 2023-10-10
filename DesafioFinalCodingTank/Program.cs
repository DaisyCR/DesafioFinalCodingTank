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
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Insira um valor: ");
            if(int.TryParse(Console.ReadLine(), out int input)){
                //TODO refactor
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
                Console.WriteLine("\nERROR: Insira um número!");
                i--;
            }
            
           
        }
        Console.WriteLine($"Número de valores pares: {evenTotal}\n" +
                          $"Número de valores ímpares: {oddTotal}\n" +
                          $"Número de valores negativos: {negativeTotal}\n" +
                          $"Número de valores positivos: {positiveTotal}");
    }
    static void Question2(){}
    static void Question3(){}
    static void Question4(){}
    static void Question5(){}
    
}