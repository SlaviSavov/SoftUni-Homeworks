using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_BorderControl.Core
{
    public class Engine
    {
        private List<string> birthdateCollection;
        public Engine()
        {
            birthdateCollection = new List<string>();
        }

        public void Run()
        {
            var command = string.Empty;
            while ((command = Console.ReadLine())!="End")
            {
                AddId(command);
            }

            string targetDate = Console.ReadLine();

            var output = new List<string>();

            foreach (var currentDate in birthdateCollection)
            {
                if (currentDate.EndsWith(targetDate))
                {
                    output.Add(currentDate);
                }
            }

            if (output.Count==0)
            {
                Console.WriteLine();
            }
            else
            {
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
        }
        private void AddId(string command)
        {
            var token = command
                .Split(' ')
                .ToArray();

            if (token[0]=="Pet"||token[0]=="Citizen")
            {
                var birthdate = token[token.Length - 1];

                birthdateCollection.Add( birthdate);

            }
        }
    }
}
