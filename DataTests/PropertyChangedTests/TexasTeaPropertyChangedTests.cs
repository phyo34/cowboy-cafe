/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Texas Tea
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
   public class TexasTeaPropertyChangedTests
    {
        //Test 1:Texas Tea should implement the INotifyPropertyChangedInterface
        [Fact]
        public void CowboyCoffeenShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () => {
                tea.Ice = true;
            });

        }

        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => {
                tea.Ice = true;
            });

        }
        //Test 4: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () => {
                tea.Lemon = false;
            });

        }

        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => {
                tea.Lemon = true;
            });

        }

        //Test 4: Changing the "Sweet" property should invoke PropertyChanged for "Sweet"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () => {
                tea.Sweet = true;
            });

        }

        //Test 5: Changing size to Small should change to price for  Small Sweet Tea

        [Fact]
        public void ChangingSmallSweetTeaSizeShouldInvokePropertyChangedoForSmallSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            Assert.Equal<double>(1.00, tea.Price);
        }

        //Test 6: Changing size to Small should change to calories for Small Sweet Tea


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            Assert.Equal<double>(10, tea.Calories);
        }

        //Test 5: Changing size to Medium should change to price for  Medium Sweet Tea

        [Fact]
        public void ChangingMediumSweetTeaSizeShouldInvokePropertyChangedoForMediumSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.50, tea.Price);
        }

        //Test 6: Changing size to Medium should change to calories for Medium Sweet Tea


        [Fact]
        public void ChangingMediumSweetTeaizeShouldInvokePropertyChangedoForMediumSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(22, tea.Calories);
        }
        //Test 5: Changing size to Large should change to price for  Large Sweet Tea

        [Fact]
        public void ChangingLargeSweetTeaSizeShouldInvokePropertyChangedoForLargeSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(2.00, tea.Price);
        }

        //Test 6: Changing Size to Large should change to calories for Large Sweet Tea


        [Fact]
        public void ChangingLargeSweetTeaizeShouldInvokePropertyChangedoForLargeSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(36, tea.Calories);
        }



    }
}
