using System;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
            :base(layout, level)
        {
        }

        public override void Append(IError error)
        {
            base.Append(error);
            var formatedError = this.Layout.FormatError(error);
            Console.WriteLine(formatedError);
        }
    }
}