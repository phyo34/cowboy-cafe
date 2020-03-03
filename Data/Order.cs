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

       
        private  static uint lastOrderNumber = 0;
        

        private List<IOrderItem> items = new List<IOrderItem>();

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

        public uint OrderNumber { get { return lastOrderNumber++; } }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds items to the order 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

        }
        /// <summary>
        /// Removes items from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));

        }




    }
}
