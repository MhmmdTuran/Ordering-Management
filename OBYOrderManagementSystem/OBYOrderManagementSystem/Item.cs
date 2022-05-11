using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBYOrderManagementSystem
{
    public class Item
    {
        public int ItemId { get; set; }
        private float ShippingWeight { get; set; }
        public string Description { get; set; }
        public int SelectedQuantity { get; set; }

        public float GetPriceForQuantity()
        {
            return 1.0f;
        }
        public float GetWeight()
        {
            return 1.0f;
        }
    }
}
