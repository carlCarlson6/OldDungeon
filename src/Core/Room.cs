using System;

namespace Core
{
    public class Room
    {
        public string Identifier { get; }

        public Room()
        {
            Identifier = Guid.NewGuid().ToString();
        }
    }
}