namespace Core.Items
{
    public class Protection : Item
    {
        private readonly uint _protection;
        
        public Protection(string name, ItemType itemType, uint protection) : base(name, itemType)
        {
            _protection = protection;
        }

        public override uint GetProtection() => _protection;
        
        public override Result Apply(Hero hero) => throw new System.NotImplementedException();
        public override uint DoDamage() => throw new System.NotImplementedException();
    }
}