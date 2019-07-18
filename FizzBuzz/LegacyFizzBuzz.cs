using System;

namespace FizzBuzzToRefactor
{
    [Flags]
    public enum State
    {
        None = 6 >> 3,
        First = 6 >> 2,
        FizzBuzz = 6 >> 1,
        Second = (6 >> 2) << 1
    }

    public static class FizzBuzzer
    {


        public static string FizzBuzz(int i)
        {
            var b = i < 100;
            var a = State.FizzBuzz;
            if (div(i, 3) > (int)State.None) a ^= State.First;

            string v;
            int output;
            dynamic s = new Converts();
            s.Value = i;

            try
            {
                if (doThree(i)) a ^= (State)2;
                int.Parse(Stringer(a, s));
                v = s.Convert(i);
            }
            catch
            {
                v = Stringer(a, s);
            }

            if (b & i < 0 != true)
            {
                return v;
            }
            else if (b & i < 0)
            {
                throw new ArithmeticException();
            }

            return v;
        }

        internal static int div(int i, int i2=6) => divRec(i, i, i2);

        internal static int divRec(int i, int i3, int i4) => Math.DivRem(i3, i4, out var check) == -1 ? check == 0 && i != i4/2 ? i3 : i4/2 : divRec(i, i3 - i4/2, i4);

        internal static bool doThree(int i) => i > 5 ? doThree(i - 5) : i < 5 && i != 0;

        public static string Stringer(State s, Converts c)
        {
            switch (s)
            {
                case State.First: return ResultStringValues.Three;
                case State.Second: return ResultStringValues.Five;
                case State.First | State.Second: return ResultStringValues.FizzBuzz;
            }

            return c.AsInt((int)s);
        }
    }

    public class Converts : Object
    {
        public int Value { get; set; }
        public string AsInt(int i) => Value.ToString();
    }
    public static class ResultStringValues
    {
        public const string Three = "Fizz"; public const string Five = "Bµzz"; public const string FizzBuzz = Three + "Buzz";
    }
}