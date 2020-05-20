using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class JasminRice:Rice
    {
        //public string Rice { get { return "Jasmin Rice"; } }
        //public int Price { get { return 4; } }

        // testing 
        public override string RiceClass()
        {
            return "Jasmin Rice";
        }
        public override int Price()
        {
            return 4;
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
        public JasminRice(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Jasmin Rice, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 4;
        }
        // ------------------end decorator
    }
}
