using System;
using System.Linq;

namespace Tienda_Virtual
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Data//
            string[] Products = { "Shampoo", "Soap", "Deodorant", "Perfume" };
            string[] Codes = { "10000", "10001", "10002", "10003" };
            double[] Prices = { 20.99, 8.5, 12, 25.99 };


            //Needs for all//
            Convert_To_Lower usrChoice = new Convert_To_Lower();
            UsrLogin callLogin = new UsrLogin();
            BuyingProcess callBuy = new BuyingProcess();
            string choiceToLower = null;
            string choosingMenu = null;
            string usrName = null;
            string usrLogged = null;
            int getNum = 0;





            //  -----------------------------------------------------------------//
            Console.WriteLine("Welcome to our Virtual Store!");

            do
            {
                toTop:
                Console.WriteLine("Would you like to see our Menu?");
                Console.WriteLine("a)Yes"  + "  b)No " +  " c)Exit");
                string showMenu = Console.ReadLine();
                choiceToLower = usrChoice.makeLower(showMenu);
                if (choiceToLower == "yes" | choiceToLower == "a")
                {
                    mainMenu:
                    string menuLogin = "a) Login";
                    string menuProducts = "b) Products";
                    string menuContact = "c) Contact";
                    Console.WriteLine("Menu: " + "\n" + menuLogin + "\n" + menuProducts + "\n" + menuContact);
                    string menuSelection = Console.ReadLine();
                    choosingMenu = usrChoice.makeLower(menuSelection);
                    signInMenu:
                    if (choosingMenu == "Login" | choosingMenu == "a")
                    {
                        Console.WriteLine("Would you like to Sign In?");
                        Console.WriteLine("a)Yes" + " b)No");
                        string choiceSingIn = Console.ReadLine();
                        usrLogged = usrChoice.makeLower(choiceSingIn);
                        switch (usrLogged)
                        {
                            case "yes":
                                usrName = callLogin.getName();
                                callLogin.getLastName();
                                callLogin.getEmail();
                                callLogin.getAge();
                                callLogin.getDirection();
                                continue;
                            case "no":
                                Console.WriteLine("Would you like to go back?");
                                Console.WriteLine("a)Yes " + "b)No");
                                string secondSignIn = Console.ReadLine();
                                choiceToLower = usrChoice.makeLower(secondSignIn);
                                if (choiceToLower == "yes" || choiceToLower == "a")
                                {
                                    goto signInMenu;
                                }
                                else if (choiceToLower == "no" || choiceToLower == "b")
                                {
                                    goto mainMenu;
                                }
                                continue;
                        }
                        continue;
                    }

                    if (choosingMenu == "products" | choosingMenu == "b")
                    {
                        if (usrLogged == "yes")
                        {
                            usrCatalog:
                            Console.WriteLine("Hello, " + usrName + "Would you like to see our catalog?");
                            Console.WriteLine("a)Yes " + "b)No");
                            string seeProducts = Console.ReadLine();
                            choiceToLower = usrChoice.makeLower(seeProducts);
                            if (choiceToLower == "yes")
                            {
                                Console.WriteLine(Codes[0] + " " + Products[0] + " " + Prices[0]);
                                Console.WriteLine(Codes[1] + " " + Products[1] + " " + Prices[1]);
                                Console.WriteLine(Codes[2] + " " + Products[2] + " " + Prices[2]);
                                Console.WriteLine(Codes[3] + " " + Products[3] + " " + Prices[3]);
                            }
                            else if (choiceToLower == "no")
                            {
                                Console.WriteLine("Would you like to go back?");
                                string goBackCatalog = Console.ReadLine();
                                choiceToLower = usrChoice.makeLower(goBackCatalog);
                                if (choiceToLower == "yes")
                                {
                                    goto usrCatalog;
                                }

                                else if (choiceToLower == "no")
                                {
                                    goto mainMenu;
                                }
                            }
                        }
                        else
                        {
                            noUsrCatalog:
                            Console.WriteLine("Hello, Would you like to see our catalog?");
                            Console.WriteLine("a)Yes " + "b)No");
                            string seeProducts = Console.ReadLine();
                            choiceToLower = usrChoice.makeLower(seeProducts);
                            if (choiceToLower == "yes")
                            {
                                Console.WriteLine(Codes[0] + " " + Products[0] + " " + Prices[0]);
                                Console.WriteLine(Codes[1] + " " + Products[1] + " " + Prices[1]);
                                Console.WriteLine(Codes[2] + " " + Products[2] + " " + Prices[2]);
                                Console.WriteLine(Codes[3] + " " + Products[3] + " " + Prices[3]);
                            }
                            else if (choiceToLower == "no")
                            {
                                Console.WriteLine("Would you like to go back?");
                                string goBackCatalog = Console.ReadLine();
                                choiceToLower = usrChoice.makeLower(goBackCatalog);
                                if (choiceToLower == "yes")
                                {
                                    goto noUsrCatalog;
                                }

                                else if (choiceToLower == "no")
                                {
                                    goto mainMenu;
                                }
                            }
                        }
                        Console.WriteLine("Are you interested in any product?");
                        Console.WriteLine("a)Yes " + " b)No");
                        string chooseToBuy = Console.ReadLine();
                        choiceToLower = usrChoice.makeLower(chooseToBuy);
                        if (choiceToLower == "yes" | choiceToLower == "a")
                        {
                            Console.WriteLine("Which product you want?");
                            Console.WriteLine("(Write the Code, please)");
                            string chooseProduct = Console.ReadLine();
                            foreach (string Code in Codes)
                            {
                                if (Code == chooseProduct)
                                {
                                    getNum = Array.IndexOf(Codes, chooseProduct);
                                    continue;
                                }
                            }
                            double getingPrice = Prices[getNum];
                            int Quantity = callBuy.getQuantity();
                            callBuy.doMath(Quantity, getingPrice);
                            if (usrLogged == "yes")
                            {
                                Console.WriteLine("We will send the Product(s) to:"+ "\n" + callLogin.getDirection() );
                                
                            }
                            else
                            {
                                Console.WriteLine("Would you like to login?");
                                Console.WriteLine("a)Yes " + " b)No");
                                string fromBuytoLog = Console.ReadLine();
                                choiceToLower = usrChoice.makeLower(fromBuytoLog);
                                if (choiceToLower == "yes" || choiceToLower == "a")
                                {
                                    goto signInMenu;
                                }
                                else if(choiceToLower == "no" || choiceToLower == "b" )
                                {
                                    goto mainMenu;
                                }
                            }
                        }
                    }
                }
                else if (choiceToLower == "no" | choiceToLower == "b")
                {
                    Console.WriteLine("Would you like to go back?");
                    Console.WriteLine("a)Yes" + "b)No");
                    string goBack = Console.ReadLine();
                    choiceToLower = usrChoice.makeLower(goBack);
                    switch (choiceToLower)
                    {
                        case "yes":
                            goto toTop;

                        case "no":
                            break;

                    }
                }
            } while (choiceToLower != "exit" | choiceToLower == "c");
            Console.WriteLine("See you soon!");
            
        }

    }
}
