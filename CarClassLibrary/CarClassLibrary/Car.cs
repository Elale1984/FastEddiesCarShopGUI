using System;
using System.Collections.Generic;
using System.Text;

/*
 *                                      <Class Car Documentation>
 *  
 * This is the Car class. This class holds all of the properties of a car when a car is created for the inventory.
 * The properties are in get/set format. There are two constructiors in this class. One ARGS constructor and one 
 * default constructior. Also, an overrided toString() method is added for display of a created Car object. 
 */

namespace CarClassLibrary
{
    public class Car
    {
      
        // Properties w/ Get/Set
        public String Make { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public int Miles { get; set; }
        public decimal Price { get; set; }

        //ARGS Constructor
        public Car(string make, string model, string color, int miles, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Miles = miles;
            this.Price = price;
        }

        // No/ARGS Constructior (or default)
        public Car()
        {
            this.Make = "Nothing Yet";
            this.Model = "Nothing Yet";
            this.Color = "Black";
            this.Miles = 100000;
            this.Price = 0;
        }

        /*
         * The purpose of overriding this toString() method is to display the car object in a manor that 
         * coinsides with the flow of the rest of the program. 
         */
        public override string ToString()
        {
           
           
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return "\n\tMake: " + this.Make  
                + "\n\tModel: " + this.Model 
                + "\n\tColor: " + this.Color 
                + "\n\tMiles: " + this.Miles
                + String.Format("\n\tPrice: {0:C}", this.Price)
                + "\n";
        }
    }
}
