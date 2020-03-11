/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the jerked soda drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    ///  Class reprsenting jerked soda
    /// </summary>

    public class JerkedSoda : Drink
    {
        /// <summary>
        ///   The price of a jerked soda 
        /// </summary>

        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    
    /// <summary>
    /// The calories of the jerked soda
    /// </summary>
        public override uint Calories {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Private backing variable for soda flavor 
        /// </summary>

        private SodaFlavor flavor;

        /// <summary>
        /// The flavor of the soda 
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; NotifyOfPropertyChange("Flavor"); }
        }

 

        /// <summary>
        /// Provides special instructions for the jerked soda
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

              

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Jerked Soda/returns>
        public override string ToString()
        {
            string s = Size.ToString() + " ";
            string flavor  = Flavor.ToString();
            if (flavor.Equals("CreamSoda"))
                return s + "Cream Soda Jerked Soda";
            else if (flavor.Equals("OrangeSoda"))
                return s + "Orange Soda Jerked Soda";
            else if (flavor.Equals("Sarsparilla"))
                return s + "Sarsparilla Jerked Soda";
            else if (flavor.Equals("BirchBeer"))
                return s + "Birch Beer Jerked Soda";
            else
                return s + "Root Beer Jerked Soda";

        }
    }
}
