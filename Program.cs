using System;

public class Student
{
    
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    
    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    
    public bool IsExcellent()
    {
        return Grade >= 5.0;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
       
        Student student = new Student("Шарифзода Фарзод", 20, 5);

       
        if (student.IsExcellent())
        {
            Console.WriteLine($"{student.Name} является отличником.");
        }
        else
        {
            Console.WriteLine($"{student.Name} не является отличником.");
        }
    }
}