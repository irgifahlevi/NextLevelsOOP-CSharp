namespace BasicEvents
{
    public delegate void MyEventHandler(string value);
    public class EventPublisher
    {
        // private property
        private string theValue;

        // declare event
        public event MyEventHandler valueChanged;

        // declare event yang menggunakan kelas EventArgs kustom
        public event EventHandler<ChangeEventsArgs> objChanged;

        // Properti Value digunakan untuk mengatur nilai properti theValue dan memicu dua event.
        public string Value
        {
            set
            {
                // Menetapkan nilai baru ke properti theValue.
                theValue = value;

                // Memicu event valueChanged dengan meneruskan nilai baru.
                valueChanged(theValue);

                // Memicu event objChanged dengan meneruskan objek saat ini dan nilai properti yang berubah dalam argumen.
                // Dengan cara ini, penerima event dapat mengakses objek pengirim (this) dan nilai properti yang berubah.
                objChanged(this, new ChangeEventsArgs()
                {
                    propChanged = theValue
                });
            }
        }
    }
}