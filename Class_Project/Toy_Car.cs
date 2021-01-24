using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Kyle Rolland
 * Date: 1/23/2021
 * File: Textbook.cs
 * Description: Concrete toy car class, calls function from abstract parent class, Item. Adds private decal variable, and overrides functions to be more specific
 */

namespace Class_Project
{
    class Toy_Car : Item
    {
        //private variable unique to toy car class, design on the car
        private string decal;

        //same case as other default constructors, can't be accessed by user, so it isn't seen
        public Toy_Car() : base()
        {
            decal = "Unknown";
        }

        //calls parameterized parent constructor with type as Toy Car, adds the decal variable 
        public Toy_Car(string type, string name, int quantity, double price, string decal) : base("Toy Car", name, quantity, price)
        {
            this.decal = decal;
        }

        //specifies that the price being displayed is for toy car, then calls parent function
        public override void checkPrice()
        {
            Console.Write("The price of this toy car is: $");
            base.checkPrice();
        }

        //calls parent function then prints out the decal description
        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Decal: " + decal);
            Console.WriteLine();
        }

        //informs user they are purchasing toy cars, with the decal they provided
        public override void purchase()
        {
            Console.WriteLine("Now purchasing toy cars, with " + decal + " as the decal.");
            base.purchase();
        }
    }
}
