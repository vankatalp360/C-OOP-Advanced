using System;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Factories;

namespace _01.Loger.Models.Core
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] args = input.Split('|');
                var level = args[0];
                var dateTime = args[1];
                var message = args[2];

                IError error = errorFactory.CreateError(level, dateTime, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger info");
            foreach (var appender in this.logger.Appenders)
            {
                Console.WriteLine();
                Console.WriteLine(appender);
            }
        }
    }
}