using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Emp
    {
        public Emp()
        {
           
        }

        public Emp(int id, string name, int sal, int exp)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = sal;
            this.Exp = exp;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Exp { get; set; }

        public static void PromoteEmp(List<Emp> empList, IsPromotable isPromotable)
        {
            foreach(Emp e in empList)
            {
                if (isPromotable(e))
                {
                    Console.WriteLine(e.Name + " is Promoted \n");
                }
            }

        }
    }

    public class EmpAddr
    {
        public EmpAddr(int id, int empid, string name)
        {
            AddrId = id;
            this.EmpId = empid;
            this.FlatName = name;
        }

        public int AddrId { get; set; }
        public int EmpId { get; set; }
        public string FlatName { get; set; }
    }
        
}
