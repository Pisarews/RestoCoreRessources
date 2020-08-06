using System;
using System.Collections.Generic;
using System.Text;

namespace RestoCore
{
    class Dish
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string MeasureUnite { get; set; }
        public decimal PricePerPortion { get; set; }
        public int NumberOfPortions { get; set; }
        public bool isVegetarian { get; set; }
        public bool isVegetalian { get; set; }
        public List<Allergene> allergenes = new List<Allergene>(); 
        public double NumberOfCalories { get; set; }
    }
}
