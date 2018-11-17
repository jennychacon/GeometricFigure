using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class RegularTetrahedron : Square
    {
        #region Cosntructors
        public RegularTetrahedron(double a) : base(a)
        {
        }
        #endregion

        #region Methods
        public override double Area()
        {
            return base.Area();
        }

        public override double PerimeterOrVolumen()
        {
            return base.PerimeterOrVolumen();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

    }
}
