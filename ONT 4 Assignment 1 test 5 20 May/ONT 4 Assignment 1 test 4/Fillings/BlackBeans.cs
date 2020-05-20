using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class BlackBeans:Beans
    {
        //public string Beans { get { return "Black Beans"; } }
        //public int Price { get { return 5; } }

        // testing 
        public override string BeansClass()
        {
            return "Black Beans";
        }
        public override int Price()
        {
            return 5;
        }
        //

        // ----------------decorator 

        Ingredient ingredient;
        public BlackBeans(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Black Beans, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 5;
        }
        // ------------------end decorator
    }
}
