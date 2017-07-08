using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Person
    {
        public int ID;
        public String name;
        public String phoneNumber;

        public Person(int ID, String name, String phoneNumber)
        {
            this.ID = ID;
            this.name = name;
            this.phoneNumber = phoneNumber;

        }

    }
    class Professor : Person
    {
        public String office;
        public String major;
        
        Professor(int ID, String name, String phoneNumber, String office, String major) : base(ID, name, phoneNumber)
        {
            this.office = office;
            this.major = major;
        }
    }
    class Faculty : Person
    {
        public String office;

        Faculty(int ID, String name, String phoneNumber, String office) : base(ID, name, phoneNumber)
        {
            this.office = office;
        }
    }
    class Rectangle : Person
    {
        public int grade = 0;

        Rectangle(int ID, String name, String phoneNumber, String office) : base(ID, name, phoneNumber)
        {
            this.grade = grade;
        }
    }
}
