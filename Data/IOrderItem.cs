/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the order interface
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order 
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item 
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The special instructions for this order 
        /// </summary>
        public List<string> SpecialInstructions { get; }

        /// <summary>
        /// The calories of the order item
        /// </summary>
        public uint Calories { get; }
    }

}
