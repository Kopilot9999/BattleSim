using System;

class Student
{
    public string Name;
    public string Group;

    public Student(string name, string group)
    {
        Name = name;
        Group = group;
    }

    public void Print()
    {
        Console.WriteLine($"Студент: {Name}, група: {Group}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Іван", "КН-21");
        Student s2 = new Student("Олена", "КН-22");
        s1.Print();
        s2.Print();
    }
}
