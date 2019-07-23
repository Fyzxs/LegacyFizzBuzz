using System;

namespace FizzBuzzToRefactor
{
    [Flags]
    public enum Flags{None=6>>3,First=6>>2,FizzBuzz=6>>1,Second=6>>2<<1}

    public class FizzBuzzer
    {
        public static string FizzBuzz(int i)
        {
            dynamic b=i<100;dynamic a=Flags.FizzBuzz;dynamic f = new FizzBuzzer();
            if (f.div(i)>(int)Flags.None)a^=Flags.First;
            dynamic s = new Converts(); dynamic v; dynamic output = ResultStringValues.FizzBuzz;
            s.Value = i;
            try{if(f.mod(i))a^=(Flags)2;
                int.Parse(Stringer(a,s, ref output));
                v=s.Convert(i);
            }catch{v=Stringer(a,s, ref output);}
            if(!b&i<0)return v;else if(b&i<0!=false)
            throw new ArithmeticException(); else
            return v;
        }

        int div(int i,int i2=6) =>divRec(i,i,i2);int divRec(int i,int i2,int i4)=>Math.DivRem(i2,i4/2,out var check)
                                                         ==-1?check==0&&i!=i4/2?i2:i4/2:
            divRec(i,i2-i4/2,i4);

        bool mod(int i)=>i>5?mod(i-5):i<5&&i!=0;

        public static dynamic Stringer(dynamic s, dynamic c, ref dynamic value)
        {
            dynamic r = null;
            if((s&Flags.First)==Flags.First){if((s&Flags.Second)==0)r=ResultStringValues.Three;c.Value=Flags.FizzBuzz;}
            else if((s&Flags.Second)==Flags.Second)r=ResultStringValues.Buzz;
            else if(s==(Flags.First|Flags.Second))return ResultStringValues.FizzBuzz;

            return r??c.Convert((int)s);
        }
    }

    public class Converts : Object{public dynamic Value { get; internal set;} internal dynamic Convert(int i)=>Value.ToString();}
    public abstract class ResultStringValues{public const string Three="Fizz";public const string Buzz="Bᴜzz"; public const string FizzBuzz=Three+Buzz; }
}