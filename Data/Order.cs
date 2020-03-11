using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing orders 
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// Event Handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private  static uint lastOrderNumber = 0;
        
        /// <summary>
        /// List of ordere items
        /// </summary>

        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// List of items to an array 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }


        /// <summary>
        /// Returns the subtotal of the items in the order list 
        /// </summary>
        public double Subtotal
        {
            
            get
            {
                double sum = 0;
                foreach (IOrderItem item in items)
                {
                     sum += item.Price;
                    
                }
                if (sum < 0) sum = 0;
                return sum;
            }
        }

        /// <summary>
        /// Returns the last order number incremented
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber++; } }


        /// <summary>
        /// Adds items to the order 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
          
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }


            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }
        /// <summary>
        /// Removes items from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
           
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));


        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }

        }




    }
}
