using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class ChunkyCreamCheese:CreamCheese
    {
        //public string CreamCheese { get { return "Chunky Cream Cheese"; } }
        //public int Price { get { return 12; } }

        // testing 
        public override string CreamCheeseClass()
        {
            return "Chunky Cream Cheese";
        }
        public override int Price()
        {
            return 12;
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
        public ChunkyCreamCheese(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Chunky Cream Cheese, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 12;
        }
        // ------------------end decorator

    }
}
