using System;

namespace FizzBuzzToRefactor
{
    [Flags]
    public enum ModId
    {
        None = 0,
        Three = 1,
        Five = 2
    }
    public static class FizzBuzzer
    {
        public static string FizzBuzz(int problem)
        {
            Stringer stringer = new Stringer();
            stringer.Value = problem;

            ModId modId = ModId.None;
            if (problem % 3 == 0)
            {
                modId = modId | ModId.Three;
            }

            if (problem % 5 == 0)
            {
                modId = modId | ModId.Five;
            }

            string response = UseEnums(modId);

            if (response == null)
            {
                return stringer.Convert(problem);
            }
            else
            {
                return response;
            }
        }

        public static string UseEnums(ModId modId)
        {
            switch (modId)
            {
                case ModId.Three: return ModStrings.Three;
                case ModId.Five: return ModStrings.Five;
                case ModId.Three | ModId.Five: return ModStrings.Fifteen;
                default: return null;
            }
        }
    }

    public class Stringer
    {
        public int Value { get; set; }
        public string Convert(int problem) => Value.ToString();
    }
    public static class ModStrings
    {
        public const string Three = "Fizz";
        public const string Five = "Bµzz";
        public const string Fifteen = Three + Five;
    }
}
