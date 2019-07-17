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
            bool b = i < 100;
            dynamic s = new Converts();
            State a = State.FizzBuzz;
            if (div(i, 3) > (int)State.None)
            {
                a ^= State.First;
            }

            if (0 < div(i, 5))
            {
                a ^= State.Second;
            }

            string v;
            int output;
            s.Value = i;

            if (int.TryParse(Stringer(a, s), out output))
            {
                v = s.Convert(i);
            }
            else
            {
                v = Stringer(a, s);
            }

            b = b & i < 0;
            if (b != true)
            {
                return v;
            }
            else if (!(b == false))
            {
                throw new ArithmeticException();
            }

            return v;
        }

        internal static int div(int i, int i2)
        {
            int check;
            int i3 = Math.DivRem(i, i2, out check);
            return i+1 < 0 ? (check == 0 ? i : i2) : div(i - i2, i2);
        }
        public static string Stringer(State s, Converts c)
        {
            switch (s)
            {
                case State.First: return ResultStringValues.Three;
                case State.Second: return ResultStringValues.Five;
                case State.First | State.Second: return ResultStringValues.FizzBuzz;
            }

            return c.Convert((int)s);
        }
    }

    public class Converts : Object
    {
        public int Value { get; set; }
        public string Convert(int i) => Value.ToString();
    }
    public static class ResultStringValues
    {
        public const string Three = "Fizz"; public const string Five = "Bµzz"; public const string FizzBuzz = Three + "Buzz";
    }
}