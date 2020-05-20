using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class CheddarCheese:Cheese
    {
        //public string Cheese { get { return "Cheddar Cheese"; } }
        //public int Price { get { return 6; } }

        // testing 
        public override string CheeseClass()
        {
            return "Cheddar Cheese";
        }
        public override int Price()
        {
            return 6;
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
        public CheddarCheese(Ingredient ingredient) : base(ingredient)
        {
            //this.Description = CheeseClass();
            //this.Price1 = Price();
            //this.Description = "Chicken";
            //this.Price1 = 15;
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Cheddar Cheese, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 6;
        }
        // ------------------end decorator
    }
}
