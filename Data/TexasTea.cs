/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Texas Tea drink
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Tea
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }

              else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }


                }
            }
        }

        ///<summary>
        /// Private backing variable for ICe
        /// </summary>

        private bool ice = true;
        /// <summary>
        /// If the tea is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; NotifyOfPropertyChange("Ice"); }
        }

        /// <summary>
        /// Private backing variable for lemons
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// If the tea is served with lemons
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; NotifyOfPropertyChange("Lemon"); }
        }

        /// <summary>
        /// Private backing bool for sweetness of tea
        /// </summary>

        private bool sweet = true;
        /// <summary>
        /// If the tea is served sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; NotifyOfPropertyChange("Sweet"); }
        } 

        /// <summary>
        /// Provides special instructions for the Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }



                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Texas Tea</returns>
        public override string ToString()
        {
            string s = Size.ToString() + " ";
            if (Sweet) return s + "Texas Sweet Tea";
            else return s + "Texas Plain Tea";
        }
    }
}
