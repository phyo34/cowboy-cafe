/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the abstract class representing the entrees
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data 
{
    /// <summary>
    /// Abstract class representing the entree 
    /// </summary>
   public abstract  class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
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

        /// <summary>
        /// Special instructions for the drink 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
