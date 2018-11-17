using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Cone : Cylinder
    {

        #region Properties
        public double G { get; set; }
        #endregion

        #region Constructors
        public Cone(double r, double h, double g) : base(r, h)
        {
            this.G = g;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return Math.PI * this.R * (this.G + this.R);
        }

        public override double PerimeterOrVolumen()
        {
            return (1 / 3) * Math.PI * Math.Pow(this.R, 2) * this.H;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
