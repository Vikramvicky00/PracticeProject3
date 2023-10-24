using System;
using System.Collections.Generic;
using System.IO;

namespace Retrieve_And_Sort_Sort_Student_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
             List<Student> Studentlist = new List<Student>();
            try
            {
                string path = "D:\\Practice Exercises\\.Net\\Phase-1 Agile, Git, and Basics of C# Programming\\PracticeProject3\\Retrieve_And_Sort_Sort_Student_Data\\Retrieve_And_Sort_Sort_Student_Data\\StudentData.txt";

                string[] student_data = File.ReadAllLines(path);

                foreach (string line in student_data)
                {
                    String[] data = line.Split(',');
                    if (data.Length >= 1)
                    {
                        Student student = new Student();
                        student.Sname = data[0];
                        student.ClassName = data[1];
                        Studentlist.Add(student);
                    }
                }
                Studentlist.Sort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Display(Studentlist);
                Search(Studentlist);
            }
            Console.ReadLine();
        }

        public static void Search(List<Student> list)
        {
            Console.WriteLine("Enter Name To Search :");
            string name = Console.ReadLine();
            List<Student> found = list.FindAll(data => data.Sname == name);
            if (found != null)
            {
                foreach (Student student in found)
                {
                    Console.WriteLine(student.Sname + " presents in " + student.ClassName);
                }
            }
            else
            {
                Console.WriteLine("No Students found with name " + name);
            }
        }
        public static void Display(List<Student> list)
        {
            Console.WriteLine("Sorting Student Data....");
            foreach (var item in list)
            {
                Console.WriteLine(item.Sname + " " + item.ClassName);
            }
            Console.WriteLine();
        }

    }
}
