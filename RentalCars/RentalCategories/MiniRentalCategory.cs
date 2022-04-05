using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars.RentalCategories
{
    public class MiniRentalCategory : RentalCategory
    {
        private float[] prices;

        public MiniRentalCategory(float[] prices)
        {
            this.prices = prices;
        }

        public override float rentalAmountBasedOnRentalDays(int rentalDays)
        {
            if (rentalDays <= 3)
                return rentalDays * prices[0];
            return (3) * prices[0] + (rentalDays - 3) * prices[1];
        }

        public override int generateRentalPoints(int rentalDays)
        {
            return base.generateRentalPoints(rentalDays);
        }

    }
}
