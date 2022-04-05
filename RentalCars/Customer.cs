using System.Collections.Generic;

namespace RentalCars
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public int FrequentRenterPoints { get; set; }

        public bool hasDiscount()
        {
            if (FrequentRenterPoints >= 5)
                return true;
            return false;
        }

        public bool isLoyalCustomer(int frequentRenterPoint)
        {
            if (frequentRenterPoint >= 3)
                return true;
            return false;
        }


    }
}