using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class Mutton:Meat
    {
        //public string Meat { get { return "Mutton"; } }
        //public int Price { get { return 22; } }

        // testing 
        public override string MeatClass()
        {
            return "Mutton";
        }
        public override int Price()
        {
            return 22;
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
        public Mutton(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Mutton, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 22;
        }
        // ------------------end decorator
    }
}
