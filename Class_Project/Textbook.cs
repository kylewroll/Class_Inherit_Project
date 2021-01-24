using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Author: Kyle Rolland
 * Date: 1/23/2021
 * File: Textbook.cs
 * Description: Concrete textbook class, calls function from abstract parent class, Item. Adds private pages variable, and overrides functions to be more specific
 */

namespace Class_Project
{
    class Textbook : Item
    {
        //special private variable for textbook class, the number of pages that the textbook has
        private int pages;

        //calls parent default constructor, adds the new pages variable, but once again not reachable by user
        public Textbook() : base()
        {
            pages = 0;
        }

        //calls parent parameterized constructor, adds the user input for pages as the pages variable
        public Textbook(string type, string name, int quantity, double price, int pages) : base("Textbook", name, quantity, price)
        {
            this.pages = pages;
        }

        //overridden check price, adds extra description and calls checkPrice function
        public override void checkPrice()
        {
            Console.Write("The price of this textbook is: $");
            base.checkPrice();
        }

        //overridden printInfo function, similar to other child classes, but adds pages instead
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine();
        }

        //specifies purchasing textbooks, and includes the page number specified by the user
        public override void purchase()
        {
            Console.WriteLine("Now purchasing textbooks, with " + pages + " pages in them.");
            base.purchase();
        }
    }
}
