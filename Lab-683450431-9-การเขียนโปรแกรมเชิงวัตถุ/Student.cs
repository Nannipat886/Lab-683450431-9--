using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_683450431_9_การเขียนโปรแกรมเชิงวัตถุ
{
    public class Student : Person
    {
        private int score;

        public Student(string name, string id, int score)
            : base(name, id)
        {
            this.score = score;
        }

        public int GetScore()
        {
            return score;
        }

        public string GetGrade()
        {
            if (score >= 80) return "A";
            if (score >= 75) return "B+";
            if (score >= 70) return "B";
            if (score >= 65) return "C+";
            if (score >= 60) return "C";
            if (score >= 55) return "D+";
            if (score >= 50) return "D";
            return "F";
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"ชื่อนักศึกษา {name} รหัสนักศึกษา ({id}) คะแนน: {score} เกรด: {GetGrade()}");
            Console.WriteLine();
        }
    }
}
