using System;
using System.Globalization;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models.Factories
{
    public class ErrorFactory
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";
        public IError CreateError(string levelString, string dateString, string message)
        {
            var dateTime = DateTime.ParseExact(dateString, DateFormat, CultureInfo.InvariantCulture);
            ErrorLevel errorLevel = this.ParseErrorLevel(levelString);
            var error = new Error(dateTime, message, errorLevel);
            return error;
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