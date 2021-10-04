namespace Core
{
    public class Protection : Item
    {
        private readonly int _protection;
        
        public Protection(string name, ItemType itemType, int protection) : base(name, itemType)
        {
            _protection = protection;
        }

        public override int GetProtection() => _protection;
        
        public override Result Apply(Hero hero) => throw new System.NotImplementedException();
        public override int DoDamage() => throw new System.NotImplementedException();
    }
}