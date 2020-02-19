﻿/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Pecos Pulled Pork entree
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
       
            /// <summary>
            /// The price of the Pecos Pulled Pork 
            /// </summary>
            public override double Price
            {
                get
                {
                    return 5.88;
                }
            }

            /// <summary>
            /// The calories of the Pecos Pulled Pork 
            /// </summary>
            public override uint Calories
            {
                get
                {
                    return 528;
                }
            }
            /// <summary>
            /// Ensures that the Pecos Pulled Pork intially has bread
            /// </summary>
            private bool bread = true;

            /// <summary>
            /// If the Pecos Pulled Pork should be served with bread 
            /// </summary>
            public bool Bread
            {
                get { return bread; }
                set { bread = value; }
            }

            /// <summary>
            /// If the Pecos Pulled Pork should be served with pickles 
            /// </summary>
            public bool Pickle { get; set; } = true;

            /// <summary>
            /// Provides special instructions for the Pecos Pulled Pork 
            /// </summary>
            public override List<string> SpecialInstructions
            {
                get
                {
                    List<string> instructions = new List<string>();
                    if (!Bread)
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
        /// <returns>The string describing the Pecos Pulled Pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";


        }

    }
}
