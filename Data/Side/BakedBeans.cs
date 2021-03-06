﻿/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the baked bean sides 
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
	/// <summary>
	/// Public class representing the baked bean side 
	/// </summary>
	public class BakedBeans : Side
    {
		/// <summary>
		/// The calories of the baked bean side 
		/// </summary>
		public override uint Calories
		{

			get
			{
				switch (Size)
				{
					case Size.Small:
						return 312;
					case Size.Medium:
						return 378;
					case Size.Large:
						return 410;
					default:
						throw new NotImplementedException();
				}
			}
		}

		/// <summary>
		/// Price of the baked bean side 
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
		/// <returns>The string describing the baked beans</returns>
		public override string ToString()
		{
			return Size.ToString() + " Baked Beans";
		}
	}
}
