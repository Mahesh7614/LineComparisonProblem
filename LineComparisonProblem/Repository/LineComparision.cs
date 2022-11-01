using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem.Repository
{
    public class LineComparision
    {
        int X1, X2, Y1, Y2;

        public LineComparision(int x1, int x2, int y1, int y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }
        public void CalculateLengthOfLine()
        {
            Console.WriteLine("Co-ordinates of Line are \nX1 = " + X1 + "\nX2 = " + X2 + "\nY1 = " + Y1 + "\nY2 = " + Y2);
            double LengthOfLine = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2));
            Console.WriteLine("Length of Line of given 4 Co-ordinates is : " + Math.Round(LengthOfLine, 5));
        }
    }
}
