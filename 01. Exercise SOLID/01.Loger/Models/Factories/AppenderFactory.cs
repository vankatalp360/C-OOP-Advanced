﻿using System;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models.Factories
{
    public class AppenderFactory
    {
        private const string DefaultFileName = "logFile{0}.txt";

        private LayoutFactory layoutFactory;
        private int fileNumber;

        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
            fileNumber = 0;
        }

        public IAppender CreateAppender(string appenderType, string levelString, string layoutType)
        {
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            ErrorLevel errorLevel = this.ParseErrorLevel(levelString);

            IAppender appender = null;

            switch (appenderType)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout, errorLevel);
                    break;
                case "FileAppender":
                    ILogFile logFile = new LogFile(string.Format(DefaultFileName, this.fileNumber));
                    appender = new FileAppender(layout, errorLevel, logFile);
                    break; 
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }

            return appender;
        }

        private ErrorLevel ParseErrorLevel(string levelString)
        {
            try
            {
                object level = Enum.Parse(typeof(ErrorLevel), levelString);
                return (ErrorLevel)level;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid ErrorLevel Type!");
            }
        }
    }
}