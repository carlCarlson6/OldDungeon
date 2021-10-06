namespace Core
{
    public class ConsumableResult : Result
    {
        public int CuredPoints { get; }
        
        public ConsumableResult(string message, int curedPoints) : base(message)
        {
            CuredPoints = curedPoints;
        }
    }
}