using System;

namespace _01.Loger.Models.Contracts
{
    public interface ILayout
    {
        string FormatError(IError error);
    }
}