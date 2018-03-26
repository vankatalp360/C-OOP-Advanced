using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;
        public FileAppender(ILayout layout, ErrorLevel level, ILogFile logFile) : base(layout, level)
        {
            this.logFile = logFile;
        }

        public override void Append(IError error)
        {
            base.Append(error);
            string formattedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formattedError);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {logFile.Size}";
        }
    }
}