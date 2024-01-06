namespace StaticMethods
{
    public class Temperature
    {
        #region Constanta
        /// <summary>
        ///  Konstanta merupakan adalah nilai tetap yang di simpan ke dalam double
        ///  Konstanta ini tidak dapat di ubah setelah di tetapkan selama waktu kompilasi
        /// </summary>
        public const double ROOM_TEMP_LOWER_C = 20.0;
        public const double ROOM_TEMP_UPPER_C = 23.0;
        #endregion

        #region Constructor

        public Temperature(double t)
        {
            Temp = t;
        }
        #endregion

        #region Method
        /// <summary>
        /// method statis dapat dipanggil langsung pada nama kelasnya tanpa perlu membuat objek dari kelas tersebut.
        /// </summary>
        /// <returns></returns>
        public static double FtoC(double Ftemp)
        {
            double CTemp = (Ftemp - 32.0) * (5.0 / 9.0);
            return CTemp;
        }

        public static double CtoF(double Ctemp)
        {
            double FTemp = (Ctemp * (9.0 / 5.0)) + 32.0;
            return FTemp;
        }
        // method boolean akan mereturn true atau false
        public bool IsRoomTemp()
        {
            // temperatur lebih dari sama dengan ROOM_TEMP_LOWER_C dan temperature kurang dari sama dengan ROOM_TEMP_UPPER_C
            return Temp >= ROOM_TEMP_LOWER_C && Temp <= ROOM_TEMP_UPPER_C;
        }

        public static bool IsRoomTemp(double temp)
        {
            return temp >= ROOM_TEMP_LOWER_C && temp <= ROOM_TEMP_UPPER_C;
        }
        #endregion


        #region Property
        public double Temp { get; set; }
        #endregion
    }
}