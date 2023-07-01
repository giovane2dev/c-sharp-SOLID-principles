using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

/*
    - Enriching the anemic domain model
    
    Rich models are domain models that follow object-oriented
    programming principles and define classes with object models
    with fields and properties and behaviours (methods and events).
*/

namespace AnemicDomainModel.Domain.Entities
{   
    public class Item
    {
        public Item(int itemId, int orderId, string itemName, decimal itemPrice)
        {
            if (itemId <= 0)
            {
                throw new ArgumentException("Código do item deve ser informado com valor maior que zero!");
            }

            if (orderId <= 0)
            {
                throw new ArgumentException("Código do pedido deve ser informado com valor maior que zero!");
            }

            this.ItemId = itemId;
            this.OrderId = orderId;
            this.ItemName = itemName;
            this.itemPrice = itemPrice;
        }

        public int ItemId { get; private set; }
        public int OrderId { get; private set; }

        private string itemName;
        public string ItemName { 
            get => this.itemName; 
            private set
            {
                this.itemName = (value.Length > 150) ?
                    throw new ArgumentOutOfRangeException(nameof(ItemName),
                    "Item name must not exceed 150 characters!") : value;
            }
        }

        private decimal itemPrice;
        public decimal ItemPrice { 
            get => this.itemPrice;
            private set
            {
                this.itemPrice = (value <= 0) ? throw new ArgumentOutOfRangeException(nameof(ItemPrice),
                    "Item price must not less than zero!") : value;
            }
        }
    }
}
