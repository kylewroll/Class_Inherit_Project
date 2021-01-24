using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Kyle Rolland
 * Date: 1/23/2021
 * File: Vegetable.cs
 * Description: Concrete vegetable class, calls function from abstract parent class, Item. Adds private quality variable, and overrides functions to be more specific
 */

namespace Class_Project
{
    class Vegetable : Item
    {
        //the only private variable specific to Vegetable class, the "quality" of the vegetable, how good it looks. Just something to help with overriding parent functions
        private string quality;

        //calls default parent constructor, unable to be accessed by user
        public Vegetable() : base()
        {
            quality = "Unknown";
        }

        //calls parameterized parent constructor, uses user input to create the item, adds the quality variable, special and specific to the vegetable class
        public Vegetable(string type, string name, int quantity, double price, string quality) : base("Vegetable", name, quantity, price)
        {
            this.quality = quality;
        }

        //overridden checkPrice function, tells user that they are checking the price of a vegetable, then calls parent checkPrice function
        public override void checkPrice()
        {
            Console.Write("The price of this vegetable is: $");
            base.checkPrice();
        }

        //overriden printInfo function, calls parent printInfo, then appends a printing of the quality, then prints a line for readability
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Quality: " + quality);
            Console.WriteLine();
        }

        //overridden purchase function, informs the user that they are indeed purchasing vegetables, followed by their quality, then calls parent purchase function
        public override void purchase()
        {
            Console.WriteLine("Now purchasing vegetables, of " + quality + " quality.");
            base.purchase();
        }
    }
}
