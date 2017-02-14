using System;
using System.Collections.Generic;

namespace data_access_object_pattern
{
    public class StudentDAL : IStudentDAL
    {
        private List<Student> _students;

        public StudentDAL()
        {
            _students = new List<Student>();
            Student student1 = new Student(1, "John");
            Student student2 = new Student(2, "Peter");
            _students.Add(student1);
            _students.Add(student2);
        }

        public void deleteStudent(Student student)
        {
            _students.Remove(student);
        }

        public Student getStudent(int studentId)
        {
            return _students.Find(st => st.getStuedntId() == studentId);
        }

        public List<Student> getStudents()
        {
            return _students;
        }

        public void updateStudent(Student student)
        {
            _students.Find(st => st.getStuedntId() == student.getStuedntId())
                .setName(student.getName());
            Console.WriteLine("Updated student");
        }
    }
}