using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Sphere : Circle
    {

        #region Constructors
        public Sphere(double r) : base(r)
        {
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return 4 * Math.PI * (Math.Pow(this.R, 2));
        }

        public override double PerimeterOrVolumen()
        {
            return (4 / 3) * Math.PI * (Math.Pow(this.R, 3));
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
