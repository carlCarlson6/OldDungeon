using System;
using System.Linq;
using System.Text.RegularExpressions;
using Core.Exceptions;
using Core.Extensions;
using static System.Linq.Enumerable;

namespace Core
{
    public static class Dice
    {
        // TODO - finish implementation
        public static int Roll(string rollIndication)
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

            return Roll(dices, faces, bonus);
        }
        
        private static string CleanupRollIndication(string rollIndication) => 
            rollIndication.ToLower().Replace(" ", "");

        private static bool ValidateRollIndicationFormat(string rollIndication) => 
            new Regex(@"\d+d\d+([+,-]?\d+)?").IsMatch(rollIndication);

        private static (int Dices, int Faces, int Bonus) ExtractRollValues(string rollIndication)
        {
            var dices = rollIndication.Split('d').FirstOrDefault().ToInt32();
            var faces = rollIndication.Split('d')[1].Split('+', '-').FirstOrDefault().ToInt32();

            // TODO - extract bonus if exists
            return (dices, faces, 0);
        }
        
        private static bool ValidateRollValues(int numberDices, int numberFaces) => numberDices > 0 && numberFaces > 0;
        
        public static Func<int> RollAsFunction(string rollIndication) =>
            () => Roll(rollIndication);
        
        // TODO - make each throw of the dice independent when numberDices > 1, also check that numberDices is not == 0
        public static int Roll(int numberDices, int numberFaces, int bonus = 0) => 
            Range(1, numberDices)
                .Aggregate((_, _) => new Random().Next(1, numberFaces))
            + bonus;


        public static Func<int> RollAsFunction(int numberDices, int numberFaces, int bonus = 0) => 
            () => Roll(numberDices, numberFaces, bonus);
    }
}