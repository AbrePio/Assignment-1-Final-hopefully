using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface IPoultry  //----- for abstract and factory
     abstract class Poultry : ingredientDecorator  //------ for decorator pattern
    {
        // --------------------abstract and factory


        //string Poultry { get; }
        //int Price { get; }


        // testing 
        public abstract string PoultryClass();
        public abstract int Price();
        //public int Price { get; }
        //public string Poultry;
        //public int Price;
        //public abstract string getPoultry();

        // end testing

        // -----------------------end of abstract and factory

        // -------------Decorator start
        Ingredient ingredient;
        public Poultry(Ingredient ingredient):base(ingredient)
        {
            this.ingredient = ingredient;
        }
        public override string GetDiscription()
        {
            return ingredient.GetDiscription();
        }
        public override int Cost()
        {
            return ingredient.Cost();
        }
        //-----------------------end of decorator
    }
}
