/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Dakota Double Burger entree
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the dakota burger entree
    /// </summary>
   public  class DakotaDoubleBurger : Entree
    {

        /// <summary>
        /// The price of the Dakota burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Dakota burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If the Dakota Burger should be served with ketchup 
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should be served with Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should be served with pickles 
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should be served with cheese 
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should be served with buns
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should have Tomato 
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should have Lettuce  
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the Dakota Burger should have Mayo 
        /// </summary>
        public bool Mayo { get; set; } = true;


        /// <summary>
        /// Provides special instructions for the Dakota Burger 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ketchup)
                {
                    instructions.Add("hold ketchup");
                }
                if (!Mustard)
                {
                    instructions.Add("hold mustard");
                }
                if (!Pickle)
                {
                    instructions.Add("hold pickle");
                }
                if (!Cheese)
                {
                    instructions.Add("hold cheese");
                }
                if (!Bun)
                {
                    instructions.Add("hold bun");
                }
                if (!Tomato)
                {
                    instructions.Add("hold tomato"); 
                }
                if (!Lettuce)
                {
                    instructions.Add("hold lettuce");
                }
                if (!Mayo)
                {
                    instructions.Add("hold mayo");
                }

                return instructions;
            }
        }




    }
}
