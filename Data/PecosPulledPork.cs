using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
       
            /// <summary>
            /// The price of the Pecos Pulled Pork 
            /// </summary>
            public double Price
            {
                get
                {
                    return 5.88;
                }
            }

            /// <summary>
            /// The calories of the Pecos Pulled Pork 
            /// </summary>
            public uint Calories
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
            public List<string> SpecialInstructions
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
        
    }
}
