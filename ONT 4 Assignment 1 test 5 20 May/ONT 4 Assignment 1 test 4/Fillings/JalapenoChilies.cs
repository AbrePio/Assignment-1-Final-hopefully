using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class JalapenoChilies:Chili
    {
        //public string Chili { get { return "Jalapeno Chilies"; } }
        //public int Price { get { return 8; } }

        // testing 
        public override string ChiliClass()
        {
            return "Jalapeno Chilies";
        }
        public override int Price()
        {
            return 8;
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
        public JalapenoChilies(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Jalapeno Chilies, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 8;
        }
        // ------------------end decorator
    }
}
