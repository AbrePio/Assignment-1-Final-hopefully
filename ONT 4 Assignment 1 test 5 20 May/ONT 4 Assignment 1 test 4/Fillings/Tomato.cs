using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4.Fillings
{
    //interface ITomato
    abstract class Tomato:ingredientDecorator
    {
        //string Tomato { get; }
        //int Price { get; }

        // testing
        public abstract string TomatoClass();
        public abstract int Price();
        // end testing

        // -------------Decorator start
        Ingredient ingredient;
        public Tomato(Ingredient ingredient) : base(ingredient)
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
