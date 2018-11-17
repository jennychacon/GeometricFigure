using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Circle : GeometricFigure
    {
        #region Properties
        public double R { get; set; }
        #endregion

        #region Constructors
        public Circle(double r)
        {
            this.R = r;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return Math.PI * (Math.Pow(this.R,2));
        }

        public override double PerimeterOrVolumen()
        {
            return 2 * Math.PI * this.R;
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
