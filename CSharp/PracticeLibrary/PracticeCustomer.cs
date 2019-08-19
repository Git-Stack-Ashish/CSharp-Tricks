using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLibrary
{
    public static class PracticeCustomer
    {
        public static int CustId { get; set; }

        static PracticeCustomer()
        {

        }

        public static void GetCustomer()
        {
            Console.WriteLine("Inside Customer.GetCustomer method");
        }
    }    
}
