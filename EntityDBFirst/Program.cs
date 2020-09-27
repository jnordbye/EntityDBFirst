using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // test of database first in Entity framework
            var dbContext = new PlutoDBContext();
            var courses = dbContext.GetCourses();

            foreach(var c in courses)
            {
                Console.WriteLine(c.Title );
            }

            Console.WriteLine("\n\tPress enter to exit");
            Console.ReadLine();   // pause before exit
        }
    }
}