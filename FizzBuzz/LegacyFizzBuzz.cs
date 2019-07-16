using System;

namespace FizzBuzzToRefactor
{
    [Flags]
    public enum State
    {
        None = 0,
        First = 6 >> 2,
        FizzBuzz = 6 >> 1,
        Second = (6 >> 2) << 1
    }

    public static class FizzBuzzer
    {


        public static string FizzBuzz(int i)
        {
            Converts s = new Converts();
            s.Value = i;

            State a = State.FizzBuzz;
            if (div(i, 3) > (int)State.None)
            {
                a ^= State.First;
            }

            if (div(i, 5) > (int)State.None)
            {
                a ^= State.Second;
            }

            string v;
            int output;
            if (int.TryParse(Stringer(a, s), out output))
            {
                v = s.Convert(i);
            }
            else
            {
                v = Stringer(a, s);
            }

            return v;
        }

        internal static int div(int i, int i2)
        {
            int check;
            int i3 = Math.DivRem(i, i2, out check);
            return i < i2 ? (check == 0 ? i : i2) : div(i - i2, i2);
        }
        public static string Stringer(State s, Converts c)
        {
            switch (s)
            {
                case State.First: return ResultStringValues.Three;
                case State.Second: return ResultStringValues.Five;
                case State.FizzBuzz: return ResultStringValues.FizzBuzz;
            }

            return c.Convert((int)s);
        }
    }

    public class Converts
    {
        public int Value { get; set; }
        public string Convert(int i) => Value.ToString();
    }
    public static class ResultStringValues
    {
        public const string Three = "Fizz"; public const string Five = "Bµzz"; public const string FizzBuzz = Three + Five;
    }
}