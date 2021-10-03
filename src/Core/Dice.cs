using System;

namespace Core
{
    public static class Dice
    {
        // TODO - make each throw of the dice independent when numberDices > 1, also check that numberDices is not == 0
        public static uint Roll(uint numberDices, uint numberFaces, int bonus = 0) =>
            (uint)((uint)(new Random().Next(1, (int)numberFaces) * numberDices) + bonus);

        public static uint Roll(uint numberFaces, int bonus = 0) => Roll(1, numberFaces, bonus);
        
        public static Func<uint> RollAsFunction(uint numberDices, uint numberFaces, int bonus = 0) => 
            () => Roll(numberDices, numberFaces, bonus);
        
        public static Func<uint> RollAsFunction(uint numberFaces, int bonus = 0) => 
            () => Roll(numberFaces, bonus);
    }
}