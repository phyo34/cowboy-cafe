/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the water drink
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing water 
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }


        /// <summary>
        /// Private backing bool for ice
        /// </summary>
        private bool ice = true;


        /// <summary>
        /// If the water is served with lemons
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; NotifyOfPropertyChange("Ice"); }
        }

        /// <summary>
        /// Private backing bool for lemon
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// If the water is served with lemons
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; NotifyOfPropertyChange("Lemon"); }
        } 



        /// <summary>
        /// Provides special instructions for the Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }
               


                
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the water</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
