/* Author: May Phyo
 * Class: Menu.cs 
 * Description: Allows the website to acess the menu*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
     

        /// <summary>
        /// list of all entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {

            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;
        }

        /// <summary>
        /// List of all sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            sides.Add(new BakedBeans());
            var mediumbb = new BakedBeans();
            mediumbb.Size = Size.Medium;
            sides.Add(mediumbb);
            var largebb = new BakedBeans();
            largebb.Size = Size.Large;
            sides.Add(largebb);


            sides.Add(new ChiliCheeseFries());
            var mediumchili = new ChiliCheeseFries();
            mediumchili.Size = Size.Medium;
            sides.Add(mediumchili);
            var largechili = new ChiliCheeseFries();
            largechili.Size = Size.Large;
            sides.Add(largechili);

            sides.Add(new CornDodgers());
            var mediumcorn = new CornDodgers();
            mediumcorn.Size = Size.Medium;
            sides.Add(mediumcorn);
            var largecorn = new CornDodgers();
            largecorn.Size = Size.Large;
            sides.Add(largecorn);

            sides.Add(new PanDeCampo());
            var mediumpan = new PanDeCampo();
            mediumpan.Size = Size.Medium;
            sides.Add(mediumpan);
            var largepan = new PanDeCampo();
            largepan.Size = Size.Large;
            sides.Add(largepan);

            return sides;

        }

        /// <summary>
        /// List of all drinks 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(new CowboyCoffee());
            var mediumcoffee = new CowboyCoffee();
            mediumcoffee.Size = Size.Medium;
            drinks.Add(mediumcoffee);
            var largecoffee= new CowboyCoffee();
            largecoffee.Size = Size.Large;
            drinks.Add(largecoffee);

            drinks.Add(new JerkedSoda());
            var mediumSoda = new JerkedSoda();
            mediumSoda.Size = Size.Medium;
            drinks.Add(mediumSoda);
            var largeSoda = new JerkedSoda();
            largeSoda.Size = Size.Large;
            drinks.Add(largeSoda);

            drinks.Add(new TexasTea());
            var mediumTea = new TexasTea();
            mediumTea.Size = Size.Medium;
            drinks.Add(mediumTea);
            var largeTea = new TexasTea();
            largeTea.Size = Size.Large;
            drinks.Add(largeTea);

            drinks.Add(new Water());
            var mediumWater = new Water();
            mediumWater.Size = Size.Medium;
            drinks.Add(mediumWater);
            var largeWater = new Water();
            largeWater.Size = Size.Large;
            drinks.Add(largeWater);

            return drinks;
        }

        /// <summary>
        /// Lists th menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> MenuOrder()
        {

            List<IOrderItem> items = new List<IOrderItem>();

            foreach (IOrderItem entree in Entrees())
            {
                items.Add(entree);
            }

            foreach (IOrderItem side in Sides())
            {
                items.Add(side);
            }

            foreach (IOrderItem drink in Drinks())
            {
                items.Add(drink);
            }

            return items;

        }





        /// <summary>
        /// Searches through list for the terms 
        /// </summary>
        /// <param name="terms">Terms to search for </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            if (terms == null) return items;

            return items.Where(item => item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Filters list by category
        /// </summary>
        /// <param name="items">Items to filter out</param>
        /// <param name="menuCategories">Categories to filter by</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] menuCategories)
        {
            if (menuCategories == null || menuCategories.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            IEnumerable<IOrderItem> itemCheck = null;
            foreach (string menuCategory in menuCategories)
            {
                switch (menuCategory)
                {
                    case "Entree":
                        itemCheck = items.Where(item => item is Entree);
                        break;
                    case "Side":
                        itemCheck = items.Where(item => item is Side);
                        break;
                    case "Drink":
                        foreach (IOrderItem item in items)
                            itemCheck = items.Where(item => item is Drink);
                        break;
                    default:
                        return items;
                }
                foreach (IOrderItem item in itemCheck)
                {
                    result.Add(item);
                }
            }
            return result;

        }
        /// <summary>
        /// Filters by a minimum and maximum calorie 
        /// </summary>
        /// <param name="items">Items to filter</param>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (min == null) min = 0;
            if (max == null) max = 1000;
            return items.Where(item => item.Price >= min && item.Price <= max);
        }


        /// <summary>
        /// Filter by Price
        /// </summary>
        /// <param name="items">IEnumerable of items</param>
        /// <param name="min">Minimum Price</param>
        /// <param name="max">Maximum Price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
        //    if (min == null & max == null) return items;

        //    if (items == null) return null;

        //    var results = new List<IOrderItem>();

        //    if (min == null)
        //    {
        //        foreach (IOrderItem item in items)
        //        {
        //            if (item.Price <= max) results.Add(item);
        //        }

        //        return results;
        //    }

        //    if (max == null)
        //    {
        //        foreach (IOrderItem item in items)
        //        {
        //            if (item.Price >= min) results.Add(item);
        //        }

        //        return results;
        //    }

        //    foreach (IOrderItem item in items)
        //    {
        //        if (item.Price >= min & item.Price <= max)
        //        {
        //            results.Add(item);
        //        }
        //    }

        //    return results;

            if (min == null && max == null) return items;
            if (max == null) max = 1000;
            if (min == null) min = 0;
            return items.Where(item => item.Calories >= min && item.Calories <= max);
        }
    }
}