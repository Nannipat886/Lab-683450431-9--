using Lab_683450431_9_การเขียนโปรแกรมเชิงวัตถุ;
using System;
using System.Collections.Generic;

public class Course
{
    private string courseName;
    private string courseID;
    private List<Student> students = new List<Student>();

    public Course(string name, string id)
    {
        courseName = name;
        courseID = id;
    }

    public void AddStudent(Student s)
    {
        students.Add(s);
    }
    public void ShowAllStudents()
    {
        foreach (Student s in students)
        {
            Console.WriteLine();
            Console.WriteLine($"รายวิชา{courseName}");
            Console.WriteLine($"รหัสวิชา{courseID}");
            s.ShowInfo();
            Console.WriteLine();
        }
        if (students.Count == 0) ;
        {
            Console.WriteLine();
            Console.WriteLine("ไม่มีนักศึกษาในรายวิชานี้");
            Console.WriteLine();
        }
    }
    public void ShowStatistics()
    {
        if (students.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("ไม่มีคะแนนของนักศึกษา");
            Console.WriteLine();
            return;
        }

        int max = students[0].GetScore();
        int min = students[0].GetScore();
        int sum = 0;

        foreach (Student s in students)
        {
            int sc = s.GetScore();

            if (sc > max) max = sc;
            if (sc < min) min = sc;

            sum += sc;
        }

        double avg = (double)sum / students.Count;
        Console.WriteLine();
        Console.WriteLine($"รายวิชา{courseName}");
        Console.WriteLine($"รหัสวิชา{courseID}");
        Console.WriteLine($"คะแนนสูงสุด: {max}");
        Console.WriteLine($"คะแนนต่ำสุด: {min}");
        Console.WriteLine($"คะแนนเฉลี่ย: {avg:F2}");
        Console.WriteLine();
    }
}