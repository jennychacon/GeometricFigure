using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Cylinder : Circle
    {


        #region Properties
        public double H { get; set; }
        #endregion

        #region Cosntructors
        public Cylinder(double r, double h) : base(r)
        {
            this.H = h;
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return 2 * Math.PI * this.R *(this.H + this.R);
        }

        public override double PerimeterOrVolumen()
        {
            return Math.PI * (Math.Pow(this.R,2)) * this.H;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
