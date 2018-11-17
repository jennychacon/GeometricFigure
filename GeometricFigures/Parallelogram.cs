using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Parallelogram : Rectangle
    {
       

        #region Properties
        public double H { get; set; }


        #endregion

        #region Constructors
        public Parallelogram(double a, double b, double h) : base(a, b)
        {
            this.H = h;
            
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return this.B * this.H;
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
