using System;

namespace MyCoffeeProject
{
    class program{
        public void Main(String[] args)
        {{
            Console.WriteLine("Masukkan Nama anda");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Masukkan No telpon anda");
            string PhoneNumber= Console.ReadLine();
            Console.WriteLine("IcedCoffee atau IcedLatte");
            string fCoffee = Console.ReadLine();
            Customer custom = new Customer(Firstname, PhoneNumber, fCoffee);
            Console.WriteLine("Small Medium Large ");
            string size = Console.ReadLine();
            Console.WriteLine("Jumlah : ");
            int Jumlah = Convert.ToInt32(Console.ReadLine());
}
        static void cafe(string size, string fCoffee, int Jumlah)
        {

            string coffe = fCoffee;

            if (coffe == "IcedCoffee")
            {
                string bTime = "long";
                string iceamt = "normal";
                if (size == "small")
                {
                    size = "Small";
                }
                else if (size == "medium")
                {
                    size = "Medium";
                }
                else
                {
                    size = "Large";
                }
                IcedCoffee custsCoffee = new IcedCoffee(size, bTime, iceamt, 35);
                Console.WriteLine(custsCoffee);
                Console.WriteLine("Price: " + custsCoffee.price * Jumlah);
            }
            else if (coffe == "IcedLatte")
            {
                string bTime = "short";
                string icea = "normal";
                string milkAmount = "normal";

                if (size == "small")
                {
                    size = "Small";
                }
                else if (size == "medium")
                {
                    size = "Medium";
                }
                else
                {
                    size = "Large";
                }

                IcedLatte custsCoffee = new IcedLatte(size, bTime, icea, milkAmount, 50);
                Console.WriteLine(custsCoffee);
                    double price = custsCoffee.price;
                    Console.WriteLine("Price: " + price * Jumlah);
            }
        }
        }
    }
}