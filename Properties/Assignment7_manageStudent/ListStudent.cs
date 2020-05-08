using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace AP.Properties.Assignment7_manageStudent
{
    public class ListStudent
    {
        public static List<Student> listStudent;

        public void ShowStudent()
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                Console.WriteLine("id :"+listStudent[i].Id+" name: "+listStudent[i].Name+" age: "+listStudent[i].Age+" Address: "+listStudent[i].Address+" gpa: "+listStudent[i].Gpa);
            }
        }

        public int SortById()
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (listStudent[i].Gpa > listStudent[i + 1].Gpa)
                {
                    return 1;
                }else if (listStudent[i].Gpa == listStudent[i + 1].Gpa)
                    return 0;
                
            }

            return -1;
        }

        public int SortByName(Student other)
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (listStudent[i].Name.CompareTo(listStudent[i + 1].Name)>0)
                {
                    return 1;
                }else if (listStudent[i].Name.CompareTo(listStudent[i + 1].Name)==0)
                    return 0;
                
            }

            return -1;
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
                    x=Console.WriteLine()

                } while (x == 5);



            }
        }


    }
}