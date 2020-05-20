using ONT_4_Assignment_1_test_4.Fillings;
using System;

namespace ONT_4_Assignment_1_test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteKitchen sKitchen = new ConcreteKitchen();
            ConcreteKitchen sIngredient = new ConcreteKitchen();
            // Sets the predefined observers available
            sKitchen.Attach(new ConcreteObserver(sKitchen, "Kitchen"));
            sIngredient.Attach(new ConcreteObserver(sIngredient, "Ingredient"));

            string ing, kitchen;
            Console.Write("Enter Country (SA/US): ");
            kitchen = Console.ReadLine();

            switch (kitchen)
            {
                // Changes the Kitchen observer to be kitchen location
                case "US": sKitchen.SubjectState = "US Kitchen"; break;
                case "us": sKitchen.SubjectState = "US Kitchen"; break;
                case "SA": sKitchen.SubjectState = "SA Kitchen"; break;
                case "sa": sKitchen.SubjectState = "SA Kitchen"; break;
            }
            //Goes through Subject class to ConcreteObserver class to output in the console window
            sKitchen.Notify();

            //Setting the Ingredient
            Console.Write("Choose Ingredient Taco/Burrito: ");
            ing = Console.ReadLine();
            switch (ing)
            {
                // Changes the Ingredient observer to be an ingredient type
                case "Taco": sIngredient.SubjectState = "Taco"; break;
                case "taco": sIngredient.SubjectState = "Taco"; break;
                case "Burrito": sIngredient.SubjectState = "Burrito"; break;
                case "burrito": sIngredient.SubjectState = "Burrito"; break;
            }
            //Goes through Subject class to ConcreteObserver class to output in the console window
            sIngredient.Notify();

            
            Console.WriteLine();
            Console.WriteLine();

            if (kitchen == "SA" || kitchen == "sa" || kitchen == "Sa")
            {
                if (ing == "Taco" || ing == "taco" || ing == "TACO")
                {
                    Taco saTaco = new Taco(new SAIngredientFactory());
                    Console.WriteLine($"SA Taco: {saTaco.DescribeTaco()}");
                    // ---------------------------- observer testing
                    Ingredient newIngredientSA = new Taco(new SAIngredientFactory());
                    string userInputSA = "Yes";
                    string chosenFillingSA;
                    while (userInputSA == "Yes" || userInputSA == "yes" || userInputSA == "YES")
                    {
                        Console.Write("What filling do you want to add to your ingredient? ");
                        chosenFillingSA = Console.ReadLine();
                        switch (chosenFillingSA)
                        {
                            case "Chicken":
                            case "chicken":
                                newIngredientSA = new Chicken(newIngredientSA);
                                break;
                            case "Mutton":
                            case "mutton":
                                newIngredientSA = new Mutton(newIngredientSA);
                                break;
                            case "Samp":
                            case "samp":
                                newIngredientSA = new Samp(newIngredientSA);
                                break;
                            case "Cheddar Cheese":
                            case "cheddar cheese":
                            case "Cheddar cheese":
                                newIngredientSA = new CheddarCheese(newIngredientSA);
                                break;
                            case "Sliced Avocados":
                            case "sliced avocados":
                            case "Sliced avocados":
                                newIngredientSA = new SlicedAvocados(newIngredientSA);
                                break;
                            case "Jasmin Rice":
                            case "jasmin rice":
                            case "Jasmin rice":
                                newIngredientSA = new JasminRice(newIngredientSA);
                                break;
                            case "Refried Beans":
                            case "Refried beans":
                            case "refried beans":
                                newIngredientSA = new RefriedBeans(newIngredientSA);
                                break;
                            case "Smooth Cream Cheese":
                            case "smooth cream cheese":
                            case "Smooth Cream cheese":
                                newIngredientSA = new SmoothCreamCheese(newIngredientSA);
                                break;
                            case "Relish":
                            case "relish":
                                newIngredientSA = new Relish(newIngredientSA);
                                break;
                            case "Jalapeno Chilies":
                            case "jalapeno chilies":
                            case "Jalapeno chilies":
                                newIngredientSA = new JalapenoChilies(newIngredientSA);
                                break;
                        }// end switch
                        Console.Write("Do you want to add another filling to your ingredient? ");
                        userInputSA = Console.ReadLine();
                    } // end while loop
                    Console.WriteLine();
                    Console.WriteLine(newIngredientSA.GetDiscription() + " \tFinal Price: " + newIngredientSA.Cost().ToString("C"));
                    Console.WriteLine();
                    // ---------------------------- end observer testing
                }
                else if (ing == "Burrito" || ing == "burrito" || ing == "BURRITO")
                {
                    Burrito saBurrito = new Burrito(new SAIngredientFactory());
                    Console.WriteLine($"SA Burrito: {saBurrito.DescribeBurrito()}");
                    // ---------------------------- observer testing
                    Ingredient newIngredientSA = new Burrito(new SAIngredientFactory());
                    string userInputSA = "Yes";
                    string chosenFillingSA;
                    while (userInputSA == "Yes" || userInputSA == "yes" || userInputSA == "YES")
                    {
                        Console.Write("What filling do you want to add to your ingredient? ");
                        chosenFillingSA = Console.ReadLine();
                        switch (chosenFillingSA)
                        {
                            case "Chicken":
                            case "chicken":
                                newIngredientSA = new Chicken(newIngredientSA);
                                break;
                            case "Mutton":
                            case "mutton":
                                newIngredientSA = new Mutton(newIngredientSA);
                                break;
                            case "Samp":
                            case "samp":
                                newIngredientSA = new Samp(newIngredientSA);
                                break;
                            case "Cheddar Cheese":
                            case "cheddar cheese":
                            case "Cheddar cheese":
                                newIngredientSA = new CheddarCheese(newIngredientSA);
                                break;
                            case "Sliced Avocados":
                            case "sliced avocados":
                            case "Sliced avocados":
                                newIngredientSA = new SlicedAvocados(newIngredientSA);
                                break;
                            case "Jasmin Rice":
                            case "jasmin rice":
                            case "Jasmin rice":
                                newIngredientSA = new JasminRice(newIngredientSA);
                                break;
                            case "Refried Beans":
                            case "Refried beans":
                            case "refried beans":
                                newIngredientSA = new RefriedBeans(newIngredientSA);
                                break;
                            case "Smooth Cream Cheese":
                            case "smooth cream cheese":
                            case "Smooth Cream cheese":
                                newIngredientSA = new SmoothCreamCheese(newIngredientSA);
                                break;
                            case "Relish":
                            case "relish":
                                newIngredientSA = new Relish(newIngredientSA);
                                break;
                            case "Jalapeno Chilies":
                            case "jalapeno chilies":
                            case "Jalapeno chilies":
                                newIngredientSA = new JalapenoChilies(newIngredientSA);
                                break;
                        }// end switch
                        Console.Write("Do you want to add another filling to your ingredient? ");
                        userInputSA = Console.ReadLine();
                    } // end while loop
                    Console.WriteLine();
                    Console.WriteLine(newIngredientSA.GetDiscription() + " \tFinal Price: " + newIngredientSA.Cost().ToString("C"));
                    Console.WriteLine();
                    // ---------------------------- end observer testing
                }


            }
            else if (kitchen == "US" || kitchen == "us" || kitchen == "Us")
            {
                if (ing == "Taco" || ing == "taco" || ing == "TACO")
                {
                    Taco usTaco = new Taco(new USIngredientFactory());
                    Console.WriteLine($"US Taco: {usTaco.DescribeTaco()}");
                    // ---------------------- observer testing start
                    Ingredient newIngredientUS = new Taco(new USIngredientFactory());
                    string userInputUS = "Yes";
                    string chosenFillingUS;
                    while (userInputUS == "Yes" || userInputUS == "yes" || userInputUS == "YES")
                    {
                        Console.Write("What filling do you want to add to your ingredient? ");
                        chosenFillingUS = Console.ReadLine();
                        switch (chosenFillingUS)
                        {
                            case "Turkey":
                            case "turkey":
                                newIngredientUS = new Turkey(newIngredientUS);
                                break;
                            case "Beef":
                            case "beef":
                                newIngredientUS = new Beef(newIngredientUS);
                                break;
                            case "Chickpeas":
                            case "chickpeas":
                                newIngredientUS = new Chickpeas(newIngredientUS);
                                break;
                            case "Pepper Jack Cheese":
                            case "pepper jack cheese":
                            case "Pepper jack cheese":
                                newIngredientUS = new PepperJackCheese(newIngredientUS);
                                break;
                            case "Guacamole":
                            case "guacomole":
                                newIngredientUS = new Guacamole(newIngredientUS);
                                break;
                            case "Basmati Rice":
                            case "basmati rice":
                            case "Basmati rice":
                                newIngredientUS = new BasmatiRice(newIngredientUS);
                                break;
                            case "Black Beans":
                            case "black beans":
                            case "Black beans":
                                newIngredientUS = new BlackBeans(newIngredientUS);
                                break;
                            case "Chunky Cream Cheese":
                            case "chunky cream cheese":
                            case "Chunky Cream cheese":
                                newIngredientUS = new ChunkyCreamCheese(newIngredientUS);
                                break;
                            case "Salsa":
                            case "salsa":
                                newIngredientUS = new Salsa(newIngredientUS);
                                break;
                            case "Habanero Chilies":
                            case "habanero chilies":
                            case "Habanero chilies":
                                newIngredientUS = new HabaneroChilies(newIngredientUS);
                                break;
                        }// end switch
                        Console.Write("Do you want to add another filling to your ingredient? ");
                        userInputUS = Console.ReadLine();
                    } // end while loop
                    Console.WriteLine();
                    Console.WriteLine(newIngredientUS.GetDiscription() + " \tFinal Price: " + newIngredientUS.Cost().ToString("C"));
                    Console.WriteLine();
                    // ---------------------- observer testing end
                }
                else if (ing == "Burrito" || ing == "burrito" || ing == "BURRITO")
                {
                    Burrito usBurrito = new Burrito(new USIngredientFactory());
                    Console.WriteLine($"US Burrito: {usBurrito.DescribeBurrito()}");
                    // ---------------------- observer testing start
                    Ingredient newIngredientUS = new Burrito(new USIngredientFactory());
                    string userInputUS = "Yes";
                    string chosenFillingUS;
                    while (userInputUS == "Yes" || userInputUS == "yes" || userInputUS == "YES")
                    {
                        Console.Write("What filling do you want to add to your ingredient? ");
                        chosenFillingUS = Console.ReadLine();
                        switch (chosenFillingUS)
                        {
                            case "Turkey":
                            case "turkey":
                                newIngredientUS = new Turkey(newIngredientUS);
                                break;
                            case "Beef":
                            case "beef":
                                newIngredientUS = new Beef(newIngredientUS);
                                break;
                            case "Chickpeas":
                            case "chickpeas":
                                newIngredientUS = new Chickpeas(newIngredientUS);
                                break;
                            case "Pepper Jack Cheese":
                            case "pepper jack cheese":
                            case "Pepper jack cheese":
                                newIngredientUS = new PepperJackCheese(newIngredientUS);
                                break;
                            case "Guacamole":
                            case "guacomole":
                                newIngredientUS = new Guacamole(newIngredientUS);
                                break;
                            case "Basmati Rice":
                            case "basmati rice":
                            case "Basmati rice":
                                newIngredientUS = new BasmatiRice(newIngredientUS);
                                break;
                            case "Black Beans":
                            case "black beans":
                            case "Black beans":
                                newIngredientUS = new BlackBeans(newIngredientUS);
                                break;
                            case "Chunky Cream Cheese":
                            case "chunky cream cheese":
                            case "Chunky Cream cheese":
                                newIngredientUS = new ChunkyCreamCheese(newIngredientUS);
                                break;
                            case "Salsa":
                            case "salsa":
                                newIngredientUS = new Salsa(newIngredientUS);
                                break;
                            case "Habanero Chilies":
                            case "habanero chilies":
                            case "Habanero chilies":
                                newIngredientUS = new HabaneroChilies(newIngredientUS);
                                break;
                        }// end switch
                        Console.Write("Do you want to add another filling to your ingredient? ");
                        userInputUS = Console.ReadLine();
                    } // end while loop
                    Console.WriteLine();
                    Console.WriteLine(newIngredientUS.GetDiscription() + " \tFinal Price: " + newIngredientUS.Cost().ToString("C"));
                    Console.WriteLine();
                    // ---------------------- observer testing end
                }



            }
            
            Console.ReadLine();
        }
    }
}
