using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace AP.Properties.Assignment7_manageStudent
{
    public class ListStudent
    {
        private List<Student> listStudent;

        public ListStudent()
        {
            this.listStudent=new List<Student>();
        }

        public void ShowStudent()
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                Console.WriteLine("id :"+listStudent[i].Id+" name: "+listStudent[i].Name+" age: "+listStudent[i].Age+" Address: "+listStudent[i].Address+" gpa: "+listStudent[i].Gpa);
            }
        }
        
        public void SortGpa()
        {
            listStudent.Sort((x, y) => y.Gpa.CompareTo(x.Gpa));
        }
        
        public void SortName()
        {
            listStudent.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public Student Search(int id)
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (id == listStudent[i].Id)
                {
                    return listStudent[i];
                }
            }

            return null;
        }
        public bool DeleteStudent(int id)
        {
            Student st = Search(id);
            if (st != null)
            {
                listStudent.Remove(st);
                return true;
            }

            return false;
        }

        public bool EditStudent(int id)
        {
            Student st = Search(id);
            if (st != null)
            {
                Console.WriteLine("1: name\n2: age\n3: Address\n4:gpa\n5:complete");
                Console.WriteLine("Chon phan ma ban muon sua: ");
                int x;
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                    {
                        Console.WriteLine("Nhap ten can sua");
                        string y = Convert.ToString(Console.ReadLine());
                        st.Name = y;
                    }else if (x == 2)
                    {
                        Console.WriteLine("nhap tuoi can sua : ");
                        int y = Convert.ToInt32(Console.ReadLine());
                        st.Age = y;
                    }else if (x == 3)
                    {
                        Console.WriteLine("Nhap dia chi moi: ");
                        string y = Convert.ToString(Console.ReadLine());
                        st.Address = y;
                    }else if (x == 4)
                    {
                        Console.WriteLine("Nhap diem trung binh moi: ");
                        float y = Convert.ToInt32(Console.ReadLine());
                        st.Gpa = y;
                    }
                    else
                    {
                        Console.WriteLine("Khong co action: ");
                    }

                } while (x == 5);

                return true;



            }
            Console.WriteLine("Khong co id trong danh sach de sua");
            return false;
        }

        public bool AddStudent(Student student)
        {
            if (Search(student.Id) != null)
            {
                Console.WriteLine("student exist in the list, you can not add.");
                return false;
            }
            listStudent.Add(student);
            Console.WriteLine("You just add to the  list student "+student.Name);
            return true;
        }
        
    }
}