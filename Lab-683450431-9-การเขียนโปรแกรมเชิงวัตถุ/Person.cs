using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_683450431_9_การเขียนโปรแกรมเชิงวัตถุ
{
    public abstract class Person
    {
        protected string name;
        protected string id;

        public Person(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public abstract void ShowInfo();
    }
}