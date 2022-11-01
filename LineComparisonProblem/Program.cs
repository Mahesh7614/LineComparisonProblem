using LineComparisonProblem.Repository;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var obj = LineComparision.UserInputForLine1();
            LineComparision line = new LineComparision(obj.X1,obj.X2,obj.Y1,obj.Y2);
            double length1 = line.CalculateLengthOfLine();
     
            var obj1 = LineComparision.UserInputForLine2();
            LineComparision line1 = new LineComparision(obj1.X1,obj1.X2,obj1.Y1,obj1.Y2);
            double length2 = line1.CalculateLengthOfLine();

            if (length1 > length2)
            {
                Console.WriteLine("Length of Line 1 is Greater than Length of Line 2");
            }
            else if (length1 < length2)
            {
                Console.WriteLine("Length of Line 1 is smaller than Length of Line 2");
            }
            else
            {
                Console.WriteLine("Length of Two Lines are Same");
            }
        }
    }
}