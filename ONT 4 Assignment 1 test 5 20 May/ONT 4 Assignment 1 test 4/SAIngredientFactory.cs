
using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class SAIngredientFactory : IngredientFactory
    {
        private Ingredient ingredient;
        public override Beans GetBeans()
        {
            return new RefriedBeans(ingredient);
        }

        public override Cheese GetCheese()
        {
            return new CheddarCheese(ingredient);
        }

        public override Chili GetChili()
        {
            return new JalapenoChilies(ingredient);
        }

        public override CreamCheese GetCreamCheese()
        {
            return new SmoothCreamCheese(ingredient);
        }

        public override Guacomole GetGuacomole()
        {
            return new SlicedAvocados(ingredient);
        }

        public override Meat GetMeat()
        {
            return new Mutton(ingredient);
        }

        public override Poultry GetPoultry()
        {
            return new Chicken(ingredient);
        }

        public override Rice GetRice()
        {
            return new JasminRice(ingredient);
        }

        public override Tomato GetTomato()
        {
            return new Relish(ingredient);
        }

        public override Vegetation GetVegetation()
        {
            return new Samp(ingredient);
        }
    }
}
