public class Cart{
  public int id { get; set; }
  public int userId { get; set; }

  public List<CartItem> cartItems { get; set; } = new List<CartItem>();


}