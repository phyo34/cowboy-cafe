/*
* Author: May Phyo
* Class: CIS 400 A
* Purpose: This class repsents the order control
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


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl () {
            InitializeComponent();
          
            DataContext = new Order(); 


            }

        public TransationControl screen = new TransationControl();

        /// <summary>
        /// Button that cancels order
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CancelOrder(object sender, RoutedEventArgs e)

        {
            Container.Child = new MenuItemSelectionControl();
            DataContext = new Order();

            Complete.Visibility = Visibility.Visible;
            CompleteT.Visibility = Visibility.Hidden;
        }

        /// <summary>
        ///Button pressed when order is complete
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CompleteOrder(object sender, RoutedEventArgs e)
        {
            SwapScreen(screen);        
            Complete.Visibility = Visibility.Hidden;
            CompleteT.Visibility = Visibility.Visible;

        }



        /// <summary>
        /// Changing what the border is containing to the new elemenet passes in
        /// </summary>
        /// <param name="element">Passing in element</param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element ;
        }

        /// <summary>
        /// Clicking this allows users to go back to the menu selection
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void ItemSelection(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        private void CompleteTransaction(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
            DataContext = new Order();

            CompleteT.Visibility = Visibility.Hidden;
            Complete.Visibility = Visibility.Visible;


        }
    }
}
