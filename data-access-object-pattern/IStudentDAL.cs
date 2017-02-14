using System.Collections.Generic;

namespace data_access_object_pattern
{
    public interface IStudentDAL
    {
        List<Student> getStudents();
        Student getStudent(int studentId);
        void updateStudent(Student student);
        void deleteStudent(Student student);
    } 
}