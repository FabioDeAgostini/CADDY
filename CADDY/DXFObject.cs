using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netDxf;
using Autodesk.DesignScript.Geometry;
using netDxf.Tables;

namespace CADDY
{
    class DXFObject
    {
        private Layer _layer;
        private AciColor _color;
        private Linetype _lineType;
        private Lineweight _lineWeight;

        public Layer Layer
        {
            get { return _layer; }
            set { _layer = value; }
        }


    }
}
