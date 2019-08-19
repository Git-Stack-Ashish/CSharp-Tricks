using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Employee
    {
        private string _name;

        public string Name
        {
            get
            {
                return this._name == null ? "no name" : this._name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("invalid name");
                }
                this._name = value;
            }
        }
        public int Age { get; set; }



        public Employee()
        {
            Console.WriteLine("Ctor of Employee");
        }

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Employee(string msg)
        {
            Console.WriteLine(msg);
        }

        public void GetFullName()
        {

            Console.WriteLine("GetFullName from EMployee ");
        }
    }

    public class PermEmployee : Employee
    {
        public int YearlySal { get; set; }

        public PermEmployee() : base("parametarised ctor of Employee")
        {
            Console.WriteLine("Ctor of PermEmployee");
        }

        public void CalcSal()
        {
        }

        public new void GetFullName()
        {
            Console.WriteLine("GetFullName from PermEmployee");
        }
    }

    public class ContractEmployee : Employee
    {
        public int HourlySal { get; set; }

        public ContractEmployee()
        {
            Console.WriteLine("Ctor of ContractEmployee");
        }
    }

    public class A : PermEmployee
    {
        public void AMethod()
        {
            Console.WriteLine("ctor of A");
        }
    }

    public class Teacher
    {
        public int name { get; set; }
    }

    public class Student : Teacher
    {
        public int id { get; set; }

        public Student()
        {
            Console.WriteLine("student class");
        }

        public Student(int idNew)
        {
            Console.WriteLine("student class parametarised");
            this.id = idNew;
        }
    }

    public class Normal : NormalBase
    {
        
        public Normal()
        {
            id = 5;
            Console.WriteLine("normal ctor = " + id);
        }

        static Normal()
        {
            id = 10;
            Console.WriteLine("static ctor = " + id);
            print();
        }

        public void MethodTest()
        {
        }
    }

    public class NormalBase
    {
        public static int id { get; set; }
        public NormalBase()
        {
            id = 15;
            Console.WriteLine("Normalbase ctor = " + id);
        }

        public void MethodTest()
        {
        }

        public static void print()
        {
            Console.WriteLine("inside print");
        }
    }
}
