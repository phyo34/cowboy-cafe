/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the angry chicken entre
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Public class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        /// <summary>
        /// The price of the Angry Chicken 
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99; 
            }
        }

        /// <summary>
        /// The calories of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }
        /// <summary>
        /// Ensures that the Angry Chicken intially has bread
        /// </summary>
        private bool bread = true;
       
        /// <summary>
        /// If the Angry Chicken should be served with bread 
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// If the Angry Chicken should be served with pickles 
        /// </summary>
        public bool Pickle { get; set; } = true; 

        /// <summary>
        /// Provides special instructions for the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if(!Bread)
                {
                    instructions.Add("hold bread");
                }
                if (!Pickle)
                {
                    instructions.Add("hold pickle"); 
                }

                return instructions; 
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Angry Chicken</returns>
        public override string ToString()
        {
           return "Angry Chicken";
        }


    }
}
