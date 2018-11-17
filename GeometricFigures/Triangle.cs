using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Triangle : Parallelogram
    {

        #region Properties
        public double C { get; set; }
        #endregion

        #region Constructors
        public Triangle(double a, double b, double h, double c) : base(a, b, h)
        {
            this.C = c;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return (this.B * this.H) / 2;
        }

        public override double PerimeterOrVolumen()
        {
            return this.A + this.B + this.C;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
