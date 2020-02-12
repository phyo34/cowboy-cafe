using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        //The size of the drink
        public Size Size { get; set; } = Size.Small; 

        //The price of the drink
        public abstract double Price { get; }

        //The calories of the drink
        public abstract uint Calories { get; }
        
        //The drink has ice
        public bool Ice { get; set; } = true; 

        //The special instructions for the drink 
        public abstract List<string> SpecialInstructions { get; }
        
        
    }
}
