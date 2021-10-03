namespace Core
{
    // TODO - define returns properties
    public class Result
    {
        public string Message { get; }
        public object Parameters { get; }
        
        public Result(string message, object parameters = null!)
        {
            Message = message;
            Parameters = parameters is not null ? parameters : new { };
        }
    }
}