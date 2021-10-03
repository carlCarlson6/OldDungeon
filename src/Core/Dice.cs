using System;

namespace Core
{
    public class Dice
    {
        public uint NumberFaces { get; }
        public uint NumberDices { get; }
        public int Bonus { get; }
        
        public Dice(uint numberFaces, uint numberDices, int bonus)
        {
            NumberFaces = numberFaces;
            NumberDices = numberDices;
            Bonus = bonus;
        }

        public static Dice WithFaces(uint numberFaces) => new (numberFaces, 0, 0);
        
        public uint Throw(uint numberDices) => (uint)((uint)(new Random().Next(1, (int)NumberFaces) * numberDices) + Bonus);
        
        public static uint Throw(uint numberFaces, uint numberDices, uint bonus = 0) =>
            (uint)((uint)(new Random().Next(1, (int)numberFaces) * numberDices) + bonus);
    }
}