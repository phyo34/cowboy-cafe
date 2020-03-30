/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in the Trail Burger 
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
    public class TrailBurgerPropertyChangedTests
    {
        //Test 1: Texas Triple should implement the INotifyPropertyChangedInterface
        [Fact]
        public void TripleBurgerhouldImplementINotifyPropertyChanged()
        {
            var tripleBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tripleBurger);
        }


        //Test 2: Changing the "Ketchup" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChnagedForKetchup()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "Ketchup", () =>
            {
                tripleBurger.Ketchup = false;
            });

        }

        //Test 3: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "SpecialInstructions", () =>
            {
                tripleBurger.Ketchup = false;
            });

        }
        //Test 4: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "Mustard", () =>
            {
                tripleBurger.Mustard = false;
            });



        }

        //Test 5: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "SpecialInstructions", () =>
            {
                tripleBurger.Mustard = false;
            });


        }

        //Test 6: Changing the "Pickle" property should invoke PropertyChanged for "Green Onions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {

            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "Pickle", () =>
            {
                tripleBurger.Pickle = false;
            });
        }

        //Test 7: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "SpecialInstructions", () =>
            {
                tripleBurger.Pickle = false;
            });
        }
        //Test 8: Changing the "Cheese" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "Cheese", () =>
            {
                tripleBurger.Cheese = false;
            });

        }

        //Test 9: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "SpecialInstructions", () =>
            {
                tripleBurger.Cheese = false;
            });

        }

        //Test 10: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "Bun", () =>
            {
                tripleBurger.Bun = false;
            });

        }

        //Test 11: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tripleBurger = new TrailBurger();
            Assert.PropertyChanged(tripleBurger, "SpecialInstructions", () =>
            {
                tripleBurger.Bun = false;
            });
        }

      
    }
}
