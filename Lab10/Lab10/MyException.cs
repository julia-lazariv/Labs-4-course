// MyException.cs
using System;

namespace Lab10
{
    public class MyException : Exception
    {
        public MyException(String errorMessage)
        : base(errorMessage) { }
    }
}