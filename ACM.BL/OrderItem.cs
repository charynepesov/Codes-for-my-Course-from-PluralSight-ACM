using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int OrderItemId { get; private set; }

        public bool Validate()
        {
            bool isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int orderItemId)
        {
            //Code for retrieving Order Item here
            return new OrderItem();
        }
        /// <summary>
        /// Saves current order item.
        /// </summary>
        public bool Save()
        {
            //Code for saving initial Order Item here
            return true;
        }
    }
}
