/***
 * Author: May Phyo
 * Class: CIS 400
 * Purpose: The purpose of this class is to test the property changed in Baked Beans
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
    public class BakedBeansPropertyChangedTests
    {

        //Test 1: Baked Bean should implement the INotifyPropertyChangedInterface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }


        //Test 2: Changing size to Small should change to price for  Small Baked Beans

        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallBakedBeanPrice()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Small;
            Assert.Equal<double>(1.59, beans.Price);
        }

        //Test 3: Changing size to Small should change to calories for Small Baked Beans


        [Fact]
        public void ChangingSmallSizeShouldInvokePropertyChangedoForSmallBakedBeanCalorie()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Small;
            Assert.Equal<double>(312, beans.Calories);
        }

        //Test 4: Changing size to Medium should change to price for  Medium Baked Beans

        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumBakedBeansPrice()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Medium;
            Assert.Equal<double>(1.79, beans.Price);
        }

        //Test 5: Changing size to Medium should change to calories for Medium Baked Beans


        [Fact]
        public void ChangingMediumSizeShouldInvokePropertyChangedoForMediumBakedBeansCalorie()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Medium;
            Assert.Equal<double>(378, beans.Calories);
        }
        //Test 6: Changing size to Large should change to price for  Large Baked Beans

        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeBakedBeansPrice()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Large;
            Assert.Equal<double>(1.99, beans.Price);
        }

        //Test 7: Changing Size to Large should change to calories for Large Baked Beans


        [Fact]
        public void ChangingLargeSizeShouldInvokePropertyChangedoForLargeBakedBeanCalorie()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Large;
            Assert.Equal<double>(410, beans.Calories);
        }

        //Test 14: Changing Size to Small should change Size to Small
        [Fact]
        public void ChangingSizetoSmallShouldInvokePropertyChangeForSmallSize()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, beans.Size);
        }

        //Test 15: Changing Size to Medium should change Size to Medium
        [Fact]
        public void ChangingSizetoMediumShouldInvokePropertyChangeForMediumSize()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, beans.Size);
        }

        //Test 16: Changing Size to Large should change Size to Large
        [Fact]
        public void ChangingSizetoLargeShouldInvokePropertyChangeForLargeSize()
        {
            var beans = new BakedBeans();
            beans.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, beans.Size);
        }

    }
}
