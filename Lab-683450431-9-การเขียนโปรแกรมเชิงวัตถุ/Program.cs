using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_683450431_9_การเขียนโปรแกรมเชิงวัตถุ
{
    class Program
    {
        static void Main()
        {
            Console.Write("ชื่อรายวิชา: ");
            string cname = Console.ReadLine();

            Console.Write("รหัสรายวิชา: ");
            string cid = Console.ReadLine();

            Course course = new Course(cname, cid);

            while (true)
            {
                Console.WriteLine("1.รายวิชาไหม่");
                Console.WriteLine("2.เพิ่มชื่อนักศึกษา");
                Console.WriteLine("3.ดูรายชื่อนักศึกษา");
                Console.WriteLine("4.ดูคะแนนโดยรวม");
                Console.WriteLine("0.ออกจากระบบ");

                string cmd = Console.ReadLine();

                if (cmd == "0") break;

                if (cmd == "2")
                {
                    Console.Write("ชื่อนักศึกษา: ");
                    string name = Console.ReadLine();

                    Console.Write("รหัสนักศึกษา: ");
                    string id = Console.ReadLine();

                    Console.Write("คะแนน: ");
                    int score = int.Parse(Console.ReadLine());

                    Student s = new Student(name, id, score);
                    course.AddStudent(s);
                }
                else if (cmd == "1")
                {
                    Console.Write("ชื่อรายวิชา: ");
                    cname = Console.ReadLine();
                    Console.Write("รหัสรายวิชา: ");
                    cid = Console.ReadLine();
                    course = new Course(cname, cid);
                }

                else if (cmd == "3")
                {
                    course.ShowAllStudents();
                }

                else if (cmd == "4")
                {
                    course.ShowStatistics();
                }
            }
        }
    }
}
