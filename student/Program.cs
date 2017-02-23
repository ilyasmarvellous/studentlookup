using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        public class student
        {
            public string firstname;
            public string lastname;
            public string student_id;
            public DateTime dob;
        }
       
        public static void Main(string[] args)
        {
            List<student> stu = new List<student>();
            x:
            student s = new student();

            Console.WriteLine("Select your option 1.Register 2.Lookup");
            int a = int.Parse(Console.ReadLine());
           switch(a)
            {
                case 1:
                    Console.WriteLine("Enter the first name");
                    s.firstname = Console.ReadLine();
                    Console.WriteLine("Enter last name");
                    s.lastname = Console.ReadLine();
                    Console.WriteLine("Enter the student id");
                    s.student_id = Console.ReadLine();
                    Console.WriteLine("Enter the date of birth");
                    s.dob = Convert.ToDateTime(Console.ReadLine());
                    stu.Add(s);
                    Console.WriteLine("Enter 1.To Exit 2. To continue");
                    int z = int.Parse(Console.ReadLine());
                    if (z == 1)
                    {
                        break;
                    }
                    else
                    {
                        goto x;
                    }
                        
                   
                case 2:
                    Console.WriteLine("Enter the student id for look up");
                    string std_id = Console.ReadLine();
                    foreach( var i in stu)
                    {
                        if(i.student_id == std_id)
                        {
                            Console.WriteLine("the student details are " + i.firstname + " " + i.lastname
                                + " " + i.student_id + " " + i.dob);
                            break;
                        }
                    }
                    Console.WriteLine("Enter 1.To Exit 2. To continue");
                    z = int.Parse(Console.ReadLine());
                    if (z == 1)
                    {
                        break;
                    }
                    else
                    {
                        goto x;
                    }
                default:
                    Console.WriteLine("exit the system");
                    break;
            }
        }
    }
}
