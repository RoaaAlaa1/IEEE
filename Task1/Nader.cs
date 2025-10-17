using System;

public class Presents
{
    public static float PresentsList(int budget, float bagVolume, int people, int Npresents, float[] presentVolume, float[] presentPrice)
    {
        float maxMoney = 0;

        int total = 1 << Npresents;

        for (int mask = 0; mask < total; mask++)
        {
            float totVol = 0f;
            float totPrice = 0f;
            int count = 0;

            for (int i = 0; i < Npresents; i++)
            {
                if ((mask & 1 << i) != 0)
                {
                    totPrice += presentPrice[i];
                    totVol += presentVolume[i];
                    count++;
                }
            }

            if (count > 0 && count % people == 0 && totPrice <= budget && totVol <= bagVolume)
            {
                if (totPrice > maxMoney)
                    maxMoney = totPrice;
            }
        }

        return maxMoney;

    }

    public static void Main()
    {

        Console.Write("Enter your budget: ");
        int budget = int.Parse(Console.ReadLine());

        Console.Write("Enter your Bag Volume: ");
        float bagVolume = float.Parse(Console.ReadLine());

        Console.Write("Enter the number of people: ");
        int people = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of presents (Max:12) : ");
        int Npresents = int.Parse(Console.ReadLine());

        float[] presentVolume = { 4.53f, 9.11f, 4.53f, 6.00f, 1.04f, 0.87f, 2.57f, 19.45f, 65.59f, 14.14f, 16.66f, 13.53f };
        float[] presentPrice = { 12.23f, 45.03f, 12.23f, 32.93f, 6.99f, 0.46f, 7.34f, 65.98f, 152.13f, 7.23f, 10.00f, 25.25f };

        float result = PresentsList(budget, bagVolume, people, Npresents, presentVolume, presentPrice);
        Console.WriteLine("Max money spent: " + result);
    }
}
