using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Cube : Square
    {

        #region Constructors
        public Cube(double a) : base(a)
        {
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return 6 * (Math.Pow(this.A, 2));
        }

        public override double PerimeterOrVolumen()
        {
            return Math.Pow( this.A , 3);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
