using System;
using System.Collections.Generic;

namespace AP.Properties.Assignment5
{
    public class PhoneBook:Phone
    {
       public List<PhoneNumber> phoneList=new List<PhoneNumber>();
       public override void InsertPhone(string name, string phone)
       {
           foreach (PhoneNumber p in phoneList)
           {
               if (p.name.Equals(name))
               {
                   if (p.phone.Equals(phone))
                   {
                       return;
                   }

                   p.phone = p.phone + ":" + phone;
                   return;
               }
           }
           phoneList.Add(new PhoneNumber(name,phone));
       }

       public override void RemovePhone(string name)
       {
           foreach (PhoneNumber p in phoneList)
           {
               if(p.name.Equals(name))
               {
                   phoneList.Remove((p));
                   return;
               }
           }
       }

       public override void UpdatePhone(string name, string newPhone)
       {
           foreach (PhoneNumber p in phoneList)
           {
               if (p.name.Equals(name))
               {
                   p.phone = newPhone;
                   return;
               }
           }
           
       }

       public override PhoneNumber searchPhone(string name)
       {
           foreach (PhoneNumber p in phoneList)
           {
               if (p.name.Equals(name))
               {
                   return p;
               }
           }

           return null;
       }
    }
}