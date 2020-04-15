/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Chili Cheese Fries
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
    public class ChiliCheeseFriesPropertyChangedTests
    {
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var ccf = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccf);
        }

        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheeseFries, "Price", () => {
                chiliCheeseFries.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var chiliCheese = new ChiliCheeseFries();
            Assert.PropertyChanged(chiliCheese, "Calories", () => {
                chiliCheese.Size = Size.Large;
            });
        }
    }
}
