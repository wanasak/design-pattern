using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_access_object_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IStudentDAL studentDal = new StudentDAL();

            studentDal.getStudents()
                .ForEach(st => Console.WriteLine($"Student: ID: { st.getStuedntId() }, Name: { st.getName() }"));
            
            Student student = studentDal.getStudent(1);
            student.setName("Wanasak");
            studentDal.updateStudent(student);

            student = studentDal.getStudent(1);
            Console.WriteLine($"Student: ID: { student.getStuedntId() }, Name: { student.getName() }");
        }
    }
}
