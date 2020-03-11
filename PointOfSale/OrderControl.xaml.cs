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

        /// <summary>
        /// Button that cancels order
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CancelOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

        /// <summary>
        ///Button pressed when order is complete
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event</param>
        private void CompleteOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();

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
    }
}
