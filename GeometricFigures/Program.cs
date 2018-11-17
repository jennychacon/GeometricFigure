using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(50);
            var rectangle = new Rectangle(50, 50);
            var parallelogram = new Parallelogram(50, 50, 50);
            var triangle = new Triangle(50, 50, 50, 50);
            var trapeze = new Trapeze(50, 50, 50, 50, 70);
            var circle = new Circle(50);
            var cube = new Cube(50);
            var cylinder = new Cylinder(50, 50);
            var cone = new Cone(50, 50, 50);
            var sphere = new Sphere(50);
            //var regularTetrahedron = new RegularTetrahedron(50);

            var objGeometricsFigure = new List<GeometricFigure>();
            objGeometricsFigure.Add(square);
            objGeometricsFigure.Add(rectangle);
            objGeometricsFigure.Add(parallelogram);
            objGeometricsFigure.Add(triangle);
            objGeometricsFigure.Add(trapeze);
            objGeometricsFigure.Add(circle);
            objGeometricsFigure.Add(cube);
            objGeometricsFigure.Add(cylinder);
            objGeometricsFigure.Add(cone);
            objGeometricsFigure.Add(sphere);

            double area = 0;
            double perimeterOrVolume = 0;
            foreach (var figure in objGeometricsFigure)
            {
                Console.WriteLine(figure.ToString());
                area += figure.Area();
                perimeterOrVolume += figure.PerimeterOrVolumen();
            }

            Console.WriteLine("===================================");
            Console.WriteLine($"Total Area...............:{area,12:N2}");
            Console.WriteLine($"Total Perimeter or Volume:{perimeterOrVolume,12:N2}");
            Console.WriteLine("press enter to finish");
            Console.ReadKey();

        }
    }
}
