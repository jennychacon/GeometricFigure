using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Trapeze : Triangle
    {

        #region Properties
        public double B2 { get; set; }
        #endregion
        #region Constructors
        public Trapeze(double a, double b, double h, double c, double b2) : base(a, b, h, c)
        {
            this.B2 = b2;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return ((this.B + this.B2) * this.H) / 2;
        }

        public override double PerimeterOrVolumen()
        {
            return this.B + this.B2 * this.A + this.C;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
