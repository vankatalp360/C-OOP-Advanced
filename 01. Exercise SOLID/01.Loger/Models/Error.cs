using System;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models
{
    public class Error : IError
    {
        public DateTime DateTime { get; }
        public string Message { get; }
        public ErrorLevel level { get; }

        public Error(DateTime dateTime, string message, ErrorLevel level)
        {
            this.DateTime = dateTime;
            this.Message = message;
            this.level = level;
        }
    }
}