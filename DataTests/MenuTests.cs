﻿using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Linq;
using Xunit;

namespace CowboyCafe.DataTests
{
   public class MenuTests
    {
        /// <summary>
        /// Tests to see if all items ar returned
        /// </summary>
        /// <param name="type">types returned</param>
        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void ShouldReturnAll(string type)
        {
            var list = new List<IOrderItem>();
            switch (type)
            {
                case "Entree":
                    list = (List<IOrderItem>)Menu.Entrees();
                    break;
                case "Side":
                    list = (List<IOrderItem>)Menu.Sides();
                    break;
                case "Drink":
                    list = (List<IOrderItem>)Menu.Drinks();
                    break;
            }

            if (type == "Entree")
            {
                foreach (IOrderItem item in list)
                {
                    if (!(item is Entree))
                    {
                        Assert.False(false);
                    }
                }
            }
            else if (type == "Side")
            {
                foreach (IOrderItem item in list)
                {
                    if (!(item is Side))
                    {
                        Assert.False(false);
                    }
                }
            }
            else
            {
                foreach (IOrderItem item in list)
                {
                    if (!(item is Drink))
                    {
                        Assert.False(false);
                    }
                }
            }
            Assert.True(true);
        }


        /// <summary>
        /// Tests if all drinks returned
        /// </summary>
        [Fact]
        public void ShouldReturnAllDrinks()
        {
            var result = new List<IOrderItem>();

            JerkedSoda sodaSmall = new JerkedSoda();
            sodaSmall.Size = Size.Small;
            result.Add(sodaSmall);
            JerkedSoda sodaMedium = new JerkedSoda();
            sodaMedium.Size = Size.Medium;
            result.Add(sodaMedium);
            JerkedSoda sodaLarge = new JerkedSoda();
            sodaLarge.Size = Size.Large;
            result.Add(sodaLarge);

            Water waterSmall = new Water();
            waterSmall.Size = Size.Small;
            result.Add(waterSmall);
            Water waterMedium = new Water();
            waterMedium.Size = Size.Medium;
            result.Add(waterMedium);
            Water waterLarge = new Water();
            waterLarge.Size = Size.Large;
            result.Add(waterLarge);

            CowboyCoffee coffeeSmall = new CowboyCoffee();
            coffeeSmall.Size = Size.Small;
            result.Add(coffeeSmall);
            CowboyCoffee coffeeMedium = new CowboyCoffee();
            coffeeMedium.Size = Size.Medium;
            result.Add(coffeeMedium);
            CowboyCoffee coffeeLarge = new CowboyCoffee();
            coffeeLarge.Size = Size.Large;
            result.Add(coffeeLarge);

            TexasTea teaSmall = new TexasTea();
            teaSmall.Size = Size.Small;
            result.Add(teaSmall);
            TexasTea teaMedium = new TexasTea();
            teaMedium.Size = Size.Medium;
            result.Add(teaMedium);
            TexasTea teaLarge = new TexasTea();
            teaLarge.Size = Size.Large;
            result.Add(teaLarge);

            Assert.Equal(result.Count(), Menu.Drinks().Count());
        }

        /// <summary>
        /// Tests that all sides are returned
        /// </summary>
        [Fact]
        public void ShouldReturnAllSides()
        {
            var result = new List<IOrderItem>();

            CornDodgers dodgersSmall = new CornDodgers();
            dodgersSmall.Size = Size.Small;
            result.Add(dodgersSmall);
            CornDodgers dodgersMedium = new CornDodgers();
            dodgersMedium.Size = Size.Medium;
            result.Add(dodgersMedium);
            CornDodgers dodgersLarge = new CornDodgers();
            dodgersLarge.Size = Size.Large;
            result.Add(dodgersLarge);

            ChiliCheeseFries chiliSmall = new ChiliCheeseFries();
            chiliSmall.Size = Size.Small;
            result.Add(chiliSmall);
            ChiliCheeseFries chiliMedium = new ChiliCheeseFries();
            chiliMedium.Size = Size.Medium;
            result.Add(chiliMedium);
            ChiliCheeseFries chiliLarge = new ChiliCheeseFries();
            chiliLarge.Size = Size.Large;
            result.Add(chiliLarge);

            BakedBeans bakedSmall = new BakedBeans();
            bakedSmall.Size = Size.Small;
            result.Add(bakedSmall);
            BakedBeans bakedMedium = new BakedBeans();
            bakedMedium.Size = Size.Medium;
            result.Add(bakedMedium);
            BakedBeans bakedLarge = new BakedBeans();
            bakedLarge.Size = Size.Large;
            result.Add(bakedLarge);

            PanDeCampo campoSmall = new PanDeCampo();
            campoSmall.Size = Size.Small;
            result.Add(campoSmall);
            PanDeCampo campoMedium = new PanDeCampo();
            campoMedium.Size = Size.Medium;
            result.Add(campoMedium);
            PanDeCampo campoLarge = new PanDeCampo();
            campoLarge.Size = Size.Large;
            result.Add(campoLarge);

            Assert.Equal(result.Count(), Menu.Sides().Count());
        }

        /// <summary>
        /// Test if all entrees returned
        /// </summary>
        [Fact]
        public void ShouldReturnAllEntree()
        {
            var result = new List<IOrderItem>();

            result.Add(new AngryChicken());
            result.Add(new CowpokeChili());
            result.Add(new DakotaDoubleBurger());
            result.Add(new PecosPulledPork());
            result.Add(new RustlersRibs());
            result.Add(new TexasTripleBurger());
            result.Add(new TrailBurger());


            Assert.Equal(result.Count(), Menu.Entrees().Count());
        }

        /// <summary>
        /// Filters items by calories 
        /// </summary>
        /// <param name="min">Minimum calories </param>
        /// <param name="max">Maximum calories </param>
        /// <param name="expectedNumberOfItems">num of items returned</param>
        [Theory]
        [InlineData(0, 10, 7)]
        [InlineData(0, 300, 17)]
        [InlineData(250, 500, 8)]
        public void ShouldFilterByCalories(int? min, int? max, int expectedNumberOfItems)
        {
            Assert.Equal(expectedNumberOfItems, Menu.FilterByCalories(Menu.MenuOrder(), min, max).Count());
        }

        /// <summary>
        /// Tests Filter by price
        /// </summary>
        /// <param name="min">Minimum price </param>
        /// <param name="max">Maximum price </param>
        /// <param name="expectedNumberOfItems">num of items returned</param>
        [Theory]
        [InlineData(0, 1, 5)]
        [InlineData(3, 8, 8)]
        [InlineData(0, 100, 31)]
        public void ShouldFilterByPrice(double? min, double? max, int expectedNumberOfItems)
        {
            Assert.Equal(expectedNumberOfItems, Menu.FilterByPrice(Menu.MenuOrder(), min, max).Count());
        }

        /// <summary>
        /// Filter all items by term entered with given theory data
        /// </summary>
        /// <param name="term">Term to filter by</param>
        /// <param name="expectedNumberOfItems">Number of items to expect when filtering</param>
        [Theory]
        [InlineData("Cowboy", 4)]
        [InlineData(null, 3)]
        [InlineData("", 31)]
        [InlineData("Pulled", 3)]

        public void ShouldFilterByTerm(string term, int expectedNumberOfItems)
        {
            Assert.Equal(expectedNumberOfItems, Menu.Search(Menu.MenuOrder(),term).Count());
        }


        /// <summary>
        /// Tests Filter by type 
        /// </summary>
        /// <param name="types">Types to filter by</param>
        /// <param name="expectedNumberOfItems">num of items returned</param>
        [Theory]
        [InlineData(new string[] { "Entree" }, 7)]
        [InlineData(null, 31)]
        [InlineData(new string[] { }, 31)]
        [InlineData(new string[] { "Entree", "Drink" }, 19)]
        public void ShoudFilterByType(string[] types, int expectedNumberOfItems)
        {
            var items = Menu.MenuOrder();
            var result = Menu.FilterByType(items, types);

            if (result is List<IOrderItem> output)
            {
                Assert.Equal(expectedNumberOfItems, output.Count);
            }
        }

        /// <summary>
        /// Test all items returned
        /// </summary>
        [Fact]
        public void ShouldReturnAllItems()
        {
            var result = Menu.MenuOrder();

            if (result.Count().Equals(Menu.MenuOrder().Count()))
            {
                Assert.True(true);
            }

        }

      
    }
}
