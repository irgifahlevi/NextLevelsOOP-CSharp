namespace PropsMethods
{
    public class Rectangle
    {
        #region Constructor
        // inisialisasi instance baru 2 parameter
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        // inisialisasi instance 1 parameter
        public Rectangle(int side)
        {
            Width = Height = side;
        }
        #endregion

        #region Method
        // fungsi di dalam kelas
        public int GetAreas()
        {
            return Width * Height;
        }
        #endregion

        #region Property
        // memanggil property kelas private dan mengatur lebar objek
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        // memanggil property kelas private dan mengatur tinggi objek
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This value not valid,", "value not allowed < 0");
                }
                height = value;
            }
        }

        // mendapatkan langsung property dan mengatur ukuran border dengan nilai default 1
        public int BorderSize { get; set; } = 1;

        // property member kelas
        private int width;
        private int height;
        #endregion
    }
}