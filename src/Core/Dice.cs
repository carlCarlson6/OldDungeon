using System;

namespace Core
{
    public static class Dice
    {
        public static uint Throw(uint numberFaces, uint numberDices, int bonus = 0) =>
            (uint)((uint)(new Random().Next(1, (int)numberFaces) * numberDices) + bonus);

        public static Func<uint> ThrowAsFunction(uint numberFaces, uint numberDices, int bonus = 0)
        {
            var throwGenerator = new Func<uint>(() => Throw(numberDices, numberDices, bonus));
            return throwGenerator;
        }
    }
}