using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefineClasses
{
    public class Shapes
    {
        #region Constructor
        // inisialisasi instance baru 2 parameter
        public Shapes(int w, int h)
        {
            width = w;
            height = h;
        }
        
        // insisialisasi instance baru 1 parameter
        public Shapes(int side)
        {
            width = height = side;
        }
        #endregion

        #region Method
        // fungsi di dalam kelas
        public int GetAreas()
        {
            return width * height;
        }
        #endregion

        #region Property
        // property member variable di dalam kelas
        public int width;
        public int height;
        #endregion
    }
}