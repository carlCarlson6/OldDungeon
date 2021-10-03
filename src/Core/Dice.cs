using System;

namespace Core
{
    public static class Dice
    {
        // TODO - make each throw of the dice independent when numberDices > 1, also check that numberDices is not == 0
        public static uint Throw(uint numberDices, uint numberFaces, int bonus = 0) =>
            (uint)((uint)(new Random().Next(1, (int)numberFaces) * numberDices) + bonus);

        public static Func<uint> ThrowAsFunction(uint numberDices, uint numberFaces, int bonus = 0) => 
            () => Throw(numberDices, numberFaces, bonus);
    }
}