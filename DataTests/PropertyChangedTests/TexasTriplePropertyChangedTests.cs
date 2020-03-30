/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in the Texas Triple 
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
    public class TexasTriplePropertyChangedTests
    {
        //Test 1: Texas Triple should implement the INotifyPropertyChangedInterface
        [Fact]
        public void TexasTripleShouldImplementINotifyPropertyChanged()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasTriple);
        }


        //Test 2: Changing the "Ketchup" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChnagedForKetchup()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Ketchup", () =>
            {
                texasTriple.Ketchup = false;
            });

        }

        //Test 3: Changing the "Ketchup" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Ketchup = false;
            });

        }
        //Test 4: Changing the "Mustard" property should invoke PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Mustard", () =>
            {
                texasTriple.Mustard = false;
            });


        }

        //Test 5: Changing the "Mustard" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Mustard = false;
            });


        }

        //Test 6: Changing the "Pickle" property should invoke PropertyChanged for "Green Onions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {

            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Pickle", () =>
            {
                texasTriple.Pickle = false;
            });



        }

        //Test 7: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Pickle = false;
            });


        }
        //Test 8: Changing the "Cheese" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Cheese", () =>
            {
                texasTriple.Cheese = false;
            });

        }

        //Test 9: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Cheese = false;
            });

        }

        //Test 10: Changing the "Bun" property should invoke PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Bun", () =>
            {
                texasTriple.Bun = false;
            });

        }

        //Test 11: Changing the "Bun" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Bun = false;
            });
        }

        //Test 12: Changing the "Tomato" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Tomato", () =>
            {
                texasTriple.Tomato = false;
            });

        }

        //Test 13: Changing the "Tomato" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Tomato = false;
            });


        }

        //Test 14: Changing the "Lettuce" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Lettuce", () =>
            {
                texasTriple.Lettuce = false;
            });

        }

        //Test 15: Changing the "Lettuce" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Lettuce = true;
            });

        }

        //Test 16: Changing the "Mayo" property should invoke PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Mayo", () =>
            {
                texasTriple.Mayo = false;
            });

        }

        //Test 17: Changing the "Mayo" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Mayo = false;
            });

        }
        //Test 18: Changing the "Bacon" property should invoke PropertyChanged for "Bacon"

        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Bacon", () =>
            {
                texasTriple.Bacon = false;
            });

        }

        //Test 19: Changing the "Bacon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Bacon = false;
            });

        }

        //Test 20: Changing the "Egg" property should invoke PropertyChanged for "Egg"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "Egg", () =>
            {
                texasTriple.Egg = false;
            });

        }

        //Test 21: Changing the "Egg" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasTriple = new TexasTripleBurger();
            Assert.PropertyChanged(texasTriple, "SpecialInstructions", () =>
            {
                texasTriple.Egg = false;
            });


        }
    }
}
