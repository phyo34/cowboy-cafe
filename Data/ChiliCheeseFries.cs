/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the chili cheese fries side
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
/// <summary>
/// Public class representing the chili cheese fries side 
/// </summary>
{
	public  class ChiliCheeseFries : Side
	{
		/// <summary>
		/// The calories of the chili cheese fries side 
		/// </summary>
		public override uint Calories
		{
		
			get
			{
				switch (Size)
				{
					case Size.Small:
						return 433;
					case Size.Medium:
						return 524;
					case Size.Large:
						return 610;
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
						return 1.99;
					case Size.Medium:
						return 2.99;
					case Size.Large:
						return 3.99;
					default:
						throw new NotImplementedException();
				}
			}
		}

	}
	
}
