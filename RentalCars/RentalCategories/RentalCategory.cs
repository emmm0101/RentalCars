using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCars
{
    public abstract class RentalCategory
    {
        public abstract float rentalAmountBasedOnRentalDays(int rentalDays);

        public virtual int generateRentalPoints(int rentalDays)
        {
            return 1;
        }

        public virtual int calculateRentalAmount ()
        {
            return 0;   
        }

    }
}
