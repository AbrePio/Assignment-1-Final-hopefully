using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class SmoothCreamCheese:CreamCheese
    {
        //public string CreamCheese { get { return "Smooth Cream Cheese"; } }
        //public int Price { get { return 14; } }

        // testing 
        public override string CreamCheeseClass()
        {
            return "Smooth Cream Cheese";
        }
        public override int Price()
        {
            return 14;
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
        public SmoothCreamCheese(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Smooth Cream Cheese, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 14;
        }
        // ------------------end decorator
    }
}
