namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo, IProduct
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price * milliliters, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }
        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }
        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.Print());
            output.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            output.AppendLine(string.Format("  * Usage: {0}", this.Usage.ToString()));

            return output.ToString().Trim();
        }
    }
}
