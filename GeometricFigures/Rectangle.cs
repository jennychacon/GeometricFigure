using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Rectangle : Square
    {
        #region Properties
        public double B { get; set; }
        #endregion

        #region Constructors
        public Rectangle(double a, double b) : base(a)
        {
            this.B = b;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return this.B * this.A;
        }

        public override double PerimeterOrVolumen()
        {
            return 2 * (this.B + this.A);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
