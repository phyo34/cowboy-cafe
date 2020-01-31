using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Public class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// The price of the Angry Chicken 
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99; 
            }
        }

        /// <summary>
        /// The calories of the Angry Chicken
        /// </summary>
        public uint Calories
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
        public List<string> SpecialInstructions
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

        


    }
}
