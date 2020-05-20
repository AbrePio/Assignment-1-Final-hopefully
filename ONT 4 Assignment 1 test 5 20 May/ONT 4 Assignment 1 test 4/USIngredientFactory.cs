using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
     class USIngredientFactory : IngredientFactory
    {
        private Ingredient ingredient;
        public override Beans GetBeans()
        {
            return new BlackBeans(ingredient);
        }

        public override Cheese GetCheese()
        {
            return new PepperJackCheese(ingredient);
        }

        public override Chili GetChili()
        {
            return new HabaneroChilies(ingredient);
        }

        public override CreamCheese GetCreamCheese()
        {
            return new ChunkyCreamCheese(ingredient);
        }

        public override Guacomole GetGuacomole()
        {
            return new Guacamole(ingredient);
        }

        public override Meat GetMeat()
        {
            return new Beef(ingredient);
        }

        public override Poultry GetPoultry()
        {
            return new Turkey(ingredient);
        }

        public override Rice GetRice()
        {
            return new BasmatiRice(ingredient);
        }

        public override Tomato GetTomato()
        {
            return new Salsa(ingredient);
        }

        public override Vegetation GetVegetation()
        {
            return new Chickpeas(ingredient);
        }
    }
}
