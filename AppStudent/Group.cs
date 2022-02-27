using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStudent
{
    class Group
    {
        public int Id;
        public string Name;
       
        public Student[] Students;
        public static int counter = 0;

        public Group()
        {
            counter++;
            Id = counter;
        }

    }
}
