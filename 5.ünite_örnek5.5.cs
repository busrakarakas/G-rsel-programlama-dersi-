using System;

class Student
{
   public string Name { get; set; } // property
   private int average; // instance variable

   // constructor initializes Name and Average properties
   public Student(string studentName, int studentAverage)
   {
      Name = studentName;
      Average = studentAverage; // sets average instance variable
   }

   // property to get and set instance variable average
   public int Average
   {
      get // returns the Student's average
      {
         return average;
      }
      set  // sets the Student's average
      {
         // validate that studentAverage is > 0 and <= 100; otherwise,
         // keep instance variable average's current value  
         if (value > 0)
         {
            if (value <= 100)
            {
               average = value; // assign to instance variable
            }
         }
      }
   }

   // returns the Student's letter grade, based on the average
   public string LetterGrade
   {
      get
      {
         string letterGrade = string.Empty; // string.Empty is ""

         if (average >= 90)
         {
            letterGrade = "A";
         }
         else if (average >= 80)
         {
            letterGrade = "B";
         }
         else if (average >= 70)
         {
            letterGrade = "C";
         }
         else if (average >= 60)
         {
            letterGrade = "D";
         }
         else 
         {
            letterGrade = "F";
         }

         return letterGrade;
      }
   }
}
