/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the corn dodger side 
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
	/// <summary>
	/// Public class representing the corn dodger side 
	/// </summary>
	public class CornDodgers : Side
    {
		/// <summary>
		/// The calories of the corn dodgers side
		///  </summary>

		public override uint Calories
		{

			get
			{
				switch (Size)
				{
					case Size.Small:
						return 512;
					case Size.Medium:
						return 685;
					case Size.Large:
						return 717;
					default:
						throw new NotImplementedException();
				}
			}
		}
		/// <summary>
		/// Price of the corn dodger side 
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
		/// <returns>The string describing the Corn Dodgers</returns>
		public override string ToString()
		{
			return Size.ToString() + " Corn Dodgers";
		}
	}
}
