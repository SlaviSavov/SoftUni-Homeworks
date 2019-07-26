using Logger.Factories;
using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger.Core
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        private Engine()
        {
            this.errorFactory = new ErrorFactory();
        }

        public Engine(ILogger logger)
            : this()
        {
            this.logger = logger;
        }

        public void Run()
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                var errorArg = command
                    .Split('|')
                    .ToArray();

                string level = errorArg[0];
                string date = errorArg[1];
                string message = errorArg[2];

                IError error;

                try
                {
                        error = this.errorFactory.GetError(date, level, message);
                     this.logger.Log(error);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Console.WriteLine(this.logger.ToString());
        }
    }
}
