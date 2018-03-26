using _01.Loger.Models.Enums;

namespace _01.Loger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ErrorLevel level { get; }
        void Append(IError error);
    }
}