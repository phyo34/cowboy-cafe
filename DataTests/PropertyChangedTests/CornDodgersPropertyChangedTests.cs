/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Corn Dodgers
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var cd = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cd);
        }
        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Price", () => {
                cornDodgers.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var cornDodgers = new CornDodgers();
            Assert.PropertyChanged(cornDodgers, "Calories", () => {
                cornDodgers.Size = Size.Large;
            });
        }

    }
}
