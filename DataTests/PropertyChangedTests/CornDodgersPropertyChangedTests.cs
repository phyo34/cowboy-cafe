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
        //Test 1: Corn Dodgers should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var cornDodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cornDodgers);
        }


        //Test 2: Changing size to Small should change to price for  Small Corn Dodgers

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallCornDodgersrice()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Small;
            Assert.Equal<double>(1.59, cornDodgers.Price);
        }

        //Test 3: Changing size to Small should change to calories for Small Corn Dodgers


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallCornDodgersCalorie()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Small;
            Assert.Equal<double>(512, cornDodgers.Calories);
        }

        //Test 4: Changing size to Medium should change to price for  Medium Corn Dodgers

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumCornDodgersPrice()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Medium;
            Assert.Equal<double>(1.79, cornDodgers.Price);
        }

        //Test 5: Changing size to Medium should change to calories for Medium Corn Dodgers


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumCornDodgersCalorie()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Medium;
            Assert.Equal<double>(685, cornDodgers.Calories);
        }
        //Test 6: Changing size to Large should change to price for  Large Corn Dodgers
        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForCornDodgersPrice()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Large;
            Assert.Equal<double>(1.99, cornDodgers.Price);
        }

        //Test 7: Changing Size to Large should change to calories for Large Corn Dodgers


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeCornDodgersCalorie()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Large;
            Assert.Equal<double>(717, cornDodgers.Calories);
        }

        //Test 14: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {

            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, cornDodgers.Size);
        }

        //Test 15: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, cornDodgers.Size);
        }

        //Test 16: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var cornDodgers = new CornDodgers();
            cornDodgers.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, cornDodgers.Size);
        }

    }
}
