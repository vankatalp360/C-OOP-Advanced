﻿namespace _01.Loger.Models.Contracts
{
    public interface ILogFile
    {
        string Path { get; }
        int Size { get; }

        void WriteToFile(string errorLog);
    }
}