namespace Cosmetics.Products
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;

    public class Category : ICategory
    {
        private const int maxNameLength = 15;
        private const int minNameLength = 2;

        private string name;
        private IList<IProduct> productsInCategory;
        public Category(string name)
        {
            this.Name = name;
            productsInCategory = new List<IProduct>();
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
                Validator.CheckIfStringLengthIsValid(value, Category.maxNameLength, Category.minNameLength,
                    string.Format("Category name must be between {0} and {1} symbols long!",
                    Category.minNameLength, Category.maxNameLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            productsInCategory.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool hasProduct = productsInCategory.Any(pr => pr == cosmetics);
            if (!hasProduct)
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            productsInCategory.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format("{0} category - {1} {2} in total",
                this.Name, productsInCategory.Count, productsInCategory.Count == 1 ? "product" : "products"));

            var sortedProducts = productsInCategory.
                OrderBy(pr => pr.Brand)
                .ThenByDescending(pr => pr.Price);

            foreach (var product in sortedProducts)
            {
                output.AppendLine(product.Print());
            }
            return output.ToString().Trim();
        }
    }
}
