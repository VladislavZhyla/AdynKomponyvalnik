using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdynKomponyvalnik
{
    public class ComboMeal : Component
    {
        private List<Component> components = new List<Component>();

        public ComboMeal(string name, double price) : base(name, price, null)
        {
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
        }

        public void RemoveComponent(Component component)
        {
            components.Remove(component);
        }

        public override double GetPrice()
        {
            double totalPrice = price;
            foreach (Component component in components)
            {
                totalPrice += component.GetPrice();
            }
            return totalPrice;
        }

        public override string GetIngredients()
        {
            string allIngredients = "";
            foreach (Component component in components)
            {
                allIngredients += component.GetIngredients() + ", ";
            }
            return allIngredients;
        }
    }
}
