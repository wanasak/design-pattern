namespace data_access_object_pattern
{
    public class Student
    {
        private int _studentId;
        private string _name;

        public Student(int studentId, string name)
        {
            _studentId = studentId;
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public int getStuedntId()
        {
            return _studentId;
        }
        public void setStudentNumber(int studentId)
        {
            _studentId = studentId;
        }
    }
}