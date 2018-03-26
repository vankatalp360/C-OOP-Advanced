using System;
using _01.Loger.Models.Enums;

namespace _01.Loger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        ErrorLevel level { get; }
    }
}