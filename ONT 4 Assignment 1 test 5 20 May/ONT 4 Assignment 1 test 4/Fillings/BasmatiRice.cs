using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class BasmatiRice : Rice
    {
        //public string Rice { get { return "Basmati Rice"; } }
        //public int Price { get { return 3; } }

        // testing 
        public override string RiceClass()
        {
            return "Basmati Rice";
        }
        public override int Price()
        {
            return 3;
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
        public BasmatiRice(Ingredient ingredient) : base(ingredient)
        {
            //this.Description = RiceClass();
            //this.Price1 = Price();
            //this.Description = "Chicken";
            //this.Price1 = 15;
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Basmati Rice, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 3;
        }
        // ------------------end decorator
    }
}
