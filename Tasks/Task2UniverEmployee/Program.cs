﻿/*
using Task2UniverEmployee;

internal class Program
{
    private static void Main(string[] args)
    {
        var petrov = new Teacher(
            "Petr Petrov",
            13579,
            new Course("physics", "about physics")
            );
        var ivanov = new Teacher(
            "Ivan Ivanov",
            12345,
            new Course("mathematics", "about mathematics")
            );
        var fedorov = new SupportStaff(
            "Fedor Fedorov",
            24680,
            "cleaner"
            );
        var vasiliev = new DegreeTeacher(
            "Vasiliy Vasiliev",
            112233, 
            new Course("history", "about history"),
            "Bachelor",
            "history science"
            );

        UniversityEmployee[] universityEmployees = {
            petrov,
            ivanov,
            fedorov,
            vasiliev
        };

        Console.WriteLine("University Employees are: ");
        foreach (var universityEmployee in universityEmployees)
        {
            Console.WriteLine($" {universityEmployee.Person} {universityEmployee.GetOfficialDuties()}; ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("University's teachers are: ");
        foreach (var universityEmployee in universityEmployees)
        {
            if (universityEmployee is Teacher)
            {
                Console.WriteLine($" {universityEmployee.Person} {universityEmployee.GetOfficialDuties()}; ");
            }
        }
    }
}
*/

//Вывести на консоль всех сотрудников университета
//с описанием должностных обязанностей каждого

//Вывести на консоль только всех преподавателей