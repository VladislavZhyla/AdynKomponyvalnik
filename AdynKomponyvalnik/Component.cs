using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdynKomponyvalnik
{
    public abstract class Component
    {
        protected string name;
        protected double price;
        protected string ingredients;

        public Component(string name, double price, string ingredients)
        {
            this.name = name;
            this.price = price;
            this.ingredients = ingredients;
        }

        public abstract double GetPrice();
        public abstract string GetIngredients();
    }

}
