namespace Cosmetics.Products
{
    using System.Collections.Generic;

    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> cart;
        public ShoppingCart()
        {
            this.cart = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            cart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            cart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            bool containsProduct = cart.Contains(product);
            return containsProduct;
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in cart)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }
    }
}
