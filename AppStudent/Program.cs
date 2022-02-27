using System;

namespace AppStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];
            Console.WriteLine("-------------------Welcome------------------");
            Console.WriteLine("----1 AddStudent ------- 2 AddGroup ------ 3 SearchStudent ----- 4 SearchGroup--");
           bool succes = int.TryParse(Console.ReadLine(), out int menunumber);
            if (succes)
            {
                switch (menunumber)
                {
                    case (int)Menu.AddStudent:
                        if (groups.Length == 0)
                        {
                            Console.WriteLine("there is no group... You must create group");
                            Group group1 = new Group();
                            Console.WriteLine("Group Name: ");
                            string GroupName = Console.ReadLine();
                            group1.Name = GroupName;
                            Console.WriteLine("You can create Student now...");
                            Student[] students = new Student[0];
                            l2:
                            Student newStudent = new Student();
                            Console.WriteLine("Name of Student: ");
                            string StudentName = Console.ReadLine();
                            newStudent.Name = StudentName;
                            Console.WriteLine("Surname: ");
                            string StudentSurname = Console.ReadLine();
                        l1:
                            Console.WriteLine("Age");
                            bool successAge = int.TryParse(Console.ReadLine(), out int age);
                            if (successAge && age>0&& age<165)
                            {

                                newStudent.Age = age;

                            }
                            else
                            {
                                Console.WriteLine("Yash duzgun deyl!..");
                                goto l1;
                            }
                            Array.Resize(ref students, students.Length + 1);
                            students[students.Length - 1] = newStudent;
                            group1.Students = students;
                            Array.Resize(ref groups, groups.Length + 1);
                            groups[groups.Length - 1] = group1;
                            Console.WriteLine("Yeni telebe daxil etmek isteyirsinizmi eyni qrupa: Yes=1  No=2 ");
                            bool successNewStudent = int.TryParse(Console.ReadLine(), out int add);
                            if (successNewStudent && add == 1)
                            {
                                goto l2;
                            }

                            group1.Students = students;


                        }
                      
                        break;
                    case (int)Menu.AddGroup:
                        break;
                    case (int)Menu.SearchStudent:
                        break;
                    case (int)Menu.SearchGroup:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
