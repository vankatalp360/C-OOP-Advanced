using System;
using System.Globalization;
using _01.Loger.Models.Contracts;

namespace _01.Loger.Models
{
    public class SimpleLayout : ILayout
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";
        private const string Format = "{0} - {1} - {2}";

        public string FormatError(IError error)
        {
            var errorDate = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            var formatedString = string.Format(Format, errorDate, error.level, error.Message);

            return formatedString;
        }
        
    }
}