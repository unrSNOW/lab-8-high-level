struct Student
{
    public int SerialNumber;
    public string FullName;
    public int BirthDay;
    public int BirthMonth;
    public int Age;
}

class Program
{
    static void Main()
    {
        Student[] students = {
            new Student { SerialNumber = 1, FullName = "Иванов Иван", BirthDay = 5, BirthMonth = 10, Age = 20 },
            new Student { SerialNumber = 2, FullName = "Петров Петр", BirthDay = 12, BirthMonth = 2, Age = 21 },
           
        };

        Console.WriteLine("Полная дата рождения и день недели:");
        foreach (var student in students)
        {
            DateTime dateOfBirth = GetDateOfBirth(student.BirthDay, student.BirthMonth);
            Console.WriteLine($"{student.FullName}: {dateOfBirth.ToShortDateString()}, День недели: {GetDayOfWeekNumber(dateOfBirth.DayOfWeek)}");
        }

        Console.WriteLine("\nСтуденты, родившиеся в високосный год:");
        foreach (var student in students)
        {
            DateTime dateOfBirth = GetDateOfBirth(student.BirthDay, student.BirthMonth);
            if (IsLeapYear(dateOfBirth.Year))
            {
                Console.WriteLine($"{student.FullName}: {dateOfBirth.ToShortDateString()}");
            }
        }
    }

    static DateTime GetDateOfBirth(int day, int month)
    {
        int currentYear = DateTime.Now.Year;
        return new DateTime(currentYear, month, day);
    }

    static int GetDayOfWeekNumber(DayOfWeek dayOfWeek)
    {
        return (int)dayOfWeek + 1;
    }

    static bool IsLeapYear(int year)
    {
        return DateTime.IsLeapYear(year);
    }
}