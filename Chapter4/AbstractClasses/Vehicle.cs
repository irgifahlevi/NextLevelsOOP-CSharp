namespace AbstractClasses
{
    public abstract class Vehicle
    {
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
        #endregion

        #region Methods
        public virtual void SoundHorn()
        {
            // sebagai placeholder apabila method ini tidak di gunakan
            Console.WriteLine("Add horn sound here");
        }

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

        #region Methods
        public override void SoundHorn()
        {
            Console.WriteLine("Beep Beep");
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

        #region Methods
        public override void SoundHorn()
        {
            Console.WriteLine("Honk Honk");
        }
        #endregion
    }
}