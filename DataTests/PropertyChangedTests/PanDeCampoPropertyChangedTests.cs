/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Pan De Campo
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
    public class PanDeCampoPropertyChangedTests
    {
        [Fact]
        public void PandeCampoImplementsINotifyPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pdc);
        }
        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Price", () => {
                panDeCampo.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var panDeCampo = new PanDeCampo();
            Assert.PropertyChanged(panDeCampo, "Calories", () => {
                panDeCampo.Size = Size.Large;
            });
        }
    }
}
