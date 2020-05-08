using System.Collections;

namespace AP.Properties.Assignment7_manageStudent
{
    public class Student
    {
        protected int id;
        protected string name;
        protected int age;
        protected string address;
        protected float gpa;

        public Student(int id, string name, int age, string address, float gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public Student()
        {
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public float Gpa
        {
            get => gpa;
            set => gpa = value;
        }
        
    }
}