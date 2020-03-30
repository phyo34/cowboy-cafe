/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Cowboy Coffee
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
    public class CowboyCoffeePropertyChangedTests
    {
        //Test 1: CowboyCoffee should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CowboyCoffeenShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () => {
               coffee.Ice = false;
            });

        }

        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Ice = false;
            });

        }

        //Test 4: Changing the "Decaf" property should invoke PropertyChanged for "Decaf"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () => {
                coffee.Decaf = false;
            });

        }

        //Test 5: Changing the "Decaf" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.Decaf = false;
            });

        }

        //Test 6: Changing the "RoomForCream" property should invoke PropertyChanged for "RoomForCream"
        [Fact]
        public void ChangingRoomforCreamShouldInvokePropertyChangedForRoomforCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () => {
                coffee.RoomForCream= false;
            });

        }

        //Test 7: Changing the "RoomForCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => {
                coffee.RoomForCream = false;
            });

        }

        //Test 8: Changing size to Small should change to price for Small  Cowboy Coffee

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallPrice()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Small;
            Assert.Equal<double>(0.60, coffee.Price);
        }

        //Test 9: Changing size to Small should change to calories for Small Cowboy Coffee


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallCalorie()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Small;
            Assert.Equal<double>(3, coffee.Calories);
        }

        //Test 10: Changing size to Medium should change to price for Medium  Cowboy Coffee

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumPrice()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(1.10, coffee.Price);
        }

        //Test 11: Changing size to MEdium should change to calories for Medium Cowboy Coffee


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumCalorie()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(5, coffee.Calories);
        }

        //Test 12: Changing size to Large should change to price for Large Cowboy Coffee 

        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargePrice()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.60, coffee.Price);
        }

        //Test 13: Changing size to Large should change to calories for Large Cowboy Coffee


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeCalorie()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Large;
            Assert.Equal<double>(7, coffee.Calories);
        }


    }
}
