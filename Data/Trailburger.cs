using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger
    {
        /// <summary>
        /// The price of the Trailburger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the Trailburger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// If the Pecos Pulled Pork should be served with ketchup 
        /// </summary>
        public bool Ketchup { get; set; } = true; 

        /// <summary>
        /// If the Pecos Pulled Pork should be served with Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Pecos Pulled Pork should be served with pickles 
        /// </summary>
        public bool Pickle { get; set; } = true;

      
        /// <summary>
        /// Ensures that the Pecos Pulled Pork intially has cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the Pecos Pulled Pork should be served with cheese 
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        public bool Bun { get; set; } = true; 


        /// <summary>
        /// Provides special instructions for the Pecos Pulled Pork 
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
