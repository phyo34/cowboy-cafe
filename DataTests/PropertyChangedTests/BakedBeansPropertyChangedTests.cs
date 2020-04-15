/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Baked Beans
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
    public class BakedBeansPropertyChangedTests
    {


        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var bak = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bak);
        }


        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () => {
                beans.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () => {
                beans.Size = Size.Large;
            });
        }
    }
}
