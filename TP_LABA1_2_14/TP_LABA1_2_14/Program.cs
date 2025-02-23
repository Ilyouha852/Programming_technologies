using System;

class Program
{
    static void Main()
    {
        int n = 0;

        while (n < 1)
        {
            Console.Write("Введите число n > 0: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите последовательность чисел через пробел:");
        int[] numbers = Console.ReadLine()
                               .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
        
        String msg = Logic.hasSameNeighbor(n, numbers);
        Console.WriteLine(msg);
    }
}

public class Logic
{
    public static String hasSameNeighbor(int n, int[] numbers)
    {
        bool found = false;
        int startIndex = -1;

        for (int i = 0; i < numbers.Length - n; i++)
        {
            bool group = true;
            for (int j = 1; j < n; j++)
            {
                if (numbers[i + j] != numbers[i])
                {
                    group = false;
                    break;
                } 
            }
            if (group)
            {
                found = true;
                startIndex = i;
                break;
            }
        }
        if (found)
        {
            return $"Найдены одинаковые соседние числа с {startIndex + 1}-й позиции по {startIndex + n}-ю";
        }
        else return "В последовательности нет одинаковых соседних чисел.";
    }
}
