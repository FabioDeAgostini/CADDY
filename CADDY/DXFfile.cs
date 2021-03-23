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
    /// DXF file interop nodes
    /// read, write and get deep into objects
    /// </summary>
    public class DXFfile
    {
        //todo: save

        // document stored
        internal DxfDocument _doc = null;
        internal DXFfile(string path) 
        {
            _doc = DxfDocument.Load(path);
        }

        #region open
        /// <summary>
        /// Open a DXF file from given path.
        /// up to 2018 version supported
        /// </summary>
        /// <param name="path">path of DXF file to open</param>
        /// <returns>DXF document</returns>
        public static DXFfile Open(string path)
        {
            return new DXFfile(path);
        }
        #endregion

        #region Points
        /// <summary>
        /// get the Points in current layout
        /// </summary>
        public List<Point> Points
        {
            get
            {
                return _doc.Points.Select(p => p.ToDSPoint()).ToList();
            }
        }
        #endregion

        #region Layers
        /// <summary>
        /// 
        /// </summary>
        public List<netDxf.Tables.Layer> Layers
        {
            get { return _doc.Layers.ToList(); }
        }
        #endregion


    }
}
