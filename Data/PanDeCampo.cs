/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the Pan De Campo side 
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
	/// <summary>
	/// Class representing the Pan De Campo Side 
	/// </summary>
    public class PanDeCampo : Side 
    {
		/// <summary>
		/// The calories of the Pan De Campo side 
		/// </summary>

		public override uint Calories
		{

			get
			{
				switch (Size)
				{
					case Size.Small:
						return 227;
					case Size.Medium:
						return 269;
					case Size.Large:
						return 367;
					default:
						throw new NotImplementedException();
				}
			}
		}

		/// <summary>
		/// Price of the chili cheese fries 
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small:
						return 1.59;
					case Size.Medium:
						return 1.79;
					case Size.Large:
						return 1.99;
					default:
						throw new NotImplementedException();
				}
			}
		}

		/// <summary>
		/// Returns the string representation of this object
		/// </summary>
		/// <returns>The string describing the Pan de Campo</returns>
		public override string ToString()
		{
			return Size.ToString() + " Pan de Campo";
		}
	}
}
