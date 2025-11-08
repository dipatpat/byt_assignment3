using System.Runtime.InteropServices.JavaScript;

namespace Assignment3;

public class Calculator
{
   public float A;
   public float B;
   public char oper;

   public Calculator(float A, float B, char oper)
   {
      this.A = A;
      this.B = B;
      this.oper = oper;
   }
   
   public float AddNumbers()
   {
      return A + B;
   }

   public float SubtractNumbers()
   {
      return A - B;
   }

   public float MultiplyNumbers()
   {
      return A * B;
   }

   public float DivideNumbers()
   {
      if (B == 0)
      {
         throw new DivideByZeroException();
      }
      return A / B;
   }
}