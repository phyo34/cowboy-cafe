/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Cowpoke Chili
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
    public class CowpokeChiliPropertyChangedTests
    {

        //Test 1: CowpokeChili should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cowpokeChili);
        }


        //Test 2: Changing the "Cheese" property should invoke PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChnagedForCheese()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "Cheese", () => {
                cowpokeChili.Cheese = false;
            });

        }

        //Test 3: Changing the "Cheese" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.Cheese = false;
            });


        }
        //Test 4: Changing the "SourCream" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SourCream", () => {
                cowpokeChili.SourCream = false;
            });

        }

        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.SourCream = false;
            });


        }

        //Test 4: Changing the "GreenOnions" property should invoke PropertyChanged for "Green Onions"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnios()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "GreenOnions", () => {
                cowpokeChili.GreenOnions = false;
            });

        }

        //Test 5: Changing the "GreenOnions" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.GreenOnions = false;
            });


        }
        //Test 4: Changing the "TortillaStrips" property should invoke PropertyChanged for "SourCream"
        [Fact]
        public void ChangingTortillaStripseShouldInvokePropertyChangedForTortillaStrips()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "TortillaStrips", () => {
                cowpokeChili.TortillaStrips = false;
            });

        }

        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cowpokeChili = new CowpokeChili();
            Assert.PropertyChanged(cowpokeChili, "SpecialInstructions", () => {
                cowpokeChili.TortillaStrips = false;
            });

        }

    }
}
