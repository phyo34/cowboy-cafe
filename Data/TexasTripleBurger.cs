/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Texas Triple Burger entree 
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the Texas Tiple Burger 
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the Texas Triple Burger 
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }
       
        /// <summary>
        /// Private variable for kethchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If the Texas Triple Burger should be served with ketchup 
        /// </summary>
        public bool Ketchup { 
            get { return ketchup; }
            set { ketchup = value; NotifyOfPropertyChange("Pickle"); }
        }


        /// <summary>
        /// Private variable for mustad 
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the Texas Triple Burger should be served with Mustard
        /// </summary>
        public bool Mustard {
            get { return mustard; }
            set { mustard = value; NotifyOfPropertyChange("Pickle"); }
        }


        /// <summary>
        /// Private bool for pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// If the Texas Triple Burger should be served with pickles 
        /// </summary>
        public bool Pickle {
            get { return pickle; }
            set { pickle = value; NotifyOfPropertyChange("Pickle"); }
        }

        /// <summary>
        /// Private bool for cheese
        /// </summary>

        private bool cheese = true;
        /// <summary>
        /// If the Texas Triple Burger should be served with cheese 
        /// </summary>
        public bool Cheese {
            get { return cheese; }
            set { cheese = value; NotifyOfPropertyChange("Cheese"); }
        } 


        /// <summary>
        /// private bool for buns 
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the Texas Triple Burger should be served with buns
        /// </summary>
        public bool Bun {
            get { return bun; }
            set { bun = value; NotifyOfPropertyChange("Bun"); }
        }

        /// <summary>
        /// Private bool for tomato 
        /// </summary>
        private bool tomato = true; 

        /// <summary>
        /// If the Texas Triple Burger should have Tomato 
        /// </summary>
        public bool Tomato {
            get { return tomato; }
            set { tomato = value; NotifyOfPropertyChange("Tomato"); }
        } 

        /// <summary>
        /// private bool for lettuce 
        /// </summary>

        private bool lettuce = true; 

        /// <summary>
        /// If the Texas Triple Burger should have Lettuce  
        /// </summary>
        public bool Lettuce {
            get { return lettuce; }
            set { lettuce = value; NotifyOfPropertyChange("Lettuce"); }
        } 

        /// <summary>
        /// Private bool for mayo 
        /// </summary>

        private bool mayo = true; 

        /// <summary>
        /// If the Texas Triple Burger should have Mayo 
        /// </summary>
        public bool Mayo {
            get { return mayo; }
            set { mayo = value; NotifyOfPropertyChange("Pickle"); }
        } 
       
        /// <summary>
        /// Private bool for bacon 
        /// </summary>

        private bool bacon = true;

        /// <summary>
        /// If the Texas Triple burger should have bacon 
        /// </summary>
        public bool Bacon {
            get { return bacon; }
            set { bacon = value; NotifyOfPropertyChange("Bacon"); }
        } 

        /// <summary>
        /// Private bool for egg 
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// If the Texas Triple burger should have egg 
        /// </summary>
        public bool Egg {
            get { return egg; }
            set { egg = value; NotifyOfPropertyChange("Egg"); }
        } 

        /// <summary>
        /// Provides special instructions for the Texas Triple Burger 
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
                if (!Bacon)
                {
                    instructions.Add("hold bacon");

                }
                if (!Egg)
                {
                    instructions.Add("hold egg");
                }

                return instructions;
            }


        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Texas Triple Burger</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";

        }
    }
}
