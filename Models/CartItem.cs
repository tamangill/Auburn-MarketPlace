public class CartItem
{
  public int id { get; set; }
  public int productId { get; set; }
  public int quantity { get; set; }
  public double price { get; set; }
  public virtual Product Product { get; set; }

}