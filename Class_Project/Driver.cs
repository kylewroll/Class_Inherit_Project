using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Kyle Rolland
 * Date: 1/23/2021
 * File: Driver.cs
 * Description: Main driver for program, creates list and gives user various options on how to modify it (adding items, checking items, purchasing items)
 */

namespace Class_Project
{
    class Driver
    {
        static void Main(string[] args)
        {
            
            List<Item> store = new List<Item>();

            int choice = 0;

            //used in the switch statement
            string name;
            int amount;
            double price;
            string search;


            while (choice != 5)
            {
                Console.WriteLine("You are now accessing the store, we have textbooks, vegetables, and toy cars, what more could you need?");

                Console.WriteLine("Please choose what you would like to do: ");

                Console.WriteLine("1. Print the store inventory");
                Console.WriteLine("2. Add an item to the store");
                Console.WriteLine("3. Check the prices of an item");
                Console.WriteLine("4. Purchase an item");
                Console.WriteLine("5. Exit the program");


                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:

                        Console.WriteLine("Printing the contents of the store: ");
                        Console.WriteLine();

                        foreach (Item thing in store) //foreach gotten from MSDN
                        {
                            thing.printInfo();
                        }

                        Console.WriteLine();
                        break;

                    case 2:

                        Console.WriteLine("What type of item would you like to add to the store: ");

                        Console.WriteLine("1. Vegetable");
                        Console.WriteLine("2. Textbook");
                        Console.WriteLine("3. Toy Car");

                        choice = Convert.ToInt32(Console.ReadLine());
                        
                        if (choice == 1)
                        {
                            //I could have reworked this so that these questions only appeared once, but it means that I wouldn't be able to vet whether the item was one of the 
                            //3 before getting its information

                            //spacing looks different to help with readability

                            Console.WriteLine("Please enter the name of the vegetable: ");
                            name = Console.ReadLine();


                            Console.WriteLine("Please enter the amount of the vegetable in stock: ");
                            amount = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("Please enter the price of the vegetable: ");
                            price = Convert.ToDouble(Console.ReadLine()); //conversion to double so that price can be something that isnt a whole number


                            string quality;
                            Console.WriteLine("Please enter the quality of the vegetable: ");
                            quality = Console.ReadLine();



                            Vegetable temp = new Vegetable("Vegetable", name, amount, price, quality); //temporary vegetable used for adding to the list

                            store.Add(temp);
                        }

                        else if (choice == 2)
                        {
                            Console.WriteLine("Please enter the name of the textbook: ");
                            name = Console.ReadLine();


                            Console.WriteLine("Please enter the amount of the textbook in stock: ");
                            amount = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("Please enter the price of the textbook: ");
                            price = Convert.ToDouble(Console.ReadLine());


                            int pages;
                            Console.WriteLine("Please enter the number of pages in the textbook: ");
                            pages = Convert.ToInt32(Console.ReadLine());



                            Textbook temp = new Textbook("Textbook", name, amount, price, pages); //temporary textbook used for adding to the list

                            store.Add(temp);
                        }

                        else if (choice == 3)
                        {
                            Console.WriteLine("Please enter the name of the toy car: ");
                            name = Console.ReadLine();


                            Console.WriteLine("Please enter the amount of the toy car in stock: ");
                            amount = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("Please enter the price of the toy car: ");
                            price = Convert.ToDouble(Console.ReadLine()); 


                            string decal;
                            Console.WriteLine("Please describe the decal of the toy car: ");
                            decal = Console.ReadLine();



                            Toy_Car temp = new Toy_Car("Toy Car", name, amount, price, decal); //temporary toy car used for adding to the list

                            store.Add(temp);
                        }

                        else
                        {
                            Console.WriteLine("ERROR: Bad input, please choose a valid number");
                        }

                        break;

                        //these next two cases look the same, because it was less work to ask the user for what they wanted to purchase, instead of listing all the items in the output
                        //unfortunately I couldn't get a catch statement to work properly for things that arent on the list, so it just doesn't print anything out if you type in an item 
                        //that isn't present
                    case 3:

                        Console.WriteLine("Please enter the name of the item you would like to price-check: ");
                        search = Console.ReadLine();

                        foreach(Item thing in store)
                        {
                            if(search == thing.getName())
                            {
                                thing.checkPrice();
                            }
                        }

                        break;

                    case 4:

                        Console.WriteLine("Please enter the name of the item you would like to purchase: ");
                        search = Console.ReadLine();

                        foreach (Item thing in store)
                        {
                            if (search == thing.getName())
                            {
                                thing.purchase();
                                break;
                            }
                        }

                        break;

                    case 5:

                        Console.WriteLine("Thank you for using the store, have a good day.");
                        Console.ReadKey(); //here so that the user can see the error message before the window closes
                        return;

                    default:

                        Console.WriteLine("ERROR: Bad input, please choose a valid number");
                        Console.ReadKey(); //see previous console.readkey()
                        return;
                }

            }
        }
    }
}
