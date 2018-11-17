using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Square : GeometricFigure
    {

        #region Properties
        public double A { get; set; }
        #endregion

        #region Constructors
        public Square(double a)
        {
            this.A = a;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return Math.Pow(this.A, 2);
        }

        public override double PerimeterOrVolumen()
        {
            return 4 * this.A;
        }

        public override string ToString()
        {
            string figureName = this.GetType().Name;
            return $"{figureName} \n\t" +
                    $"Area..............:{this.Area(),12:N2}\n\t" +
                    $"Perimeter.........:{this.PerimeterOrVolumen(),12:N2}";
        }
        #endregion

    }
}
