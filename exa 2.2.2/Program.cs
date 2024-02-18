using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] friends = Console.ReadLine().Split(", ");
        List<string> friendsList = new List<string>(friends);

        int blacklistedCount = 0;
        int lostCount = 0;

        string command;
        while ((command = Console.ReadLine()) != "Report")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Blacklist":
                    string nameToBlacklist = tokens[1];
                    if (friendsList.Contains(nameToBlacklist))
                    {
                        friendsList[friendsList.IndexOf(nameToBlacklist)] = "Blacklisted";
                        Console.WriteLine($"{nameToBlacklist} was blacklisted.");
                        blacklistedCount++;
                    }
                    else
                    {
                        Console.WriteLine($"{nameToBlacklist} was not found.");
                    }
                    break;

                case "Error":
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < friendsList.Count && friendsList[index] != "Blacklisted" && friendsList[index] != "Lost")
                    {
                        string name = friendsList[index];
                        friendsList[index] = "Lost";
                        Console.WriteLine($"{name} was lost due to an error.");
                        lostCount++;
                    }
                    break;

                case "Change":
                    int changeIndex = int.Parse(tokens[1]);
                    string newName = tokens[2];
                    if (changeIndex >= 0 && changeIndex < friendsList.Count)
                    {
                        string oldName = friendsList[changeIndex];
                        friendsList[changeIndex] = newName;
                        Console.WriteLine($"{oldName} changed his username to {newName}.");
                    }
                    break;
            }
        }

        Console.WriteLine($"Blacklisted names: {blacklistedCount}");
        Console.WriteLine($"Lost names: {lostCount}");
        Console.WriteLine(string.Join(" ", friendsList));
    }
}
