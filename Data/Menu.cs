/* Author: May Phyo
 * Class: Menu.cs 
 * Description: Allows the website to acess the menu*/
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}