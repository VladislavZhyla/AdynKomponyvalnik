using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdynKomponyvalnik
{
    public class Pizza : Component
    {
        public Pizza(string name, double price, string ingredients) : base(name, price, ingredients)
        {
        }

        public override double GetPrice()
        {
            return price;
        }

        public override string GetIngredients()
        {
            return ingredients;
        }
    }

    public class Beverage : Component
    {
        public Beverage(string name, double price, string ingredients) : base(name, price, ingredients)
        {
        }

        public override double GetPrice()
        {
            return price;
        }

        public override string GetIngredients()
        {
            return ingredients;
        }
    }

    public class Dessert : Component
    {
        public Dessert(string name, double price, string ingredients) : base(name, price, ingredients)
        {
        }

        public override double GetPrice()
        {
            return price;
        }

        public override string GetIngredients()
        {
            return ingredients;
        }
    }

}
