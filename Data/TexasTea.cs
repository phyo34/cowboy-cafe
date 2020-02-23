/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Texas Tea drink
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Tea
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// The price of the Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 10;
                    case Size.Medium:
                        return 22;
                    case Size.Large:
                        return 36;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// If the tea is served with lemons
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// If the tea is served sweet
        /// </summary>
        public bool Sweet { get; set; } = false;

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
        /// <returns>The string describing the Texas Tea</returns>
        public override string ToString()
        {
            string s = Size.ToString() + " ";
            if (Sweet) return s + "Texas Sweet Tea";
            else return s + "Texas Plain Tea";
        }
    }
}
