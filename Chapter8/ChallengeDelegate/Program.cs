// See https://aka.ms/new-console-template for more information
using ChallengeDelegate;

// deklarasi shipping delegete
ShippingDelegete shippingDelegete;

string zone;

do
{
    System.Console.WriteLine("What is the shipping destination ? :");

    // menangkap nilai input 
    zone = Console.ReadLine();

    if (zone != null && !zone.Equals("exit"))
    {
        // Memanggil method dari kelas turunan base class abstract
        ShippingDestination shippingDestination = ShippingDestination.shippingDestination(zone);

        // Jika kelas turunan ada
        if (shippingDestination != null)
        {
            System.Console.WriteLine("What is a item price ? : ");

            // Menamkap nilai input
            string priceInput = Console.ReadLine();

            // Konversi string menjadi decimal
            decimal itemPrice = decimal.Parse(priceInput);

            // Memasukan dan mengaitkan method CalcualteFee ke delegate 
            shippingDelegete = shippingDestination.CalculateFee;

            // Jika isHighRisk true
            if (shippingDestination.isHighRisk)
            {
                // Menambahkan method delegate anonim ke dalam delegate
                // fee di beri modifier 'ref'  yang berarti itu adalah parameter referensi. Ini berarti nilai parameter dapat dimodifikasi
                shippingDelegete += delegate (decimal price, ref decimal fee)
                {
                    // Memodifikasi fee dan menambahkan 25.0m 
                    fee += 25.0m;
                };
            }

            // fee di set = 0
            decimal theFee = 0.0m;

            // Invoke nilai itemPrice dan akan mengembalikan nilai pembaruan theFee
            shippingDelegete(itemPrice, ref theFee);
            System.Console.WriteLine($"The shipping fees are : {theFee}");
        }
    }
    // jika exit
    else
    {
        Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
    }
    // akan melooping selama input bukan exit
} while (!zone.Equals("exit"));
