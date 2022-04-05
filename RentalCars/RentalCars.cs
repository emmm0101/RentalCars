using System;
using System.Collections.Generic;
using System.Text;
using RentalCars.RentalCategories;

namespace RentalCars
{
    public class RentalCars
    {
        // TO DO
        // refactor as factory class that generates 2 classes/objects: IasiRentalCars and BucurestiRentalCars
        // both will receive a list of prices that will be used by rentalcategory to calculate rentalamount

        private float[] prices;
        
        private List<Rental> rentals = new List<Rental>();

        private List<RentalCategory> categories = new List<RentalCategory>
        {
            new RegularRentalCategory(new float[] {1,2})
        };

        public RentalCars(string name, float[] prices)
        {
            Name = name;
        }

        public string Name { get; }

        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public string Statement()
        {
            double pricePerDay = 20;
            double totalAmount = 0;
            var frequentRenterPoints = 0;

            var r = "Rental Record for " + Name + "\n";
            r += "------------------------------\n";

            foreach (var each in rentals)
            {
                double thisAmount = 0;

                // determines the amount for each line
                //switch (each.Car.PriceCode)
                //{
                //    case PriceCode.Regular:
                //        thisAmount += pricePerDay * 2;
                //        if (each.DaysRented > 2)
                //            thisAmount += (each.DaysRented - 2) * pricePerDay * 0.75;
                //        break;
                //    case PriceCode.Premium:
                //        thisAmount += each.DaysRented * pricePerDay * 1.5;
                //        break;
                //    case PriceCode.Mini:
                //        thisAmount += pricePerDay * 3 * 0.75;
                //        if (each.DaysRented > 3)
                //            thisAmount += (each.DaysRented - 3) * pricePerDay * 0.5;
                //        break;
                //}

                //if (each.Customer.FrequentRenterPoints >= 5)
                //{
                //    thisAmount = thisAmount * 0.95;
                //}

                //frequentRenterPoints = 1;
                //if (each.Car.PriceCode == PriceCode.Premium
                //    && each.DaysRented > 1)
                //    frequentRenterPoints++;

                each.Customer.FrequentRenterPoints += frequentRenterPoints;

                r += each.Customer.Name + "\t" + each.Car.Model + "\t" + each.DaysRented + "d \t" + thisAmount + " EUR\n";
                totalAmount += thisAmount;
            }
            r += "------------------------------\n";
            r += "Total revenue " + totalAmount + " EUR\n";

            return r;
        }
        
        public float calculateTotalRevenue()
        {
            float totalRevenue = 0;
            rentals.ForEach(rental => totalRevenue += rental.rentalAmount);   
            return  totalRevenue;
        }

        // ? parcurgere de 2 ori a listei rentals : calcul revenue si afisare rental
        public string StatementWithListOfRentalsAndTotalRevenue()
        {
            StringBuilder sb = new StringBuilder("ABC", 50);
            return sb.ToString(); 
        }

        public string StatementWithListOfRentalCategories()
        {

            StringBuilder sb = new StringBuilder("ABC", 50);
            return sb.ToString();
        }


    }
}