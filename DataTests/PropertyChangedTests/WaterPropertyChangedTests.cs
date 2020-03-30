/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Water
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        //Test 1:Water should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CowboyCoffeenShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });

        }

        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water,"SpecialInstructions", () =>
            {
                water.Ice = false;
            });

        }
        //Test 4: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = false;
            });

        }

        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = false;
            });

        }


        //Test 6: Changing size to Small should change to price for  Small Water

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallWaterPrice()
        {
            var water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0.12, water.Price);
        }

        //Test 7: Changing size to Small should change to calories for Small Water


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallSmallWaterCalorie()
        {
            var water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(0, water.Calories);
        }

        //Test 8: Changing size to Medium should change to price for  Medium Water

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumMediumWaterPrice()
        {
            var water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.12, water.Price);
        }

        //Test 9: Changing size to Medium should change to calories for Medium Water


        [Fact]
        public void ChangingMediumizeShouldInvokePropertyChangedoForMediumWaterCalorie()
        {
            var water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0, water.Calories);
        }
    
        //Test 10: Changing size to Large should change to price for  Large Water

        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeWaterPrice()
        {
            var water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.12, water.Price);
        }

        //Test 11: Changing Size to Large should change to calories for Large Water


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeWaterCalorie()
        {
            var water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0, water.Calories);
        }

        //Test 12: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {
            var water = new Water();
            water.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        //Test 13: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var water = new Water();
            water.Size = Size.Medium;

            Assert.Equal<Size>(Size.Medium, water.Size);
        }

        //Test 14: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var water = new Water();
            water.Size = Size.Large;

            Assert.Equal<Size>(Size.Large, water.Size);
        }





    }
}
