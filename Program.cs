using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GPACalculator gpaCalculator = new GPACalculator();

        Console.Write("How many courses do you want to input? ");
        int numCourses = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCourses; i++)
        {
            gpaCalculator.AddCourse();
        }

        gpaCalculator.CalculateGPA();
        PrintTable.PrintResults(gpaCalculator.Courses, gpaCalculator.TotalUnitsRegistered, gpaCalculator.TotalUnitsPassed, gpaCalculator.TotalWeightPoint, gpaCalculator.GPA);
    }
}

class Course
{
    public string Name { get; set; }
    public int Unit { get; set; }
    public string Grade { get; set; }
    public int GradeUnit { get; set; }
    public int Weight { get; set; }
    public string Remark { get; set; }
}

class GPACalculator
{
    public List<Course> Courses { get; private set; } = new List<Course>();
    public int TotalWeightPoint { get; private set; }
    public int TotalUnitsRegistered { get; private set; }
    public int TotalUnitsPassed { get; private set; }
    public double GPA { get; private set; }

    public void AddCourse()
    {
        Course course = new Course();

        Console.Write("Enter course name: ");
        course.Name = Console.ReadLine();

        Console.Write("Enter course code: ");
        string code = Console.ReadLine();

        Console.Write("Enter course unit: ");
        course.Unit = int.Parse(Console.ReadLine());

        Console.Write("Enter course score: ");
        int score = int.Parse(Console.ReadLine());

        (course.Grade, course.GradeUnit, course.Remark) = GetGrade(score);

        course.Weight = course.Unit * course.GradeUnit;
        TotalWeightPoint += course.Weight;
        TotalUnitsRegistered += course.Unit;

        if (course.Grade != "F")
        {
            TotalUnitsPassed += course.Unit;
        }

        Courses.Add(course);
    }

    private (string, int, string) GetGrade(int score)
    {
        if (score >= 70)
            return ("A", 5, "Excellent");
        else if (score >= 60)
            return ("B", 4, "Very Good");
        else if (score >= 50)
            return ("C", 3, "Good");
        else if (score >= 45)
            return ("D", 2, "Fair");
        else if (score >= 40)
            return ("E", 1, "Pass");
        else
            return ("F", 0, "Fail");
    }

    public void CalculateGPA()
    {
        GPA = TotalWeightPoint / (double)TotalUnitsRegistered;
    }
}

class PrintTable
{
    public static void PrintResults(List<Course> courses, int totalUnitsRegistered, int totalUnitsPassed, int totalWeightPoint, double gpa)
    {
        Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");
        Console.WriteLine("| COURSE & CODE   | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt.  | REMARK       |");
        Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");

        foreach (var course in courses)
        {
            Console.WriteLine($"| {course.Name,-22} | {course.Unit,-12} | {course.Grade,-6} | {course.GradeUnit,-11} | {course.Weight,-15} | {course.Remark,-14} |");
        }

        Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|");
        Console.WriteLine($"Total Course Unit Registered is {totalUnitsRegistered}");
        Console.WriteLine($"Total Course Unit Passed is {totalUnitsPassed}");
        Console.WriteLine($"Total Weight Point is {totalWeightPoint}");
        Console.WriteLine($"Your GPA is = {gpa:F2} to 2 decimal places.");
    }
}
