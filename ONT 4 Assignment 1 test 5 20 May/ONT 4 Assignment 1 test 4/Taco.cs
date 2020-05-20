using ONT_4_Assignment_1_test_4.Fillings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    class Taco:Ingredient
    {
        private Poultry _poultry;
        private Meat _meat;
        private Vegetation _vegetation;
        private Cheese _cheese;
        private Guacomole _guacomole;
        private Rice _rice;
        private Beans _beans;
        private CreamCheese _creamCheese;
        private Tomato _tomato;
        private Chili _chili;

        public Taco(IngredientFactory ingredientFactory)
        {
            _poultry = ingredientFactory.GetPoultry();
            _meat = ingredientFactory.GetMeat();
            _vegetation = ingredientFactory.GetVegetation();
            _cheese = ingredientFactory.GetCheese();
            _guacomole = ingredientFactory.GetGuacomole();
            _rice = ingredientFactory.GetRice();
            _beans = ingredientFactory.GetBeans();
            _creamCheese = ingredientFactory.GetCreamCheese();
            _tomato = ingredientFactory.GetTomato();
            _chili = ingredientFactory.GetChili();
        }

        public string DescribeTaco()
        {
            return $"Ingredients Available: \n\n" + 
                $"{_poultry.PoultryClass()}\t\t\t R{_poultry.Price()}\n" +
                $"{_meat.MeatClass()}\t\t\t R{_meat.Price()}\n" +
                $"{_vegetation.VegetationClass()}\t\t\t R{_vegetation.Price()}\n" +
                $"{_cheese.CheeseClass()}\t\t R{_cheese.Price()}\n" +
                $"{_guacomole.GuacomoleClass()}\t\t R{_guacomole.Price()}\n" +
                $"{_rice.RiceClass()}\t\t R{_rice.Price()}\n" +
                $"{_beans.BeansClass()}\t\t R{_beans.Price()}\n" +
                $"{_creamCheese.CreamCheeseClass()}\t R{_creamCheese.Price()}\n" +
                $"{_tomato.TomatoClass()}\t\t\t R{_tomato.Price()}\n" +
                $"{_chili.ChiliClass()}\t R{_chili.Price()}\n" ;
        }

        // decorator testing
        public override string GetDiscription()
        {
            return "Taco with ";
        }
        public override int Cost()
        {
            return 40;
        }
        // decorator ending
    }
}
