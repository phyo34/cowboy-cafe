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
        //Test 1: Chili Cheese Fries should implement the INotifyPropertyChangedInterface
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chiliCheeseFries);
        }


        //Test 2: Changing size to Small should change to price for  Small Chili Cheese Fries

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallChiliCheeseFriesPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Small;
            Assert.Equal<double>(1.99, chiliCheeseFries.Price);
        }

        //Test 3: Changing size to Small should change to calories for Small Chili Cheese Fries


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallChiliCheeseFriesCalorie()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Small;
            Assert.Equal<double>(433, chiliCheeseFries.Calories);
        }

        //Test 4: Changing size to Medium should change to price for  Medium Chili Cheese Fries

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumChiliCheeseFriesPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Medium;
            Assert.Equal<double>(2.99, chiliCheeseFries.Price);
        }

        //Test 5: Changing size to Medium should change to calories for Medium Chili Cheese Fries


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumChiliCheeseFriesCalorie()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Medium;
            Assert.Equal<double>(524, chiliCheeseFries.Calories);
        }
        //Test 6: Changing size to Large should change to price for  Large Chili Cheese Fries

        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForChiliCheeseFriesPrice()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Large;
            Assert.Equal<double>(3.99, chiliCheeseFries.Price);
        }

        //Test 7: Changing Size to Large should change to calories for Large Chili Cheese Fries


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeBakedBeanCalorie()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Large;
            Assert.Equal<double>(610, chiliCheeseFries.Calories);
        }

        //Test 14: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, chiliCheeseFries.Size);
        }

        //Test 15: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, chiliCheeseFries.Size);
        }

        //Test 16: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var chiliCheeseFries = new ChiliCheeseFries();
            chiliCheeseFries.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, chiliCheeseFries.Size);
        }

    }
}
