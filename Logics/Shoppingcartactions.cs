using AuburnMarketPlace.Data;

public class Shoppingcartactions {

  // 1. connect to the product database 
  private readonly MyDbContext _dbContext;
  

  public Shoppingcartactions(MyDbContext _dbContext) {
    this._dbContext = _dbContext;
  }
  
      public string ShoppingCartId { get; set; }

  public bool addToCart( int productID, Cart cart){
    var item = _dbContext.Product.SingleOrDefault(p => p.productId == productID);
    if(item == default){
      return false;
    }

    var curentCart =  cart.cartItems.SingleOrDefault(cc => cc.productId == productID);

    if(curentCart != default){
      curentCart.quantity++;
    } else {
      var newItem = new CartItem {
        id = item.productId,
        quantity = 1,
        price = item.price,
        Product = item

      };
      
      cart.cartItems.Add(newItem);

      try {
        _dbContext.SaveChanges();
        return true;

      } catch (Exception ex) { 
        return false;
      }
    }
    return false;
  }
  

  public bool removeFromCart(int productID, Cart cart){
    var cartItem = cart.cartItems.SingleOrDefault(item => item.productId == productID);

    if( cartItem != default){
      cart.cartItems.Remove(cartItem);
      try{
      _dbContext.SaveChanges();
      return true;
      } catch (Exception ex) {
        return false;
      }
    }
    return false;
  }
}