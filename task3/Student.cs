using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   
        class Student
        {
            public string Name;
            public string Surname;
            public int Age;
            public string Group;
            public int Point;
            public bool IsGraduated;

            public string GetStudentFullName()
            {
                string fullname = Name + " " + Surname;
                return fullname;
            }

            public void GetStudent()
            {
            Console.WriteLine("Mezun olub olmadiginizi daxil edin");
            IsGraduated = Convert.ToBoolean(Console.ReadLine());
                if (IsGraduated==true)
                {
                    Console.WriteLine(Name + " " + Surname + " " + "Group:" + Group + " " + "Age:" + Age + " " + "Point:" + Point);
                    Console.WriteLine("Telebe mezun olub");
                }
                else if(IsGraduated==false)
                {
                    Console.WriteLine("Telebe mezun olmayib");
                }

            }

            public void GetGrade()
            {
            Console.WriteLine("Balinizi daxil edin");
            Point =Convert.ToInt32( Console.ReadLine());
                if (Point > 80)
                {
                    Console.WriteLine("Telebe imtahana daxil ola biler");
                }
                else
                {
                    Console.WriteLine("Telebe imtahana daxil ola bilmez");
                }
            }

        }
    }

