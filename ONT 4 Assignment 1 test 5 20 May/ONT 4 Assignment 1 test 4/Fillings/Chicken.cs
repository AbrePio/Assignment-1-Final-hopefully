using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Chicken : Poultry
    {
        //public string Poultry { get { return "Chicken"; } }
        //public int Price { get { return 15; } }

        // testing 
        public override string PoultryClass()
        {
            return "Chicken";
        }
        public override int Price()
        {
            return 15;
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
        public Chicken(Ingredient ingredient) : base(ingredient)
        {
            //this.Description = PoultryClass();
            //this.Price1 = Price();
            //this.Description = "Chicken";
            //this.Price1 = 15;
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Chicken, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 15;
        }
        // ------------------end decorator
    }
}
