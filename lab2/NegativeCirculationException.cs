using System;

namespace lab2
{
    public class NegativeCirculationException : ArgumentException
    {
        public NegativeCirculationException(string _message) : base(_message) { }
    }
}
