using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdynKomponyvalnik
{
    class Program
    {
        public static void Main()
        {
            Dessert iceCream1 = new Dessert("Морозиво", 60, "Молоко, цукор, вершки");
            Pizza margherita = new Pizza("Маргарита", 120, "Тісто, соус, сир");
            Beverage cola = new Beverage("Кока-кола", 40, "Вода, цукор, кола");
            Dessert iceCream = new Dessert("Морозиво", 60, "Молоко, цукор, вершки");

            ComboMeal comboMeal = new ComboMeal("Комбіноване замовлення", 0);
            comboMeal.AddComponent(margherita);
            comboMeal.AddComponent(cola);
            comboMeal.AddComponent(iceCream);
            comboMeal.AddComponent(iceCream);

            Console.WriteLine($"Загальна ціна замовлення: {comboMeal.GetPrice()} грн.");
            Console.WriteLine($"Склад замовлення: {comboMeal.GetIngredients()}");
            Console.ReadKey();
        }

    }

}