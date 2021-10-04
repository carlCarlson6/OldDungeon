using System;
using System.Linq;
using System.Text.RegularExpressions;
using Core.Exceptions;
using Core.Extensions;
using static Core.Extensions.EnumerableExtensions;

namespace Core
{
    public static class Dice
    {
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

        public static bool ValidateRollIndicationFormat(string rollIndication) => 
            Regex.IsMatch(rollIndication, @"^\d+d\d+([+,-]?\d+)?$");

        public static (int Dices, int Faces, int Bonus) ExtractRollValues(string rollIndication)
        {
            var dices = rollIndication.Split('d').FirstOrDefault().ToInt32();
            var faces = rollIndication.Split('d').Second().Split('+', '-').FirstOrDefault().ToInt32();
            var bonus = rollIndication.Split('+', '-').SecondOrDefault().ToInt32();

            if (rollIndication.Contains('-'))
            {
                bonus = -bonus;
            }
            
            return (dices, faces, bonus);
        }
        
        private static bool ValidateRollValues(int numberDices, int numberFaces) => numberDices > 0 && numberFaces > 0;
        
        public static Func<int> RollAsFunction(string rollIndication) =>
            () => Roll(rollIndication);

        private static int Roll(int numberDices, int numberFaces, int bonus = 0)
        {
            if (numberFaces is 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberFaces));
            }
            
            return Range(numberDices)
                       .Aggregate((_, _) => new Random().Next(1, numberFaces))
                   + bonus;
        }
    }
}