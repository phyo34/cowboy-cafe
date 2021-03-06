﻿/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the abstract class for drinks
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    
    {
        /// <summary>
        /// Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;

        /// <summary>
        ///     The size of the drink
        /// </summary>

        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }

       /// <summary>
       /// The calories of the drink
       /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        ///    The drink has ice
        /// </summary>


        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        public virtual bool Ice { get; set; } = true;


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
