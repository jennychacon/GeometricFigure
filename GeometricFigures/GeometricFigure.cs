using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public abstract class GeometricFigure
    {
        #region Constructors
        public GeometricFigure()
        {

        }
        #endregion
        #region Methods
        public abstract double Area();

        public abstract double PerimeterOrVolumen();
        #endregion
    }
}
