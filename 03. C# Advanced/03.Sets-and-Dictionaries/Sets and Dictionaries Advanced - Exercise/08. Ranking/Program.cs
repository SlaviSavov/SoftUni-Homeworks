using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                var tokens = input
                    .Split(':')
                    .ToArray();
                string contestsName = tokens[0];
                string pass = tokens[1];

                    contests.Add(contestsName, pass);
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var tokens = input
                   .Split("=>")
                   .ToArray();
                string contestsName = tokens[0];
                string pass = tokens[1];
                string username = tokens[2];
                int point = int.Parse(tokens[3]);

                if (!contests.ContainsKey(contestsName) || contests[contestsName] != pass)
                {
                    continue;
                }
                if (!submissions.ContainsKey(username))
                {
                    submissions.Add(username, new Dictionary<string, int>());
                }
                if (!submissions[username].ContainsKey(contestsName))
                {
                    submissions[username].Add(contestsName, 0);
                }
                if (submissions[username][contestsName] < point)
                {
                    submissions[username][contestsName] = point;
                }
            }

            var bestCandidate = submissions.OrderByDescending(v => v.Value.Values.Sum(x => x))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum(x=>x)} points.");
            Console.WriteLine("Ranking:");

            foreach (var (key,value) in submissions.OrderBy(x=>x.Key))
            {
                Console.WriteLine(key);
                 
                foreach (var (contestNames, points) in value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contestNames} -> {points}");
                }
            }
        }
    }
}
