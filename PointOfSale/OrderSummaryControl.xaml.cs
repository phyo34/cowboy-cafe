/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: This class repsents the customization for the order summary control
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl

    {

        /// <summary>
        /// Private ordercontro
        /// </summary>
        private OrderControl order;


        public OrderSummaryControl()
        {
            InitializeComponent();
       

        }

        /// <summary>
        /// Handles manual selection of items in the list.
        /// </summary>
        /// <param name="sender">SelectionChanged</param>
        /// <param name="args">the args</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem OrderItem)
                {
                    if (OrderItem is AngryChicken chicken)
                    {                       
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = chicken;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CowpokeChili chili)
                    {
                        var screen = new CustomizeCowPokeChili();
                        screen.DataContext = chili;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is PecosPulledPork pork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pork;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TrailBurger trailBurger)
                    {
                        var screen = new CustomizeTrailBurger();
                        screen.DataContext = trailBurger;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is DakotaDoubleBurger dakotaDouble)
                    {
                        var screen = new CustomizeDakotaDouble();
                        screen.DataContext = dakotaDouble;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TexasTripleBurger texasTriple)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = texasTriple;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is ChiliCheeseFries chiliCheeseFries)
                    {
                        var screen = new CustomizeChiliCheeseFries();
                        screen.DataContext = chiliCheeseFries;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CornDodgers cornDodgers)
                    {
                        var screen = new CustomizeCornDodgers();
                        screen.DataContext = cornDodgers;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is PanDeCampo panDeCampo)
                    {
                        var screen = new CustomizePanDeCampo();
                        screen.DataContext = panDeCampo;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is BakedBeans bakedBeans)
                    {
                        var screen = new CustomizeBakedBeans();
                        screen.DataContext = bakedBeans;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is JerkedSoda jerkedSoda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = jerkedSoda;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TexasTea texasTea)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = texasTea;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CowboyCoffee coffee)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = coffee;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is Water water)
                    {
                        var screen = new CustomizeWater();
                        screen.DataContext = water;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                }
               
            }
           

        }

        /// <summary>
        /// Removes an item from the list.
        /// </summary>
        /// <param name="sender">click event</param>
        /// <param name="args">the args</param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }


    }
}
