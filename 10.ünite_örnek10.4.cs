using System;

class ThisTest
{
   static void Main()
   {
      var time = new SimpleTime(15, 30, 19);
      Console.WriteLine(time.BuildString());
   }
}

// class SimpleTime demonstrates the "this" reference
public class SimpleTime
{
   private int hour; // 0-23
   private int minute; // 0-59
   private int second; // 0-59 

   // if the constructor uses parameter names identical to 
   // instance-variable names, the "this" reference is 
   // required to distinguish between the names
   public SimpleTime(int hour, int minute, int second)
   {
      this.hour = hour; // set "this" object's hour instance variable
      this.minute = minute; // set "this" object's minute            
      this.second = second; // set "this" object's second            
   }

   // use explicit and implicit "this" to call ToUniversalString
   public string BuildString() =>
      $"{"this.ToUniversalString()",24}: {this.ToUniversalString()}" +
      $"\n{"ToUniversalString()",24}: {ToUniversalString()}";

   // convert to string in universal-time format (HH:MM:SS);
   // "this" is not required here to access instance variables, 
   // because the method does not have local variables with the same 
   // names as the instance variables
   public string ToUniversalString() =>
      $"{this.hour:D2}:{this.minute:D2}:{this.second:D2}";
}

