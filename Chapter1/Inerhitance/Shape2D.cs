using System.Reflection.Metadata.Ecma335;

namespace Inerhitance
{
    public class Shape2D
    {
        #region Constructor
        // Konstruktor default tanpa parameter
        public Shape2D()
        {

        }
        #endregion


        #region Method
        // Metode virtual untuk mendapatkan luas bidang 2D ini memberikan opsi untuk 
        // kelas turunan untuk menyediakan implementasi ulang metode tersebut
        public virtual float GetAreas()
        {
            return 0.0f;
        }

        // metode override dari kelas dasar Object untuk memberikan representasi string objek
        // dengan menggunakan simplfy lambda expession
        public override string ToString() => $"This object a '{GetType()}'";

        #endregion
    }


    // kelas turunan dari kelas Shape2D
    public class Circle : Shape2D
    {
        #region Constructor
        // Konstruktor default dengan parameter radius
        public Circle(int r)
        {
            Radius = r;
        }
        #endregion

        #region Method
        // Implementasi ulang metode GetAreas dari kelas dasar Shape2D
        public override float GetAreas()
        {
            return (3.14f * (Radius * Radius));
        }
        #endregion

        #region Property
        // memanggil property kelas private untuk mengakses dan mengatur nilai radius
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // property member kelas private untuk menyimpan value radius
        private int radius;
        #endregion
    }

    // kelas turunan dari kelas Shape2D
    public class Rectangle : Shape2D
    {
        #region Constructor
        // Konstruktor default dengan 2 parameter width dan height
        public Rectangle(int w, int h)
        {
            // inisialisasi width & height saat objek rectangle dibuat
            Width = w;
            Height = h;
        }
        #endregion

        #region Method
        // Implementasi ulang metode GetAreas dari kelas dasar Shape2D
        public override float GetAreas()
        {
            return width * height;
        }

        #endregion

        #region Property
        // memanggil property kelas private untuk mengakses dan mengatur nilai width dan height
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("This height value not allowed < 0");
                }
                height = value;
            }
        }

        // property member kelas private untuk menyimpan value width dan height;
        private int width;
        private int height;
        #endregion
    }

    // kelas turunan dari kelas Rectangle
    public class Square : Rectangle
    {
        // Konstruktor dengan parameter side, memanggil konstruktor kelas dasar (Rectangle) dengan base(side, side)
        public Square(int side) : base(side, side)
        {
            Side = side;
        }

        private int Side { get; set; }
    }
}