/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Pecod Pulled Pork 
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
    public class PecosPulledPorkPropertyChangedTests
    {
        //Test 1: Pecos Pulled Pork should implement the INotifyPropertyChangedInterface
        [Fact]
        public void PecodPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pecos = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecos);
        }

        //Test 2: Changing the "Bread" property should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "Bread", () => {
                pecos.Bread = false;
            });

        }

        //Test 3: Changing the "Bread" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "SpecialInstructions", () => {
                pecos.Bread = false;
            });

        }
        //Test 4: Changing the "Pickle" property should invoke PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "Pickle", () => {
                pecos.Pickle = false;
            });
        }

        //Test 5: Changing the "Pickle" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "SpecialInstructions", () => {
                pecos.Pickle = false;
            });

        }
    }
}
