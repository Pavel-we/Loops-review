using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace Loops_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            For8(23, 81);
        }
        #region For

        public static int? For2(int NumberA, int NumberB)
        {
            for (int i = NumberA; i <= NumberB; i++)
                WriteLine(i);
            return null;
        }
        public static int? For4(int Number)
        {
            for (int i = 1; i <= 10; i++)
                WriteLine(Number * i);
            return null;
        }
        public static float? For6(float Number)
        {
            for (float i = 1; i <= 2; i += 0.2f)
                WriteLine(Number * i);
            return null;
        }
        public static int? For8(int NumberA, int NumberB, int NumberC = 1)
        {
            for (int i = NumberA; i <= NumberB; i++)
                NumberC += i;
            return null;
        }
        public static float For10(int Number, float Result = 0)
        {
            for (int i = 1; i <= Number; i++)
                Result += 1 / (float)i;
            return Result;
        }
        public static float For12(int Number, float Result = 1)
        {
            for (int i = 1; i <= Number; i++)
                Result *= 1 + i / 10f;
            return Result;
        }
        public static int For14(int NumberA, int NumberB, int Result = 0)
        {
            for (int i = 0; i == NumberA; i++)
            {
                Result += NumberB;
                NumberB += 2;
            }
            return Result;
        }
        public static float For16(int Number, float NumberA, float Result = 1)
        {
            for (int i = 0; i <= Number; i++)
                WriteLine(Result *= NumberA);
            return Result;
        }
        public static float For18(int Number, float NumberA, float NumberB = 1, float Result = 1)
        {
            for (int i = 2; i <= Number; i++)
            {
                NumberB *= -NumberA;
                Result += NumberB;
            }
            return Result;
        }
        public static float For20(int Number, float NumberA = 1, float Result = 0)
        {
            for (int i = 1; i <= Number; i++)
            {
                NumberA *= i;
                Result += NumberA;
            }
            return Result;
        }
        public static double For22(int Number, float NumberX = 1.1f, float Result = 1)
        {
            for (int i = 1; i <= Number; i++)
            {
                Result *= NumberX / i;
            }
            return Result;
        }
        public static double For24(int Number, double NumberW, int NumberX = 0, double NumberY = 1, double NumberZ = 1, double Result = 1.0)
         {
             for (int i = 2; i <= Number; i++)
             {
                 NumberZ *= (double)NumberX;
                 for (int j = 1; j <= Number; j++)
                 {
                     NumberZ *= (double)NumberX;
                     NumberY *= (-1) * NumberX * NumberX;
                     Result += NumberY / NumberZ;
                 }
             }
             return Result;
         }
         public static double For26(int Number, double Result, double NumberX, double NumberZ, int NumberY = 1)
         {
             for (int i = 2; i <= Number; i++)
             {
                 NumberY += 2;
                 NumberZ *= (-1) * NumberX * NumberX;
                 Result += NumberZ / NumberY;
             }
             return Result;
         }
         public static double For28(int Number, double NumberA, double NumberB, double NumberC, double NumberD, double Result)
         {
             for (int i = 1; i <= Number; i++)
             {
                 NumberA *= 2 * i - 3;
                 NumberB *= 2 * i;
                 NumberC *= (-1) * NumberD;
                 Result += NumberA * NumberC / NumberB;
             }
             return Result;
         }
         public static double? For30(int Number, double NumberA, double NumberB, double NumberC)
         {
             NumberC = (NumberB - NumberA) / Number;
             for (int i = 0; i <= Number; i++) return 1 - Math.Sin(NumberA + i * NumberC); return null;
         }
         public static double? For32(int Number, double NumberA = 1)
         {
             for (int i = 1; i < -Number; i++)
             {
                 return (NumberA + 1) / i;
                 NumberA = (NumberA + 1) / i;
             }
             return null;
         }
         public static double? For34(int Number, double NumberA, double NumberA1, double NumberA2)
         {
             for (int i = 3; i <= Number; i++)
             {
                 NumberA = (NumberA1 + 2 * NumberA2) / 3;
                 return NumberA;
                 NumberA1 = NumberA2;
                 NumberA2 = NumberA;
             }
             return null;
         }
         public static double For36(int Number, int NumberA, double NumberB, double Result = 0)
         {
             for (int i = 1; i <= Number; i++)
             {
                 NumberB = i;
                 for (int j = 1; j <= NumberA; j++) NumberB *= i;
                 Result += NumberB;
             }
             return Result;
         }
         public static double For38(int Number, double NumberA, double Result)
         {
             for (int i = 1; i <= Number; i++)
             {
                 NumberA = i;
                 for (int j = 1; j <= Number - i; j++) NumberA *= i;
                 Result += NumberA;
             }
             return Result;
         }
         public static int? For40(int NumberA, int NumberB)
         {
             for (int i = 1; i <= NumberB - NumberA + 1; i++)
                 for (int j = 1; j <= i; j++) return (NumberA + i - 1);
             return null;
         }
         #endregion
        #region While
        public static int While2(int NumberA, int NumberB, int NumberC = 0)
        {
            while (NumberA >= NumberB)
            {
                NumberC -= NumberB;
                NumberC++;
            }
            return NumberC;
        }
        public static bool While4(int Number)
        {
            while (Number >= 3)
            {
                if (Number % 3 != 0)
                    return false;

                Number /= 3;
            }
            return Number == 1;
        }
        public static int While6(int Number, int NumberB = 1, int Result = 1)
        {
            if (Number % 2 == 0) Number = 2;
            while (NumberB <= Number)
            {
                Result *= NumberB;
                NumberB += 2;
            }
            return Result;
        }
        public static int While8(int Number, int NumberA)
        {
            while (Number / (NumberA * NumberA) <= Number)
                NumberA++;
            return Number;
        }
        public static int While10(int Number, int NumberA = 0, int NumberB = 3)
        {
            while (NumberB < Number)
            {
                NumberB *= 3;
                NumberA++;
            }
            return NumberB;
        }
        public static int While12(int Number, int NumberA, int Result, int NumberB = 0)
        {
            while (NumberB + NumberA + 1 <= Number)
            {
                NumberA++;
                NumberB += NumberA;
            }
            Write(NumberA);
            Write(NumberB);
            return Result;
        }
        public static int While14(int NumberA, int NumberB, int Result, int NumberC = 0)
        {
            while (NumberC <= NumberA)
            {
                NumberB++;
                NumberC += 1 / NumberB;
            }
            return Result;
        }
        public static float While16(float NumberP, float Result = 0, float KmPerDay = 10f)
        {
            while (Result <= 200)
            {
                Result += KmPerDay;
                KmPerDay = KmPerDay + ((KmPerDay / 100) * NumberP);
            }
            return Result;
        }
        public static int? While18(int Number, int NumberA = 0, int NumberB = 0)
        {
           while (Number > 0)
           {
               NumberA++;
               NumberB += Number % 10;
               Number /= 10;
           }
           return null;
        public static bool While20(int Number)
        {
            while (Number > 0)
            {
                if (Number % 10 == 2) return true;
                Number /= 10;
            }
            return false;
        }
        public static bool While22(int NumberA, int NumberB = 2, bool NumberC = true)
        {
            while (NumberC && NumberB < NumberA)
            {
                if (NumberA % NumberB == 0)
                {
                    NumberC = false;
                    break;
                }
                NumberB++;
            }
            return NumberC;
        }
        public static bool While24(int Number, int NumberF = 0, int NumberF1 = 1, int NumberF2 = 1, bool NumberA = false)
        {
            while (NumberF < Number)
            {
                if (NumberF == Number)
                {
                    NumberA = true;
                    break;
                }
                NumberF = NumberF2 + NumberF1;
                NumberF2 = NumberF1;
                NumberF1 = NumberF;
            }
            return NumberA;
        }
        public static int While26(int Number, int NumberF = 0, int NumberF1 = 1, int NumberF2 = 1)
        {
            while (NumberF < Number)
            {
                NumberF = NumberF2 + NumberF1;
                NumberF2 = NumberF1;
                NumberF1 = NumberF;
            }
            return (NumberF1 + NumberF2);
        }
        public static float While28(int Number, float NumberA, float NumberB = 1, float NumberC = 0f, float NumberD = 0f)
        {
            while (Math.Abs(NumberC - NumberD) <= NumberA)
            {
                NumberB++;
                NumberC = NumberD;
                NumberD = 2 + 1 / NumberC;
            }
            return NumberB;
        }
        #endregion
    
    } 
}
