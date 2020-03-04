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
            //Variable that does 
            DataContext = new Order(); 

            }

        private void CancelOrder(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
        }

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
    }
}
