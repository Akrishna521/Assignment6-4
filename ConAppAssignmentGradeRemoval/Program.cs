using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample student grades data
        List<int> studentGrades = new List<int> { 85, 90, 78, 92, 88 };

        // Task 4.1: Remove the grade of 78 from studentGrades
        studentGrades.Remove(78);

        // Task 4.2: Display the studentGrades after the removal
        Console.WriteLine("Student Grades after removing 78:");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }
    }
}