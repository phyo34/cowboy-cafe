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
        public void TexasTeaCoffeenShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        //Test 2: Changing the "Ice" property should invoke PropertyChanged for "Ice"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });

        }

        //Test 3: Changing the "Ice" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });

        }
        //Test 4: Changing the "Lemon" property should invoke PropertyChanged for "Lemon"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = false;
            });

        }

        //Test 5: Changing the "Lemon" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = false;
            });

        }

        //Test 6: Changing the "Sweet" property should invoke PropertyChanged for "Sweet"
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });

        }

        //Test 7: Changing size to Small should change to price for  Small Sweet Tea

        [Fact]
        public void ChangingSmallTeaSizeShouldInvokePropertyChangedoForSmallSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            Assert.Equal<double>(1.00, tea.Price);
        }

        //Test 8: Changing size to Small should change to calories for Small Sweet Tea


        [Fact]
        public void ChangingSmallTeaSizeShouldInvokePropertyChangedoForSmallSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            Assert.Equal<double>(10, tea.Calories);
        }

        //Test 9: Changing size to Medium should change to price for  Medium Sweet Tea

        [Fact]
        public void ChangingMediumTeaSizeShouldInvokePropertyChangedoForMediumSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.50, tea.Price);
        }

        //Test 10: Changing size to Medium should change to calories for Medium Sweet Tea


        [Fact]
        public void ChangingMediumTeaizeShouldInvokePropertyChangedoForMediumSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(22, tea.Calories);
        }
        //Test 11: Changing size to Large should change to price for  Large Sweet Tea

        [Fact]
        public void ChangingLargeTeaSizeShouldInvokePropertyChangedoForLargeSweetTeaPrice()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(2.00, tea.Price);
        }

        //Test 12: Changing Size to Large should change to calories for Large Sweet Tea


        [Fact]
        public void ChangingLargeTeaizeShouldInvokePropertyChangedoForLargeSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal<double>(36, tea.Calories);
        }


        //Test 13: Changing Size to Small should change to calories for Large UnSweet Tea


        [Fact]
        public void ChangingSmallTeaizeShouldInvokePropertyChangedoForSmallUnSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            tea.Sweet = false;
            Assert.Equal<double>(5, tea.Calories);
        }



        //Test 14: Changing Size to Medium should change to calories for Large UnSweet Tea


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumUnSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            tea.Sweet = false;
            Assert.Equal<double>(11, tea.Calories);
        }


        //Test 15: Changing Size to Large should change to calories for Large Sweet Tea


        [Fact]
        public void ChangingLargeSweetTeaizeShouldInvokePropertyChangedoForLargeUnSweetTeaCalorie()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            tea.Sweet = false;
            Assert.Equal<double>(18, tea.Calories);
        }



        //Test 16: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {
            var tea = new TexasTea();
            tea.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        //Test 17: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var tea = new TexasTea();
            tea.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, tea.Size);
        }

        //Test 18: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var tea = new TexasTea();
            tea.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tea.Size);
        }

    }

}
    

