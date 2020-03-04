/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the abstract class representing the entrees
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data 
{
    /// <summary>
    /// Abstract class representing the entree 
    /// </summary>
   public abstract  class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public abstract List <string> SpecialInstructions { get; }


        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }


        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }
    }
}
