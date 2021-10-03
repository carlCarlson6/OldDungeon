using System;

namespace Core
{
    // TODO - define returns properties
    public class Result
    {
        public string Message { get; }

        public Result(string message)
        {
            Message = message;
        }
    }
}