/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in the Dakota Double Burger
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
    public class DakotaDoublePropertyChangedTests
    {
        //Test 1: Dakota Double should implement the INotifyPropertyChangedInterface
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakotaDouble);
        }


        //Test 2: Changing the "Ketchup" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChnagedForKetchup()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Ketchup", () => {
                dakotaDouble.Ketchup = false;
            });

        }

        //Test 3: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Ketchup = false;
            });


        }
        //Test 4: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Mustard", () => {
                dakotaDouble.Mustard = false;
            });


        }

        //Test 5: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Mustard = false;
            });



        }

        //Test 6: Changing the "Pickle" property should invoke PropertyChanged for "Green Onions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            
                var dakotaDouble = new DakotaDoubleBurger();
                Assert.PropertyChanged(dakotaDouble, "Pickle", () => {
                    dakotaDouble.Pickle = false;
                });



        }

        //Test 7: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Pickle = false;
            });


        }
        //Test 8: Changing the "Cheese" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Cheese", () => {
                dakotaDouble.Cheese = false;
            });

        }

        //Test 9: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Cheese = false;
            });

        }

        //Test 10: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Bun", () => {
                dakotaDouble.Bun = false;
            });

        }

        //Test 11: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Bun = false;
            });
        }

        //Test 12: Changing the "Tomato" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Tomato", () => {
                dakotaDouble.Tomato = false;
            });

        }

        //Test 13: Changing the "Tomato" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Tomato = false;
            });


        }

        //Test 14: Changing the "Lettuce" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Lettuce", () => {
                dakotaDouble.Lettuce = false;
            });

        }

        //Test 15: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Lettuce = false;
            });

        }

        //Test 16: Changing the "Mayo" property should invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "Mayo", () => {
                dakotaDouble.Mayo = false;
            });

        }

        //Test 17: Changing the "Mayo" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakotaDouble = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakotaDouble, "SpecialInstructions", () => {
                dakotaDouble.Mayo = false;
            });

        }

    }
}
