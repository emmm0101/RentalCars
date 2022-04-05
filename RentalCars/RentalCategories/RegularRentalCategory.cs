using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.RentalCategories
{
    public class RegularRentalCategory : RentalCategory
    {
        private float[] prices;

        public RegularRentalCategory(float[] prices)
        {
            this.prices = prices;
        }

        public override float rentalAmountBasedOnRentalDays(int rentalDays)
        {
            if (rentalDays <= 2)
                return rentalDays *prices[0];
            return (2) * prices[0] + (rentalDays - 2) * prices[1];
        }

        public override int generateRentalPoints(int rentalDays)
        {
            return base.generateRentalPoints(rentalDays);
        }



    }
}
