namespace ChallengeDelegate
{
    // Merupakan kelas turunan dari base class abstract
    public class DestinationZoneA : ShippingDestination
    {
        public DestinationZoneA()
        {
            // Set isHighRisk menjadi false pada class ini
            this.isHighRisk = false;
        }

        // merupakan implementasi method dari base class dengan parameter price dan fee
        // fee disini akan mengembalikan nilai perubahan 
        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.25m;
        }

    }

    public class DestinationZoneB : ShippingDestination
    {
        public DestinationZoneB()
        {
            this.isHighRisk = true;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.12m;
        }
    }

    public class DestinationZoneC : ShippingDestination
    {
        public DestinationZoneC()
        {
            this.isHighRisk = false;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.08m;
        }
    }

    public class DestinationZoneD : ShippingDestination
    {
        public DestinationZoneD()
        {
            this.isHighRisk = true;
        }

        public override void CalculateFee(decimal price, ref decimal fee)
        {
            fee = price * 0.04m;
        }
    }


}