using System;

class Program
{
    static void Main()
    {
        int cost = 0;
        while (cost < 1 || cost > 9999)
        {
            Console.Write("Введите стоимость в копейках (1-9999): ");
            cost = int.Parse(Console.ReadLine());
        }
        String msg = Logic.Convertor(cost);
        Console.WriteLine(msg);
    }
}
public class Logic
{
    public static String Convertor(int cost)
    {
        if ((cost % 100) == 0) return (GetRubles(cost));

        else if ((cost / 100) == 0) return (GetKopecks(cost));

        else return (GetRubles(cost) + ", " + GetKopecks(cost));

    }
    public static String GetRubles (int cost)
    {
        if (cost / 100 >= 1)
        {
            if ((cost / 100) % 10 == 1 && (cost / 100) % 100 != 11) return $"{cost / 100} рубль";
            else if ((cost / 100) >= 2 && (cost / 100) <= 4 && ((cost / 100) % 10 < 10 || (cost / 100) % 100 >= 20)) return $"{cost / 100} рубля";
            else return $"{cost / 100} рублей";
        }
        else return "";
    }
    public static String GetKopecks (int cost)
    {
        if (cost % 100 >= 1)
        {
            if ((cost % 100) % 10 == 1 && (cost % 100) % 100 != 11)
            {
                return $"{cost % 100} копейка";
            }
            if ((cost % 100) >= 2 && (cost % 100) <= 4 && ((cost % 100) % 10 < 10 || (cost % 100) % 100 >= 20)) return $"{cost % 100} копейки";
            return $"{cost % 100} копеек";
        }
        else return "";
    }
}