using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Salsa:Tomato
    {
        //public string Tomato { get { return "Salsa"; } }
        //public int Price { get { return 5; } }

        // testing 
        public override string TomatoClass()
        {
            return "Salsa";
        }
        public override int Price()
        {
            return 5;
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
        public Salsa(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Salsa, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 5;
        }
        // ------------------end decorator
    }
}
