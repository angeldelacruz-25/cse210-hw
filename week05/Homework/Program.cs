using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("Flor Celeste", "Multiplication");
        Console.WriteLine(a1.GetSummary());


        MathAssignment a2 = new MathAssignment("Cesar Steven", "Fractions", "9.5", "6-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Angel De La Cruz", "Dominican Republic History", "Hunger Games");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}