using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudent
{
    class Student
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Id;
        public static int counter = 0;

        public Student()
        {
            counter++;
            Id = counter;
        }

    }
}
