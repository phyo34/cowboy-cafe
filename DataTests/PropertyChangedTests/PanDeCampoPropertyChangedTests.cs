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
        //Test 1:Pan De Campo should implement the INotifyPropertyChangedInterface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var panDeCampo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(panDeCampo);
        }


        //Test 2: Changing size to Small should change to price for  Small Pan De Campo

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallPanDeCampoPrice()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Small;
            Assert.Equal<double>(1.59, panDeCampo.Price);
        }

        //Test 3: Changing size to Small should change to calories for Small Pan De Campo


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallPanDeCampoCalorie()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Small;
            Assert.Equal<double>(227, panDeCampo.Calories);
        }

        //Test 4: Changing size to Medium should change to price for  Medium Pan De Campo

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumPanDeCampoPrice()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Medium;
            Assert.Equal<double>(1.79, panDeCampo.Price);
        }

        //Test 5: Changing size to Medium should change to calories for Medium Pan De Campo


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumPanDeCampoCalorie()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Medium;
            Assert.Equal<double>(269, panDeCampo.Calories);
        }
        //Test 6: Changing size to Large should change to price for  Large Pan De Campo
        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForPanDeCampoPrice()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Large;
            Assert.Equal<double>(1.99, panDeCampo.Price);
        }

        //Test 7: Changing Size to Large should change to calories for Large Pan De Campo


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeBakedBeanCalorie()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Large;
            Assert.Equal<double>(367, panDeCampo.Calories);
        }

        //Test 14: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {

            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, panDeCampo.Size);
        }

        //Test 15: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, panDeCampo.Size);
        }

        //Test 16: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var panDeCampo = new PanDeCampo();
            panDeCampo.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, panDeCampo.Size);
        }

    }
}
