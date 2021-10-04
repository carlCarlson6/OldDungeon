using System;
using System.Text.RegularExpressions;
using Core.Exceptions;

namespace Core
{
    public static class Dice
    {
        // TODO - finish implementation
        public static uint Roll(string rollIndication)
        {
            var cleanRollIndication = CleanupRollIndication(rollIndication);
            if (!ValidateRollIndicationFormat(cleanRollIndication))
            {
                throw new InvalidRollFormatException();
            }
            
            var (dices, faces, bonus) = ExtractRollValues(cleanRollIndication);
            if (!ValidateRollValues(dices, faces))
            {
                throw new InvalidRollFormatException();
            }

            return Roll((uint)dices, (uint)faces, bonus);
        }
        
        private static string CleanupRollIndication(string rollIndication) => 
            rollIndication.ToLower().Replace(" ", "");

        private static bool ValidateRollIndicationFormat(string rollIndication) => 
            new Regex(@"\d+d\d+([+,-]?\d+)?").IsMatch(rollIndication);

        // TODO
        private static (int Dices, int Faces, int Bonus) ExtractRollValues(string rollIndication) => throw new NotImplementedException();
        
        private static bool ValidateRollValues(int numberDices, int numberFaces) => numberDices > 0 && numberFaces > 0;
        
        public static Func<uint> RollAsFunction(string rollIndication) =>
            () => Roll(rollIndication);
        
        // TODO - make each throw of the dice independent when numberDices > 1, also check that numberDices is not == 0
        public static uint Roll(uint numberDices, uint numberFaces, int bonus = 0) =>
            (uint)((uint)(new Random().Next(1, (int)numberFaces) * numberDices) + bonus);
        
        public static Func<uint> RollAsFunction(uint numberDices, uint numberFaces, int bonus = 0) => 
            () => Roll(numberDices, numberFaces, bonus);
    }
}