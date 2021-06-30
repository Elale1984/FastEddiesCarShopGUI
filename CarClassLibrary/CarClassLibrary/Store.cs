using System;
using System.Collections.Generic;
using System.Text;

/*
 *      <Class Store Documentation>
 *  
 *  This is the store class. This class creates two list of <type> car for the use of storing user additions 
 *  and selections in their respective lists. This class only has the two lists as properties w/getters and setters,
 *  the default constructor, and a single method that calculates the total cost upon checkout.
 */

namespace CarClassLibrary
{
    public class Store
    {
       

        public List<Car> CarList  { get; set; } // list for the showroom
        public List<Car> ShoppingCartList { get; set; } // list for the users shopping cart

        public Store() // only default constructior needed because the creation of these lists are required befor the application can run.
        {
            CarList = new List<Car>();
            ShoppingCartList = new List<Car>();
        }

        /*
         * The purpose of this method is to calculate the users total cost upon choosing to check out. It returns the total cost by 
         * itterating through the shoppingCartList and adding the cost of each car in the shopping cart.
         */
        public decimal Checkout() 
        {
            decimal totalCost = 0;

            //This foreach loop itterates through the ShoppincartList and takes the price of each car and adds them to the total price.
            foreach (var shoppingCartItem in ShoppingCartList)
            {
                totalCost += shoppingCartItem.Price;
                
            }

            ShoppingCartList.Clear(); // Clears the ShoppingCartList

            return totalCost; // returns the total cost of all of the cars in the shopping cart

        }
    }
}
