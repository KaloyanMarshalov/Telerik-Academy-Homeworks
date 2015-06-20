namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class ToothPaste : Product, IToothpaste, IProduct
    {
        private const int minIngredientLength = 4;
        private const int maxIngredientLength = 12;
        private string ingredients;
        public ToothPaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            string checkedIngredients = CheckIngredients(ingredients);
            this.Ingredients = checkedIngredients;
        }
        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
            private set
            {
                this.ingredients = value;
            }
        }
        private string CheckIngredients(IList<string> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                Validator.CheckIfStringIsNullOrEmpty(ingredient, "Ingredient name cannot be null or empty!");
                Validator.CheckIfStringLengthIsValid(ingredient, ToothPaste.maxIngredientLength, ToothPaste.minIngredientLength,
                    string.Format("Each ingredient must be between {0} and {1} symbols long!!",
                    ToothPaste.minIngredientLength, ToothPaste.maxIngredientLength));
            }
            return string.Join(", ", ingredients);
        }
        public override string Print()
        {
            StringBuilder output = new StringBuilder();
            output.Append(base.Print());
            output.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients));

            return output.ToString().Trim();
        }
    }
}
