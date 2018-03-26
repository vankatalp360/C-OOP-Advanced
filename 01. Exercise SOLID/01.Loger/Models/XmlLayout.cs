using System;
using System.Globalization;
using _01.Loger.Models.Contracts;

namespace _01.Loger.Models
{
    public class XmlLayout : ILayout
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";
        private string Format = "<log>" + Environment.NewLine +
                                "   <date>{0}</date>" + Environment.NewLine + 
                                "   <level>{1}</level>" + Environment.NewLine +
                                "   <message>{2}</message>" + Environment.NewLine +
                                "</log>";

        public string FormatError(IError error)
        {
            var errorDate = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            var formatedString = string.Format(Format, errorDate, error.level, error.Message);

            return formatedString;
        }
    }
}