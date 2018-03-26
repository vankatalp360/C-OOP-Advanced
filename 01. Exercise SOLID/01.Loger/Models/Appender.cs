using System;
using _01.Loger.Models.Contracts;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models
{
    public abstract class Appender : IAppender
    {
        private int AppenderCounter;
        protected Appender(ILayout layout, ErrorLevel level)
        {
            Layout = layout;
            this.level = level;
            AppenderCounter = 0;
        }

        public ILayout Layout { get; }
        public ErrorLevel level { get; }

        public virtual void Append(IError error)
        {
            AppenderCounter++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {level}, Messages appended: {AppenderCounter}";
        }
    }
}