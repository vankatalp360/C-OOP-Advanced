using System;
using System.Collections.Generic;
using _01.Loger.Models;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Core;
using _01.Loger.Models.Enums;
using _01.Loger.Models.Factories;

namespace _01.Loger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeLogger();
            ErrorFactory errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);

            engine.Run();
        }

        static ILogger InitializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);


            var appenderCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appenderCount; i++)
            {
                string[] args = Console.ReadLine().Split();
                var appenderType = args[0];
                var layoutType = args[1];
                var errorLevel = args.Length > 2 ? args[2] : "INFO";

                IAppender appender = appenderFactory.CreateAppender(appenderType, errorLevel, layoutType);
                appenders.Add(appender);
            }

            ILogger logger = new Logger(appenders);
            return logger;
        }
    }
}
