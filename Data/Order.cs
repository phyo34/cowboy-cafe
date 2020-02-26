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
        private static uint lastOrderNumber = 0;

        private List<IOrderItem> items;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public uint OrderNumber { get; }

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
