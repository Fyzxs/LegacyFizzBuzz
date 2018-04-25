using System;

namespace FizzBuzzToRefactor
{
    [Flags]
    public enum MultipleEnum
    {
        None = 0,
        First = 1,
        Second = 2
    }
    public static class FizzBuzzer
    {
        public static string FizzBuzz(int i)
        {
            Stringer stringer = new Stringer();
            stringer.Value = i;

            MultipleEnum flag = MultipleEnum.None;
            if (i % 3 == (int)MultipleEnum.None)
            {
                flag = flag | MultipleEnum.First;
            }

            if (i % 5 == (int)MultipleEnum.None)
            {
                flag = flag | MultipleEnum.Second;
            }

            string v = Stringer(flag);

            if (v == null)
            {
                return stringer.Convert(i);
            }
            else
            {
                return v;
            }
        }

        public static string Stringer(MultipleEnum val)
        {
            switch (val)
            {
                case MultipleEnum.First: return ResultStringValues.Three;
                case MultipleEnum.Second: return ResultStringValues.Five;
                case MultipleEnum.First | MultipleEnum.Second: return ResultStringValues.Fifteen;
                default: return null;
            }
        }
    }

    public class Stringer
    {
        public int Value { get; set; }
        public string Convert(int i) => Value.ToString();
    }
    public static class ResultStringValues
    {
        public const string Three = "Fizz";
        public const string Five = "Bµzz";
        public const string Fifteen = Three + Five;
    }
}
