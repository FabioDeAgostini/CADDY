using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netDxf;
using Autodesk.DesignScript.Geometry;
using Autodesk.DesignScript.Runtime;

namespace CADDY
{
    /// <summary>
    /// extension class for conversion from\to Dynamo
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public static class Conversions
    {
        /// <summary>
        /// convert a dxf point to a DS point
        /// </summary>
        /// <param name="point">dxf point to convert</param>
        /// <returns></returns>
        public static Autodesk.DesignScript.Geometry.Point ToDSPoint(this netDxf.Entities.Point point)
        {
            return Point.ByCoordinates(
                point.Position.X,
                point.Position.Y,
                point.Position.Z);
        }

        // Layer -> Subcategory ?
    }
    
}
