using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Rustler's Rib entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the rib
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the rib 
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Provides special instructions for the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions 
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
