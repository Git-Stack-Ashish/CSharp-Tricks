using PracticeLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public delegate bool IsPromotable(Emp emp);

    class Program
    {

        //param array is optional
        public static void arrayparam(params int[] num)
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40 };

            var b = intList.Where(s => s % 2 == 0).ToList();

            Console.WriteLine("Length is - " + num.Length);
        }

        public static void arrayparam1(int x, params int[] num)
        {
            Console.WriteLine("Length is - " + num.Length);
        }

        public static void RefParam(ref int j)
        {
            j = 10 * 11;
        }

        public static void DoWhile()
        {
            string option = string.Empty;
            int cost = 0;
            do
            {

                int order = 0;


                do
                {
                    Console.WriteLine("select 1/2");
                    order = int.Parse(Console.ReadLine());
                    switch (order)
                    {
                        case 1:
                            cost += 1;
                            break;
                        case 2:
                            cost += 2;
                            break;
                        default:
                            cost += 0;
                            break;
                    }

                } while (order != 1 && order != 2);

                do
                {
                    Console.WriteLine("Select YES/NO");
                    option = Console.ReadLine();
                } while (option.ToUpper() != "YES" && option.ToUpper() != "NO");

            } while (option.ToUpper() != "NO");

            Console.WriteLine("Total cost = " + cost);
            Console.ReadLine();
        }

        //delegate
        public delegate void FunctionDelegate(string msg);


        //method to call from delegate
        public static void Hello(string strMsg)
        {
            Console.WriteLine(strMsg);
        }


        //Multicast delegate:
        public delegate void MulticastDelegate();

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        public static int Add(int one, int two, [Optional]int[] restInt, int three = 0)
        {
            return one + two + three;
        }

        struct S
        {
            public int i;
        }

        static void f1(S s)
        {
            s.i += 1;

        }

        static String f2()
        {
            S s;
            s.i = 42;
            f1(s);
            return s.i.ToString();
        }

        static int f3()
        {
            String s = "Hello\0world";
            return s.Length;
        }

        //3

        //static void f1(out string s1, ref string s2)
        //{
        //   // s1 += "0";
        //    s2 += "0";
        //}
        static String f4()
        {
            string s1 = "42", s2 = "43";
            //f1(out s1, ref s2);
            return s1 + s2;
        }

        //4
        static void f14(ref String s1, String s2)
        {
            s1 += "0";
            s2 += "0";
        }
        static String f5()
        {
            String s1 = "42", s2 = "43";
            f14(ref s1, s2);
            return s1 + s2;
        }

        //5
        static String f6(bool x)
        {
            int i = 2;
            //if (x)
            //{
            //    int i = 3;
            //}
            //else
            //{
            //    int i = 4;
            //}
            return i.ToString();
        }

        //get nth highest element in an array
        public static int Globant1(int[] arr, int n)
        {
            int[] inp = { 1, 4, 3, 5, 7, 10 };
            var a = inp.ToList();
            var op = a.OrderByDescending(b => b).Take(3).Skip(2).FirstOrDefault();
            var aa = a.OrderByDescending(b => b).ToList();
            var aaa = aa[1];

            //IQueryable abc = (IQueryable)a.Select(i => i);

            int output = 0;

            Array.Sort(arr);
            Array.Reverse(arr);
            output = arr[n - 1];

            return output;
        }

        public static int Globant2(int numOfStairs)
        {
            int x = numOfStairs;
            int output = 0;
            if (numOfStairs <= 3)
                return numOfStairs;
            else
            {
                output += 1;
                while (x > 1)
                {
                    output += x - 1;
                    x = x - 2;
                }

                if (x == 1)
                {
                    output += 1;
                }
            }

            return output;
        }

        public static int FindHighestSum(int n)
        {
            int[] inp = { 1, 2, -1, -2, 3, 10, -5, 0, 1, 5, -1, -5 };

            //n = 3;
            int maxSum = 0;
            var output = 0;

            for (int i = 0; i < inp.Length - n; i++)
            {
                var p = 0;
                var sum = 0;

                while (p < n)
                {
                    sum += inp[i + p];
                    p++;
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    output = i;
                }
            }

            return output + 1;
        }


        public static string result;

        static async Task<string> SaySomething()
        {
            //await Task.Delay(5);
            Thread.Sleep(5);
            result = "Hello world!";
            return "Something";
        }

        delegate void Printer();

        public static dynamic DynamicMethod(bool check)
        {
            if (check)
                return 1;
            else
                return 0;
        }

        readonly int ra;
        public Program()
        {
            ra = 100;
        }

        public static void Main(string[] args)
        {
            try
            {
                //const readonly and static
                const int ca = 10;
                const int cb = 20;
                const int cc = ca + cb;
                int ia = 30;
                //const int cd = cc + ia;//this will give error both cc and ia should const
                
                char ch1 = 'c';
                string str1 = "s";
                var chst = str1.Equals(ch1);
                //var chst1 = str1 == ch1;

                Console.WriteLine(DynamicMethod(true));

                //dynamic keyword
                dynamic dynamic1 = 10;
                dynamic1++;
                Console.WriteLine($"dynamic1 type is {dynamic1.GetType().ToString()} and value is {dynamic1}");

                dynamic1 = "ashish";
                Console.WriteLine($"dynamic1 new type is {dynamic1.GetType().ToString()} and value is {dynamic1}");


                SaySomething();
                Console.WriteLine(result);

                List<Printer> printers = new List<Printer>();

                int pr = 0;
                for (; pr < 10; pr++)
                {
                    printers.Add(delegate { Console.WriteLine(pr); });
                }

                foreach (var print in printers)
                {
                    print();
                }

                var emps = new List<Emp>() { new Emp(1, "ashish", 10, 10), new Emp(2, "amol", 20, 5), new Emp(3, "nisha", 30, 4) };
                var empaddr = new List<EmpAddr>() { new EmpAddr(1, 1, "F1"), new EmpAddr(2, 2, "F2"), new EmpAddr(4, 4, "F4") };

                var innerJoin = emps.Join(empaddr, em => em.Id, ea => ea.EmpId, (em, ea) => new { Id = em.Id, Name = em.Name, FLatName = ea.FlatName }).ToList();

                var leftJoin = emps.GroupJoin(empaddr, em1 => em1.Id, ea1 => ea1.EmpId, (em1, ea1) => new { Emp = em1, EmpAddr = ea1 })
                    .SelectMany(
                        em1 => em1.EmpAddr.DefaultIfEmpty(),
                        (em1, ea1) => new { Emp = em1, EmpAddr = ea1 }
                    ).ToList();

                var rightJoin = empaddr.GroupJoin(emps, ea => ea.EmpId, em => em.Id, (aaa, ee) => new { Addr = aaa, Emp = ee })
                    .SelectMany(
                        zea => zea.Emp.DefaultIfEmpty(),
                        (zea, zem) => new { EmpAddr = zea, Emp = zem }
                    ).ToList();

                //var rightJoin = empaddr.GroupJoin(emps, ea1 => ea1.EmpId, em1 => em1.Id, (ea1, em1) => new { right = ea1, left = em1 }).SelectMany(
                //        p => p.right.
                //    );


                NonStaticClass nsc1 = new NonStaticClass();
                NonStaticClass nsc2 = new NonStaticClass();
                //NonStaticClass.method1(1);

                NonStaticClass nscc1 = new NonStaticClassChild();
                NonStaticClassChild nscc2 = new NonStaticClassChild();

                nsc1.method1(1);
                nscc1.method1(2);
                nscc2.method1(3);

                //passing fun as a param which will use private variable insiede it
                CircleNew cn = new CircleNew();
                var output = cn.Calculate(r => 2 * Math.PI * r);

                var highestSum = FindHighestSum(3);
                Console.WriteLine($"Index of highest sum of array is {highestSum}");

                int[] array = { 3, 2, 1, 4, 6, 5, 10, 8, 9, 7 };
                var globant1 = Globant1(array, 2);
                Console.WriteLine($"nth highest element in an array is : {globant1} ");

                //problem is not complete
                var globant2 = Globant2(9);
                Console.WriteLine($"Possible combination of stairs climbing by 1 or 2 stairs at a time is : {globant2}");

                var zz = f2();
                var ss = f3();
                var yy = f5();
                var xx = f6(true);
                var zzz = 100;
                //do while program
                DoWhile();

                //ref params
                //int i = 10;
                //RefParam(ref i);
                //Console.WriteLine(i);
                //Console.ReadLine();

                //array params
                //arrayparam(new int[3] { 1,2,3});
                //arrayparam();
                //arrayparam1(1, 2);

                //
                Customer s = new Customer();
                s.PrintName();
                s.GetSample();

                //static ctor
                Circle c1 = new Circle(5);
                c1.CalcArea();

                //static
                Circle c2 = new Circle(6);
                c2.CalcArea();

                //inheritance
                PermEmployee p = new PermEmployee();
                ContractEmployee c = new ContractEmployee();

                Employee p1 = new A();
                p1.GetFullName();

                p.GetFullName();

                Employee e = new PermEmployee();
                e.GetFullName();
                Employee e1 = new A();

                //class vs struct
                ClientStruct cs = new ClientStruct(100, "ashish");
                ClientStruct cs1 = cs;
                cs1.Name = "Amol";
                Console.WriteLine("Structs names cs.name  - {0} and cs1.name - {1} \n", cs.Name, cs1.Name);

                Employee e2 = new Employee("ashish", 20);
                Employee e3 = e2;
                e3.Name = "amol";

                Console.WriteLine("Classes names e2.name  - {0} and e3.name - {1} \n", e2.Name, e3.Name);

                //inheritance
                Customer x = new Customer();
                ICustomer x1 = new Customer();

                //explicit interface implentation
                Customer x2 = new Customer();
                ((ICustomer)x2).GetAge();
                ((ICustomer2)x2).GetAge();

                //delgate
                FunctionDelegate fd = new FunctionDelegate(Hello);
                fd("called from delegate \n");

                List<Emp> empList = new List<Emp>();
                empList.Add(new Emp { Id = 1, Name = "Ashish", Exp = 5, Salary = 10 });
                empList.Add(new Emp { Id = 2, Name = "Amol", Exp = 4, Salary = 20 });
                empList.Add(new Emp { Id = 3, Name = "Nisha", Exp = 2, Salary = 5 });
                empList.Add(new Emp { Id = 4, Name = "XYZ", Exp = 7, Salary = 15 });

                Emp.PromoteEmp(empList, emp => emp.Exp > 3);//passing delegate using lambda expr

                //Multicast delegate:
                MulticastDelegate md = new MulticastDelegate(Method1);
                md += Method2;
                md += Method3;
                md -= Method2;
                md();

                //Reflection               
                Type t = Type.GetType("CSharp.Customer");
                PropertyInfo[] props = t.GetProperties();
                MethodInfo[] methods = t.GetMethods();
                ConstructorInfo[] ctors = t.GetConstructors();

                foreach (PropertyInfo pi in props)
                {
                    Console.WriteLine(pi.PropertyType.Name + " " + p.Name);
                }

                //late binding
                Assembly a = Assembly.GetExecutingAssembly();
                Type customer = a.GetType("CSharp.Customer");
                object obj = Activator.CreateInstance(customer);
                MethodInfo method = customer.GetMethod("PrintName");
                method.Invoke(obj, null);

                //abstract class
                EmpChild ec = new EmpChild();
                EmpChild ec1 = new EmpChild("ashish");

                Console.WriteLine("Addition is + {0}", Add(1, 2));


                int[] arr = new int[5] { 0, 1, 2, 3, 4 };

                for (int i = 0; i < arr.Length; i++)
                {
                    i = i + i;
                    Console.WriteLine("\n val is = " + i);
                }

                foreach (int i in arr)
                {
                    //i = i + 1;

                }


                Console.WriteLine(ec.ToString());


                Teacher t1 = new Teacher();
                Student s1 = new Student();

                Normal n = new Normal();

                int[] z = new int[0];
                Console.WriteLine("z value is = ", z);

                Console.WriteLine("orange = {0}, yellow = {1}, black={2}, white = {3}", (int)colors.orange, (int)colors.yellow, (int)colors.black, (int)colors.white);

                PracticeLibrary.PracticeCustomer.GetCustomer();


                //check anagrams
                string i1 = "good";
                string i2 = "doog";

                string aa = String.Concat(i1.OrderBy(i => i));
                string bb = String.Concat(i2.OrderBy(i => i));

                if (aa == bb)
                {
                    Console.WriteLine("{0} and {1} are anagrams", i1, i2);
                }
                else
                {
                    Console.WriteLine("{0} and {1} are not anagrams", i1, i2);
                }

                //check palindrome
                string palindrome = "nayan";

                var reverse = String.Concat(palindrome.Reverse());

                if (palindrome == reverse)
                {
                    Console.WriteLine("{0} is palindrome", palindrome);
                }

                //reverse each word in string
                string inputString = "Hi am ashish";
                string reverseString = string.Join(" ", inputString.Split(' ').Select(xs => new String(xs.Reverse().ToArray())));
                Console.WriteLine("reverse statement is : {0}", reverseString);

                //sagitech to check list
                List<Normal> lstNormal = new List<Normal>();
                NormalBase nbase = new NormalBase();
                NormalBase nbase1 = new Normal();
                lstNormal.Add(new Normal());
                //lstNormal.Add(new NormalBase());//not possible
                //lstNormal.Add((Normal)nbase);//not possible
                //lstNormal.Add(nbase1);//not possible

                List<NormalBase> lstNormalBase = new List<NormalBase>();
                NormalBase nbase2 = new NormalBase();
                NormalBase nbase3 = new Normal();
                Normal normal = new Normal();
                lstNormalBase.Add(new Normal());
                lstNormalBase.Add(new NormalBase());
                lstNormalBase.Add(nbase2);
                lstNormalBase.Add(nbase3);
                lstNormalBase.Add(normal);

                //arraylist
                ArrayList arrLst = new ArrayList();
                arrLst.Add(1);
                arrLst.Add("one");
                arrLst.Add(1.001);

                foreach (var item in arrLst)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\n---String Interpolation--");
                var str = "Interpolation";
                Console.WriteLine($"this is an example of {str}");

                //Environment.Exit(0);
                //Console.ReadLine();

                AbsClass ac = new PureClass();
                ac.Method1();
                ac.Method2();

                PureClass pc = new PureClass();
                pc.Method1();
                pc.Method2();

            }
            catch (Exception ex)
            {
                Console.WriteLine("catch block");
            }
            finally
            {
                Console.WriteLine("Finally block");
                Console.ReadLine();
            }

        }
    }



    public enum colors : int
    {
        orange,
        yellow,
        green = 5,
        black,
        pink = 10,
        white
    }

    //interface
    public interface ISample
    {
        string id { get; set; }
        string name { get; }

        void GetSample(string name = "ashish");
    }

    interface ICustomer
    {
        void GetAge();
    }

    public interface ICustomer2
    {
        void GetAge();
    }

    //abstract class
    public abstract class AbsClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("AbsClass.Method1");

        }

        public abstract void Method2();
    }

    public class PureClass : AbsClass
    {
        public override void Method2()
        {
            Console.WriteLine("AbsClass.Method2");
        }
    }

    //static field
    class Circle
    {
        static float pi;
        int radius;

        static Circle()
        {
            Circle.pi = 3.14F;
            Console.WriteLine("Static ctor");
        }

        public Circle(int radius)
        {
            this.radius = radius;
            Console.WriteLine("Public ctor");
        }

        public void CalcArea()
        {
            Console.WriteLine("Area is = " + Circle.pi * this.radius * this.radius);
        }
    }

    class Customer : ICustomer, ICustomer2, ISample
    {
        public string _name { get; set; }
        public string id { get; set; }

        public string name { get; }

        public Customer() : this("no name")
        {
        }

        public Customer(string name)
        {
            this._name = name;
        }

        public void PrintName()
        {
            Console.WriteLine("Name is = " + _name);
        }

        //explicit implementation
        void ICustomer.GetAge()
        {
            Console.WriteLine("Interface ICustomer method;");
        }

        void ICustomer2.GetAge()
        {
            Console.WriteLine("Interface ICustomer2 method;");
        }

        public void GetSample(string name = "amol")
        {
            Console.WriteLine("inside GetSample and name is {0}", name);
        }

        //destructor
        ~Customer()
        {
            //clean up code 
        }
    }

    //struct
    public struct ClientStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ClientStruct(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    //abstract class
    public abstract class EmpAbstract
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public EmpAbstract()
        {
            this.Id = new Guid();
            Console.WriteLine("parameter less ctor of abstract class  \n");
        }

        public EmpAbstract(string name)
        {
            this.Name = name;
            Console.WriteLine("parameterised ctor of abstract class - {0} \n", name);

        }
    }

    //child class inheriting abstract class
    public class EmpChild : EmpAbstract
    {
        public EmpChild()
        {
            Console.WriteLine("parameter less ctor of EmpChild class \n");

        }

        //calling base class ctor
        public EmpChild(string name) : base(name)
        {
            Console.WriteLine("parameterised ctor of EmpChild class - {0} \n", name);

        }
    }

    public class NonStaticClass
    {
        static NonStaticClass()
        {
            Console.WriteLine("This is static constructor of NonStaticClass");
        }

        public NonStaticClass()
        {
            Console.WriteLine("This is default constructor of NonStaticClass");
        }

        //public static void method1(int id)
        //{
        //    var a = id;
        //}

        public void method1(int id)
        {
            var a = id;
            Console.WriteLine($"Method of NonStaticClass : {a}");
        }
    }

    public class NonStaticClassChild : NonStaticClass
    {
        static NonStaticClassChild()
        {
            Console.WriteLine("This is static constructor of NonStaticClassChild");
        }

        public NonStaticClassChild()
        {
            Console.WriteLine("This is default constructor of NonStaticClassChild");
        }

        public void method1(int id)
        {
            var a = id;
            Console.WriteLine($"Method of NonStaticClassChild : {a}");
        }
    }

    public sealed class CircleNew
    {
        private double radius = 5;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
