/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Cowboy Coffee
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Cowboy Coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
      /// <summary>
      /// The price of the Cowboy Coffee
      /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// The calories of the Cowboy Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// If the coffee is decaf 
        /// </summary>
        public bool Decaf  { get; set; }
        /// <summary>
        /// If there is room for cream 
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// If the coffe should be served with Ice
        /// </summary>
        public override bool Ice { get;set; } = false; 

        /// <summary>
        /// Provides special instructions for the Cowboy Coffee 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Texas Triple Burger</returns>
        public override string ToString()
        {
            string s = Size.ToString() + " ";
            if (Decaf) return s + "Decaf Cowboy Coffee";
            else return s + "Cowboy Coffee";


        }
    }
}
