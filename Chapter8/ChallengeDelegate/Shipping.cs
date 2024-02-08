namespace ChallengeDelegate
{
    // Deklarasi delegate dengan 2 parameter 
    // Parameter thePrice untuk nilai harga
    // Parameter fee adalah harga pengiriman, fee di beri modifier 'ref'  yang berarti 
    // itu adalah parameter referensi. Ini berarti nilai parameter dapat dimodifikasi
    public delegate void ShippingDelegete(decimal thePrice, ref decimal fee);

    public abstract class ShippingDestination
    {
        // Property
        public bool isHighRisk = false;

        // Method virtual akan memberikan opsi kepada kelas turunan untuk implemetasikan method ini 
        public virtual void CalculateFee(decimal price, ref decimal fee)
        { }

        // Method yang akan mengembalikan objek dari kelas turunannya 
        public static ShippingDestination shippingDestination(string destination)
        {
            if (destination.Equals("ZoneA"))
            {
                return new DestinationZoneA();
            }
            if (destination.Equals("ZoneB"))
            {
                return new DestinationZoneB();
            }
            if (destination.Equals("ZoneC"))
            {
                return new DestinationZoneC();
            }
            if (destination.Equals("ZoneD"))
            {
                return new DestinationZoneD();
            }
            return null;
        }
    }
}