using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Statistics")
            {
                if (input.Contains("joined"))
                {
                    string username = input.Split(" ")[0];
                    if (!vloggers.ContainsKey(username))
                    {
                        vloggers.Add(username, new Dictionary<string, HashSet<string>>());
                        vloggers[username].Add("followings", new HashSet<string>());
                        vloggers[username].Add("followers", new HashSet<string>());
                    }
                }
                else if (input.Contains("followed"))
                {
                    string[] usernames = input.Split(" ");
                    string vlogger1 = usernames[0];
                    string vlogger2 = usernames[2];

                    if (!vloggers.ContainsKey(vlogger2) || !vloggers.ContainsKey(vlogger1) || vlogger2 == vlogger1)
                    {
                        continue;
                    }
                    vloggers[vlogger2]["followers"].Add(vlogger1);
                    vloggers[vlogger1]["followings"].Add(vlogger2);
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;

            var sortedVloggers = vloggers
                .OrderByDescending(f => f.Value["followers"].Count)
                .ThenBy(f => f.Value["followings"].Count)
                .ToDictionary(k=>k.Key,y=>y.Value);

            foreach (var (username,value) in sortedVloggers)
            {
                int followersCount = sortedVloggers[username]["followers"].Count;
                int followingsCount = sortedVloggers[username]["followings"].Count;
                Console.WriteLine($"{count}. {username} : {followersCount} followers, {followingsCount} following");

                if (count==1)
                {
                    foreach (var currentUsername in value["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {currentUsername}");
                    }
                }
                count++;
            }
        }
    }
}
