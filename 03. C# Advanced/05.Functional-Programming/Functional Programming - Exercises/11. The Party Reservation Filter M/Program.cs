using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split()
                .ToArray();
            var filter = string.Empty;

            var filters = new List<string>();

            while ((filter = Console.ReadLine()) != "Print")
            {
                var token = filter
                    .Split(';')
                    .ToList();
                var command = token[1];
                var param = token[2];

                if (token[0] == "Add filter" && !filters.Contains($"{command};{param}"))
                {
                    filters.Add($"{command};{param}");
                }
                else if (token[0] == "Remove filter")
                {
                    filters.Remove($"{command};{param}");
                }
            }

            Func<string, string, bool> startsWithFilter = (name, param) => name.StartsWith(param);
            Func<string, string, bool> endWithFilter = (name, param) => name.EndsWith(param);
            Func<string, int, bool> lengthFilter = (name, param) => name.Length == param;
            Func<string, string, bool> containsFilter = (name, param) => name.Contains(param);

            foreach (var currentFilter in filters)
            {
                var action = currentFilter
                    .Split(';')[0];
                var param = currentFilter
                    .Split(';')[1];
                if (action == "Starts with")
                {
                    names = names.Where(name => !startsWithFilter(name, param)).ToArray();
                }
                else if (action == "Ends with")
                {
                    names = names.Where(name => !endWithFilter(name, param)).ToArray();

                }
                else if (action == "Length")
                {
                    names = names.Where(name => !lengthFilter(name, int.Parse(param))).ToArray();
                }
                else if (action == "Contains")
                {
                    names = names.Where(name => !containsFilter(name, param)).ToArray();
                }
            }

            Console.WriteLine(string.Join(" ",names));
        }
    }
}
