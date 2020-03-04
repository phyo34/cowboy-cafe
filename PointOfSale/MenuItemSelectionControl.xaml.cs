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
        /// Button representing click event for cowpoke chili
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// Button representing click event for Rustler's Rib
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddRustlersRibButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            data.Add(new RustlersRibs());
        }

        /// <summary>
        /// Button representing click event for the Pecos Pulled Pork
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            data.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Button representing click event for the Trail Burger 
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            data.Add(new TrailBurger());
        }

        /// <summary>
        /// Button representing click event for the Dakota Double
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddDakotaDoubleClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            data.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Button representing click event for the Texas Triple Burger
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
           data.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Button representing click event for the Angry Chicken 
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event</param>
        void OnAddAngryChickenClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data )
            data.Add(new AngryChicken());
        }

        /// <summary>
        /// Button representing click event for Water
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddWaterClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
           data.Add(new Water());
        }

        /// <summary>
        /// Button representing click event for the Jerked Soda
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
           data.Add(new JerkedSoda());
        }

        /// <summary>
        /// Button representing click event for Cowboy Coffee
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            data.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Button representing click event for the Texas Tea
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddTexasTeaClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            data.Add(new TexasTea());
        }

        /// <summary>
        /// Button representing click event for the Chili Cheese Fries
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            data.Add(new ChiliCheeseFries());
        }


        /// <summary>
        /// Button representing click event for the Corn Dodgers
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddCornDodgersClicked(object sender, RoutedEventArgs e)
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
            if (DataContext is Order data)
          data.Add(new PanDeCampo());
        }

        /// <summary>
        /// Button representing click event for the Baked Beans
        /// </summary>
        /// <param name="sender">The button sender</param>
        /// <param name="e">The event </param>
        void OnAddBakedBeansClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data )
            data.Add(new BakedBeans());
        }

    }
}
