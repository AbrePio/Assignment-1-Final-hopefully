using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class RefriedBeans:Beans
    {
        //public string Beans { get { return "Refried Beans"; } }
        //public int Price { get { return 6; } }

        // testing 
        public override string BeansClass()
        {
            return "Refried Beans";
        }
        public override int Price()
        {
            return 6;
        }
        //

        // ----------------decorator 
        Ingredient ingredient;
        public RefriedBeans(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Refried Beans, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 6;
        }
        // ------------------end decorator
    }
}
