using VS2017EditorConfigProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2017EditorConfigProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 max = 100;
            for (int i = 0; i < max; i++)
            {
                Course c = new Course();
                c.CourseId = 1;
                c.CourseName = "Visual Studio 2017 New Features";
                c.Capacity = 39;

                ConsoleColor color = ConsoleColor.Red;
                if (color == ConsoleColor.Red)
                {
                    Console.WriteLine(c.CourseId);
                }
            }
        }
    }
}
