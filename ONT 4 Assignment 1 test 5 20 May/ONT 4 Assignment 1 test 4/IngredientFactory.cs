using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    abstract class IngredientFactory
    {
        public abstract Poultry GetPoultry();
        public abstract Meat GetMeat();
        public abstract Vegetation GetVegetation();
        public abstract Cheese GetCheese();
        public abstract Guacomole GetGuacomole();
        public abstract Rice GetRice();
        public abstract Beans GetBeans();
        public abstract CreamCheese GetCreamCheese();
        public abstract Tomato GetTomato();
        public abstract Chili GetChili();

    }
}
