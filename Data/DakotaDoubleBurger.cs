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

        private bool ketchup = true;
        /// <summary>
        /// If the Dakota Burger should be served with ketchup 
        /// </summary>
        public bool Ketchup {
            get { return ketchup; }

            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            } 
        }

        /// <summary>
        /// Private backing variable for mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the Dakota Burger should be served with Mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }

            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        } 

        /// <summary>
        /// Private backing variable for pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the Dakota Burger should be served with pickles 
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }

            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// Private backing variable for cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the Dakota Burger should be served with cheese 
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }

            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// Private backing variable for bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the Dakota Burger should be served with buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }

            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        } 

        /// <summary>
        /// Private backing variable for tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// If the Dakota Burger should have Tomato 
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }

            set
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        } 


        /// <summary>
        /// Private backing variable for lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// If the Dakota Burger should have Lettuce  
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }

            set
            {
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        } 

        /// <summary>
        /// Private backing variable for mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// If the Dakota Burger should have Mayo 
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }

            set
            {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        } 


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

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Dakota Double</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }


    }
}
