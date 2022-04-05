using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.RentalCategories
{
    public class LuxuryRentalCategory : RentalCategory
    {
        private float price;

        private static string name = "Luxury";
        public LuxuryRentalCategory(float price)
        {
            this.price = price; 
        }
        public override float rentalAmountBasedOnRentalDays(int rentalDays)
        {
            return price*rentalDays;
        }

        public override int generateRentalPoints(int rentalDays)
        {
            throw new NotImplementedException();
        }
    }
}
