using System;
using System.ComponentModel.DataAnnotations;

namespace AuburnMarketPlace.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } // User who placed the order
        public int CartId { get; set; } // Id of the cart associated with the order
        public DateTime OrderDate { get; set; }
        public string Address { get; set; } // Shipping address for the order

        [Required(ErrorMessage = "Email Address is required")]
        
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
        ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; } // Email of the user who placed the order
        public string UserName { get; set; } // Name of the user who placed the order

        public string state { get; set; }
        public string city  { get; set; }

        public int zipcode { get; set; }

        public string country { get; set; }

        public decimal total { get; set; }
    
    public string PaymentTransactionId { get; set; }


    public bool HasBeenShipped { get; set; }

    public List<OrderDetail> OrderDetails { get; set; }
  }

}
