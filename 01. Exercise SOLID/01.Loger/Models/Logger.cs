using System;
using System.Collections.Generic;
using _01.Loger.Models.Contracts;

namespace _01.Loger.Models
{
    public class Logger : ILogger
    {
        private IEnumerable<IAppender> appenders;

        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>) this.appenders;

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if (appender.level <= error.level)
                {
                    appender.Append(error);
                }
            }
        }
    }
}