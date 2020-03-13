/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: Creates the menu selection window
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {


        /// <summary>
        /// Button Click event intialized 
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibButton.Click += OnAddRustlersRibButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerClicked;
            AddDakotaDoubleButton.Click += OnAddDakotaDoubleClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenClicked;

            AddWaterButton.Click += OnAddWaterClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaClicked;

            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersClicked;
            AddPanDeCamposButton.Click += OnAddPanDeCampoClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansClicked;




        }


        /// <summary>
        /// Helper method to display the special instructions
        /// </summary>
        /// <param name="item">The item</param>
        /// <param name="screen">The screen</param>
        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("Data expected to be an Order instance");

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of order exception");
                screen.DataContext = item;
                orderControl.SwapScreen(screen);

            }
            order.Add(item);
        }

        /// <summary>
        /// Button representing click event for cowpoke chili
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowPokeChili();

                AddItemAndOpenCustomizationScreen(entree, screen);
               
            }
        }

        /// <summary>
        /// Button representing click event for Rustler's Rib. Rustler's Rib cannot customize anything.
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddRustlersRibButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            data.Add(new RustlersRibs());

        }

        /// <summary>
        /// Button representing click event for the Pecos Pulled Pork
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        public void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Trail Burger 
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
       public void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Dakota Double
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        public void OnAddDakotaDoubleClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDouble();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Texas Triple Burger
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        public void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTriple();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Angry Chicken 
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        public void OnAddAngryChickenClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for Water
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddWaterClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new Water();
                var screen = new CustomizeWater();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Jerked Soda
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for Cowboy Coffee
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Texas Tea
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTea();
                var screen = new CustomizeTexasTea();

                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Button representing click event for the Chili Cheese Fries
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            data.Add(new ChiliCheeseFries());
        }


        /// <summary>
        /// Button representing click event for the Corn Dodgers
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddCornDodgersClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
           data.Add(new CornDodgers());
        }


        /// <summary>
        /// Button representing click event for the Pan de Campo
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
          data.Add(new PanDeCampo());
        }

        /// <summary>
        /// Button representing click event for the Baked Beans
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        public void OnAddBakedBeansClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data )
            data.Add(new BakedBeans());
        }

        //public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        //{
        //    var orderControl = this.FindAncestor<OrderControl>();
        //    if (DataContext is Order order)
        //    {
        //        if (sender is Button button)
        //        {
        //            switch (button.Tag)
        //            {
        //                case "CowpokeChili":
        //                    order.Add(new CowpokeChili());
        //                    orderControl.SwapScreen(new CustomizeCowPokeChili());
        //                    break;


        //            }
        //        }
        //    }
        //}



    }
}
