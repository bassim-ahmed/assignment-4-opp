using Assignment_opp_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_opp_
{
    internal class Rectangle :IRectangle
    { 
       public double Length { get; set; }
    public double Width { get; set; }

    public double Area => Length * Width;

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Area: {Area}");
    }
}
}
