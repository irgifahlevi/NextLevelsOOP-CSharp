namespace AbstractPropsFunc
{
    public abstract class Vehicle
    {
        private const string _sound = "This sound horn : ";
        /// <summary>
        /// Kelas abstrac kelas yang tidak dapat diinstansiasi (dibuat objeknya) secara langsung
        /// kelas abstract digunakan sebagai kerangka dasar untuk kelas-kelas turunannya.
        /// </summary>
        /// <returns></returns>
        #region Constructor
        public Vehicle()
        {

        }
        #endregion

        #region Members Property

        // init memungkinkan inisialisasi hanya pada saat pembuatan objek. dan tidak dapat di gunakan lagi
        public string? Model { get; init; }
        public string? Make { get; init; }

        /// <summary>
        /// Kelas turunan yang mewarisi dari kelas ini diharapkan memberikan implementasi konkret 
        /// (nilai aktual) untuk properti WheelCount.
        /// </summary>
        /// <value></value>
        public abstract int WhellCount { get; }


        public virtual string Sound { get => _sound; }
        #endregion

        #region Methods

        /// <summary>
        /// Dengan kata lain, kelas yang mewarisi dari kelas ini (kelas turunan) 
        /// wajib memberikan implementasi konkret (kode aktual) untuk metode SoundHorn
        /// </summary>
        public abstract void SoundHorn();

        public override string ToString()
        {
            return $"{GetType()} : {Make} {Model}";
        }

        #endregion
    }


    public class Car : Vehicle
    {
        #region Constructor
        public Car()
        {

        }
        #endregion

        #region Members Property
        // mengimplementasikan property abstract dari base class
        public override int WhellCount => 4;
        #endregion

        #region Methods
        // mengimplementasikan method dari base class
        public override void SoundHorn()
        {
            Console.WriteLine($"{Sound} Beep Beep");
        }
        #endregion
    }


    public class Motorcycle : Vehicle
    {
        #region Constructor
        public Motorcycle()
        {

        }
        #endregion

        #region Members Property
        // mengimplementasikan property abstract dari base class
        public override int WhellCount => 2;
        #endregion

        #region Methods
        // mengimplementasikan method dari base class
        public override void SoundHorn()
        {
            Console.WriteLine($"{Sound} Vroom Vroom");
        }
        #endregion
    }
}