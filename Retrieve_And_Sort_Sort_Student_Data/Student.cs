using System;


namespace Retrieve_And_Sort_Sort_Student_Data
{
    public class Student:IComparable<Student>
    {
        public string Sname { get; set; }
        public string ClassName { get; set; }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            Student student = other as Student;
            if (student != null)
            {
                return this.Sname.CompareTo(student.Sname);
            }
            else 
            {
                return -1;
            }
        }
    }
}
