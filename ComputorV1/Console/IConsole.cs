﻿namespace ComputorV1.Console
{
    public interface IConsole
    {
        void Write(string s);
        void WriteLine(string s);
        int Read();
        string ReadLine();
    }
}