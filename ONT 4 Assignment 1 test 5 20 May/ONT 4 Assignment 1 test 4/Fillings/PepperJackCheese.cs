using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class PepperJackCheese:Cheese
    {
        //public string Cheese { get { return "Pepper Jack Cheese"; } }
        //public int Price { get { return 5; } }

        // testing 
        public override string CheeseClass()
        {
            return "Pepper Jack Cheese";
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
        public PepperJackCheese(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Pepper Jack Cheese, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 5;
        }
        // ------------------end decorator
    }
}
