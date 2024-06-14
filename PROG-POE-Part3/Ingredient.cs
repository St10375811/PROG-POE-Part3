using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_Part3
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double OriginalQuantity { get; set; }
        public UnitOfMeasurement OriginalUnit { get; set; }
        public UnitOfMeasurement Unit { get; set; }
        public FoodGroup FoodGroup { get; set; }
        public double calories { get; set; }
        public double originalCalories { get; set; }

        public Ingredient() { }

        public Ingredient(string name, double quantity, UnitOfMeasurement unit, FoodGroup foodGroup, double calories)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            OriginalQuantity = quantity;
            OriginalUnit = unit;
            FoodGroup = foodGroup;
            this.calories = calories;
            originalCalories = calories;
        }

        public void ResetQuantity()
        {
            Quantity = OriginalQuantity;
        }

        public void ResetUnit()
        {
            Unit = OriginalUnit;
        }

        public void CalculateScaledCalories(double factor)
        {
            calories = factor * calories;
        }

        public void ResetCalories()
        {
            this.calories = originalCalories;
        }

        public void display()
        {
            Console.WriteLine($"{Quantity} {Unit} of {Name}\nFood Group: {FoodGroup}\n{calories} calories\n");
        }
    }
}
