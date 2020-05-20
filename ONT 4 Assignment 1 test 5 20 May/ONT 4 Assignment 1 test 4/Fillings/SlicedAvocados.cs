using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    class SlicedAvocados:Guacomole
    {
        //public string Guacomole { get { return "Sliced Avocados"; } }
        //public int Price { get { return 15; } }

        // testing 
        public override string GuacomoleClass()
        {
            return "Sliced Avocados";
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
        public SlicedAvocados(Ingredient ingredient) : base(ingredient)
        {
            this.ingredient = ingredient;
            //this.Description = "Chicken";
            //this.Price1 = 15;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription() + "Sliced Avocados, ";
        }
        public override int Cost()
        {
            return ingredient.Cost() + 15;
        }
        // ------------------end decorator
    }
}
