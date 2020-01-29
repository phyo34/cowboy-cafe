using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the rib
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the rib 
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Provides special instructions for the Angry Chicken
        /// </summary>
        public List<string> SpecialInstructions 
        {
            get
            {
                //Returns an empty list
                List<string> instructions = new List<string>();
                return instructions; 
            }

          
        }

        

    }
}
