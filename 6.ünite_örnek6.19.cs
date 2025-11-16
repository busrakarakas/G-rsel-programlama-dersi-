using System;

class LogicalOperators
{
   static void Main()
   {
      // create truth table for && (conditional AND) operator
      Console.WriteLine("Conditional AND (&&)");
      Console.WriteLine($"false && false: {false && false}");
      Console.WriteLine($"false && true: {false && true}");
      Console.WriteLine($"true && false: {true && false}");
      Console.WriteLine($"true && true: {true && true}\n");

      // create truth table for || (conditional OR) operator
      Console.WriteLine("Conditional OR (||)");
      Console.WriteLine($"false || false: {false || false}");
      Console.WriteLine($"false || true: {false || true}");
      Console.WriteLine($"true || false: {true || false}");
      Console.WriteLine($"true || true: {true || true}\n");

      // create truth table for & (boolean logical AND) operator
      Console.WriteLine("Boolean logical AND (&)");
      Console.WriteLine($"false & false: {false & false}");
      Console.WriteLine($"false & true: {false & true}");
      Console.WriteLine($"true & false: {true & false}");
      Console.WriteLine($"true & true: {true & true}\n");

      // create truth table for | (boolean logical inclusive OR) operator
      Console.WriteLine("Boolean logical inclusive OR (|)");
      Console.WriteLine($"false | false: {false | false}");
      Console.WriteLine($"false | true: {false | true}");
      Console.WriteLine($"true | false: {true | false}");
      Console.WriteLine($"true | true: {true | true}\n");

      // create truth table for ^ (boolean logical exclusive OR) operator
      Console.WriteLine("Boolean logical exclusive OR (^)");
      Console.WriteLine($"false ^ false: {false ^ false}");
      Console.WriteLine($"false ^ true: {false ^ true}");
      Console.WriteLine($"true ^ false: {true ^ false}");
      Console.WriteLine($"true ^ true: {true ^ true}\n");

      // create truth table for ! (logical negation) operator
      Console.WriteLine("Logical negation (!)");
      Console.WriteLine($"!false: {!false}");
      Console.WriteLine($"!true: {!true}");
   }
}
