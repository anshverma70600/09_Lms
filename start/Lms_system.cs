using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Lms
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter user name : ");
            string uname = ReadLine();

            WriteLine("Enter user id : ");
            string uid = ReadLine();

            WriteLine("Leave from (DD/MM/YY): ");
            DateTime edate = Convert.ToDateTime(ReadLine());

            WriteLine("Leave to (DD/MM/YY): ");
            DateTime fdate = Convert.ToDateTime(ReadLine());

            WriteLine("Reason for Leave : ");
            string reason = ReadLine();

            Write(uname +" "+ uid +"wants leave from" +" "+ edate +" to " + fdate +" for " + reason);
            Console.Read();

        }
    }
}
