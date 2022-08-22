using Microsoft.AspNetCore.Mvc;
using Triangle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangle.Controllers
{
    public class TriangleController : Controller
    {
        public TriangleController()
        {
            
        }
        public string Info(double side1, double side2, double side3)
        {
            double side_1 = Math.Max(side1, Math.Max(side2, side3));
            double side_2;
            double side_3 = Math.Min(side1, Math.Min(side2, side3));
            if ((side1 > side3) & (side1 < side_1) ) { side_2 = side1; }
            else if ((side2 > side3) & (side2 < side_1)) { side_2 = side2; }
            else { side_2 = side3; }
            return $"Triangle : ( [side_1], [side_2], [side_3]) \n  ";
            
        }
        public string IsIsosceles(double side1, double side2, double side3)
        {
            
            if ((side1 == side2) | (side1 == side3) | (side3 == side2))
            {
                return "True";
            }
            else return "False";
        }
        public string IsEquilateral(double side1, double side2, double side3)
        {

            if ((side1 == side2) & (side1 == side3))
            {
                return "True";
            }
            else return "False";
        }
        public string IsRightAngled(double side1, double side2, double side3)
        {
            double side1_2 = Math.Pow(side1, 2);
            double side2_2 = Math.Pow(side2, 2);
            double side3_2 = Math.Pow(side2, 2);
            //double max = Math.Max(side1, Math.Max(side2, side3));
            if ( (side1_2 == side2_2+side3_2) | (side3_2==side2_2+side1_2) | (side2_2 == side3_2 + side1_2) )
            {
                return "True";
            }
            else return "False";
        }
        public double Perimeter(double side1, double side2, double side3)
        {
           double perimeter = side1 +side2+side3; 
            return perimeter;
        }
        public double Area(double side1, double side2, double side3)
        {
            double perimeter = (side1 + side2 + side3)/2;
            double area = Math.Sqrt(perimeter*(perimeter-side1)*(perimeter-side2)*(perimeter-side3));
            return area;
        }
    }
}
