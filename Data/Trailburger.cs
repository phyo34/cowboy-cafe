﻿/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Trail Burger entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the trail burger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The price of the Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// If the Trail Burger should be served with ketchup 
        /// </summary>
        public bool Ketchup { get; set; } = true; 

        /// <summary>
        /// If the Trail Burger should be served with Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Trail Burger should be served with pickles 
        /// </summary>
        public bool Pickle { get; set; } = true;

      
        /// <summary>
        /// Ensures that the Trail Burger intially has cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the Trail Burger should be served with cheese 
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// If the Trail Burger should be served with bun 
        /// </summary>
        public bool Bun { get; set; } = true; 


        /// <summary>
        /// Provides special instructions for the Trail Burger 
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

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the TrailBurger</returns>
        public override string ToString()
        {
            return "Trail Burger";


        }
    }
}
