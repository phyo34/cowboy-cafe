/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Trail Burger entree
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel; 

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the trail burger entree
    /// </summary>
    public class TrailBurger : Entree, INotifyPropertyChanged
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
        /// Private backing variable for ketchup
        /// </summary>
        private bool ketchup = true; 
        /// <summary>
        /// If the Trail Burger should be served with ketchup 
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; NotifyOfPropertyChange("Ketchup"); }
        } 

        /// <summary>
        /// Private  backing variable for mustard 
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// If the Trail Burger should be served with Mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; NotifyOfPropertyChange("Mustard"); }
        }

        /// <summary>
        /// Private backing variable for pickles
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the Trail Burger should be served with pickles 
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; NotifyOfPropertyChange("Pickle"); }
        } 

      
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
            set { cheese = value; NotifyOfPropertyChange("Cheese"); }
        }

        /// <summary>
        /// Private backing variable for buns
        /// </summary>
        private bool bun;
        /// <summary>
        /// If the Trail Burger should be served with bun 
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; NotifyOfPropertyChange("Bun"); }
        } 


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
