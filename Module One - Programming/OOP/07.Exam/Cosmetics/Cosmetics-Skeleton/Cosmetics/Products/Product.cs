namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    public abstract class Product : IProduct
    {
        private const int minNameLength = 3;
        private const int maxNameLength = 10;
        private const int minBrandLength = 2;
        private const int maxBrandLength = 10;

        private string name;
        private string brand;
        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, Product.maxNameLength, Product.minNameLength,
                    string.Format("Product name must be between {0} and {1} symbols long!",
                    Product.minNameLength, Product.maxNameLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Brand cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(value, Product.maxNameLength, Product.minNameLength,
                    string.Format("Product brand must be between {0} and {1} symbols long!",
                    Product.minBrandLength, Product.maxBrandLength));
                this.brand = value;
            }
        }

        public decimal Price { get; private set; }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("- {0} - {1}:", this.brand, this.name));
            output.AppendLine(string.Format("  * Price: ${0}", this.Price));
            output.AppendLine(string.Format("  * For gender: {0}", this.Gender.ToString()));
            return output.ToString();
        }
    }
}
