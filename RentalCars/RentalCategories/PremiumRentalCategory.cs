using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.RentalCategories
{
    public class PremiumRentalCategory : RentalCategory
    {
        private float price;
        public PremiumRentalCategory(float price)
        {
            this.price = price;
        }
        public override float rentalAmountBasedOnRentalDays(int rentalDays)
        {
            return price * rentalDays;
        }

        public override int generateRentalPoints(int rentalDays)
        {
            if (rentalDays > 2) 
                return 2;
            return 0;
            //return base.generateRentalPoints(rentalDays);
        }
    }
}
