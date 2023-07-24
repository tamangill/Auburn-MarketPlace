using System;

namespace AuburnMarketPlace.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } // User who placed the order
        public int CartId { get; set; } // Id of the cart associated with the order
        public DateTime OrderDate { get; set; }
        public string Address { get; set; } // Shipping address for the order
        public string UserEmail { get; set; } // Email of the user who placed the order
        public string UserName { get; set; } // Name of the user who placed the order
    }
}
