using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem
    {
        //The size of the drink
        public Size Size { get; set; } = Size.Small; 

        //The price of the drink
        public abstract double Price { get; }

        //The calories of the drink
        public abstract uint Calories { get; }

        /// <summary>
        ///    The drink has ice
        /// </summary>

        public virtual bool Ice { get; set; } = true; 
        /// <summary>
        /// Gets the special instrutions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        
        
    }
}
