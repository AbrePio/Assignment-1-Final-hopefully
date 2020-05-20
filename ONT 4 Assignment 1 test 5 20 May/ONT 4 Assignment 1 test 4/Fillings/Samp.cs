using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Samp:Vegetation
    {
        //public string Vegetation { get { return "Samp"; } }
        //public int Price { get { return 10; } }

        // testing 
        public override string VegetationClass()
        {
            return "Samp";
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
        public Samp(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Samp, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 10;
        }
        // ------------------end decorator
    }
}
