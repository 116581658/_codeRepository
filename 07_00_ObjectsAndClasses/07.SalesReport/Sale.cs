using System;

namespace _07.SalesReport
{
    public class Sale
    {
        private string town;
        private string product;
        private double price;
        private double quantity;

        public string Town
        {
            get { return this.town; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid town");
                }
                this.town = value;
            }
        }

        public string Product
        {
            get { return this.product; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Invalid product");
                }
                this.product = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price: Price must be greater zero");
                }
                this.price = value;
            }
        }

        public double Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid argument: The Quantity must be greater zero");
                }
                this.quantity = value;
            }
        }

        public double TotalMoney
        {
            get { return this.price * this.quantity; }
        }
    }
}
