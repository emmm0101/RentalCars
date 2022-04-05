using RentalCars.RentalCategories;
using System;

namespace RentalCars
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalCars store = new RentalCars("Iasi Rentals", new float[]{  1 });

            var customer1 = new Customer("Ion Popescu");
            var customer2 = new Customer("Mihai Chirica");
            var customer3 = new Customer("Gigi Becali");

            store.AddRental(new Rental(customer1, new Car("Ford Focus"), 2 ));
            float[] prices = { 1, 2 };
            RentalCategory rentalCategory = new RegularRentalCategory(prices);
            //int a = RegularRentalCategory.generateRentalPoints(0);
            //store.AddRental(new Rental(customer3, new Car( "Renault Clio"), 3));
            //store.AddRental(new Rental(customer1, new Car("BMW 330i"), 1));
            //store.AddRental(new Rental(customer3, new Car("Volvo XC90"), 3));
            //store.AddRental(new Rental(customer2, new Car("Toyota Aygo"), 2));
            //store.AddRental(new Rental(customer1, new Car("Hyundai i10"), 4));
            //store.AddRental(new Rental(customer3, new Car("Volvo XC90"), 2));
            //store.AddRental(new Rental(customer3, new Car("Mercedes E320"), 1));

            Console.WriteLine(store.Statement());
            Console.ReadKey();

        }
    }
}
