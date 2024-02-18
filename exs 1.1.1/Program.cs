using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] prices = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int entryPoint = int.Parse(Console.ReadLine());
        string itemType = Console.ReadLine();

        int leftDamage = 0;
        int rightDamage = 0;

        // Calculate left damage
        for (int i = entryPoint - 1; i >= 0; i--)
        {
            if (itemType == "cheap" && prices[i] < prices[entryPoint])
            {
                leftDamage += prices[i];
            }
            else if (itemType == "expensive" && prices[i] >= prices[entryPoint])
            {
                leftDamage += prices[i];
            }
        }

        // Calculate right damage
        for (int i = entryPoint + 1; i < prices.Length; i++)
        {
            if (itemType == "cheap" && prices[i] < prices[entryPoint])
            {
                rightDamage += prices[i];
            }
            else if (itemType == "expensive" && prices[i] >= prices[entryPoint])
            {
                rightDamage += prices[i];
            }
        }

        // Determine which side has higher damage
        string position;
        int sum;
        if (leftDamage >= rightDamage)
        {
            position = "Left";
            sum = leftDamage;
        }
        else
        {
            position = "Right";
            sum = rightDamage;
        }

        Console.WriteLine($"{position} - {sum}");
    }
}

