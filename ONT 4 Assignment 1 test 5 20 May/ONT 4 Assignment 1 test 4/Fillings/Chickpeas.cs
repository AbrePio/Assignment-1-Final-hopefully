using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Chickpeas:Vegetation
    {
        //public string Vegetation { get { return "Chick Peas"; } }
        //public int Price { get { return 10; } }

        // testing 
        public override string VegetationClass()
        {
            return "Chickpeas";
        }
        public override int Price()
        {
            return 10;
        }
        //

        // ----------------decorator 

        //public override string GetDiscription()
        //{
        //    return "df";
        //}
        //public override int Cost()
        //{
        //    return 15;
        //}
        Ingredient ingredient;
        public Chickpeas(Ingredient ingredient) : base(ingredient)
        {
            //this.Description = VegetationClass();
            //this.Price1 = Price();
            //this.Description = "Chicken";
            //this.Price1 = 15;
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Chickpeas, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 10;
        }
        // ------------------end decorator
    }
}
