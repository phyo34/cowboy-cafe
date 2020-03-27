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
       /// Private backing variable for decaf
       /// </summary>
        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf 
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; NotifyOfPropertyChange("Decaf"); }
        }

        /// <summary>
        /// Private backing variable for room for cream
        /// </summary>
        private bool roomforcream = false;
        /// <summary>
        /// If there is room for cream 
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; NotifyOfPropertyChange("Room for Cream"); }
        } 



        /// <summary>
        /// Private backing variable for room for ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// If the coffe should be served with Ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; NotifyOfPropertyChange("Ice"); }
        } 

        /// <summary>
        /// Provides special instructions for the Cowboy Coffee 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
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
        /// <returns>The string describing the Cowboy Coffee</returns>
        public override string ToString()
        {
            string s = Size.ToString() + " ";
            if (Decaf) return s + "Decaf Cowboy Coffee";
            else return s + "Cowboy Coffee";


        }
    }
}
