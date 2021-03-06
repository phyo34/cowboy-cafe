﻿/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Jerked Soda
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
    public class JerkedSodaPropertyChangedTests
    {
        //Test 1: Jerked Soda should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CowboyCoffeenShouldImplementINotifyPropertyChanged()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(jerkedSoda);
        }

        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Ice", () => {
                jerkedSoda.Ice = false;
            });

        }

        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var jerkedSoda = new CowboyCoffee();
            Assert.PropertyChanged(jerkedSoda, "SpecialInstructions", () => {
                jerkedSoda.Ice = false;
            });

        }

        //Test 4: Changing the "Flavor" property should invoke PropertyChanged for flavor
        [Fact]
        public void ShouldBeAbleToSetAllFlavors()
        {
            var soda = new JerkedSoda();
            soda.Flavor = SodaFlavor.BirchBeer;
            Assert.Equal<SodaFlavor>(SodaFlavor.BirchBeer, soda.Flavor);

            soda = new JerkedSoda();
            soda.Flavor = SodaFlavor.CreamSoda;
            Assert.Equal<SodaFlavor>(SodaFlavor.CreamSoda, soda.Flavor);

            soda = new JerkedSoda();
            soda.Flavor = SodaFlavor.OrangeSoda;
            Assert.Equal<SodaFlavor>(SodaFlavor.OrangeSoda, soda.Flavor);

            soda = new JerkedSoda();
            soda.Flavor = SodaFlavor.RootBeer;
            Assert.Equal<SodaFlavor>(SodaFlavor.RootBeer, soda.Flavor);

            soda = new JerkedSoda();
            soda.Flavor = SodaFlavor.Sarsparilla;
            Assert.Equal<SodaFlavor>(SodaFlavor.Sarsparilla, soda.Flavor);

         
        }

        //Test 5: Changing size to Small should change to price for Small  Jerked Soda

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallPrice()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.59, soda.Price);
        }

        //Test 6: Changing size to Small should change to calories for Small Jerked Soda


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallCalorie()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Small;
            Assert.Equal<double>(110, soda.Calories);
        }

        //Test 7: Changing size to Medium should change to price for Medium Jerked Soda

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumPrice()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.10, soda.Price);
        }

        //Test 8: Changing size to Medium should change to calories for Medium Jerked Soda


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumCalorie()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Medium;
            Assert.Equal<double>(146, soda.Calories);
        }

        //Test 9: Changing size to Large should change to price for Medium Jerked Soda

        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargePrice()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.59, soda.Price);
        }

        //Test 10: Changing size to Large should change to calories for Large  Jerked Soda


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeCalorie()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Large;
            Assert.Equal<double>(198, soda.Calories);
        }

        //Test 11: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        //Test 12: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, soda.Size);
        }

        //Test 13: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, soda.Size);
        }


        /// <summary>
        /// Changing size should change price
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokePropertyChangedForPrice()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Price", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

        /// <summary>
        /// Changing size should change calories
        /// </summary>
        [Fact]
        public void ChangingSizePropertyShouldInvokeProperyChangedForCalories()
        {
            var jerkedSoda = new JerkedSoda();
            Assert.PropertyChanged(jerkedSoda, "Calories", () => {
                jerkedSoda.Size = Size.Large;
            });
        }

    }
}
