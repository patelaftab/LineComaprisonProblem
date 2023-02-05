using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class Program
    {
        static void Main(string[] args)
        {

            Line line = new Line(1, 2, 3, 4);
            line.Length();
            Console.ReadLine();
        }
    }
}
