using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Kyle Rolland
 * Date: 1/23/2021
 * File: Item.cs
 * Description: Abstract class that serves as the base for the Vegetable, Textbook, and Toy_Car classes. Sets the groundwork/restrictions for its child classes, and has its functions called in them
 */

namespace Class_Project
{
    abstract class Item
    {
        //private variables
        private string type;
        private string name;
        private int quantity;
        private double price;

        //default constructor, unable to be accessed by user, but there just in case something goes wrong
        public Item()
        {
            type = "Generic Item";
            name = "Unnamed";
            quantity = 0;
            price = 0.00;
        }

        //parameterized constructor, called by child functions, and is the constructor user "interacts" with
        public Item(string type, string name, int quantity, double price)
        {
            this.type = type;
            this.name = name;
            this.quantity = quantity;
            this.price = price;

        }

        //the only non-virtual function, just here to get the name of the item, used for the purchasing and checking price capabilities
        public string getName()
        {
            return name;
        }

        //retrieves the item's price, overridden to be more specific in child functions
        public virtual void checkPrice()
        {
            Console.WriteLine(price.ToString("F2")); //To.String("F2") gotten from MSDN
        }

        //prints variable information for an item, called by child functions, overridden to add special qualities to the printed data, depending on the child
        public virtual void printInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: $" + price.ToString("F2")); 
        }

        //asks user how many of an item they want to purchase, and tells the total
        public virtual void purchase()
        {
            Console.WriteLine("Please enter the amount of " + name + "(s) that you would like to purchase: ");

            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Purchasing " + amount + " items totals to: $" + amount * price);
        }
    }
}
