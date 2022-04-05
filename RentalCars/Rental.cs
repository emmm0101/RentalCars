namespace RentalCars
{
    public class Rental
    {
        public Customer Customer { get; }
        public Car Car { get; }
        public int DaysRented { get; }
        public float rentalAmount { get; }

        public RentalCategory Category { get; } 

        public Rental(Customer customer, Car car, int daysRented)
        {
            Customer = customer;
            Car = car;
            DaysRented = daysRented;
        }

        public void createRental()
        {

            // check customer info - hasDiscount?
            // check rentalcategory way of calculating totalamount
        }
        public void addFrequentRenterPoint(int points)
        {
            Customer.FrequentRenterPoints += points;
        }
    }
}