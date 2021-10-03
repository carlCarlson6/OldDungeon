namespace Core
{
    public class Attribute
    {
        public uint Value { get; }
        
        public Attribute(uint value) => Value = value;
        
        public int Modifier => Value switch
        {
            <= 3 => -2,
            >= 4 and <= 6 => -1,
            >= 7 and <= 14 => 0,
            >= 15 and <= 17 => 1,
            >= 18 => 2
        };

        public static Attribute GenerateRandomAttribute()
        {
            var attributeValue = Dice.Throw(3, 6);
            return new Attribute(attributeValue);
        }

    }
}