using AuburnMarketPlace.Data;

public class Shoppingcartactions : IDisposable{

  // 1. connect to the product database 
  private readonly MyDbContext _dbContext;
  

  public Shoppingcartactions(MyDbContext _dbContext) {
    this._dbContext = _dbContext;
  }
  
      public string ShoppingCartId { get; set; }

      public void addToCart(int productID){

      }


  public void Dispose()
  {
    throw new NotImplementedException();
  }






















  // 2.  Add to cart
  //        - given the product ID get the cuurent cart 
  //        - if a cart does not exist then make a cart  
  //        - make a new cart item and store in the cart
  //        
  // 3.  Remove from cart
  // - remove the cart item 
  // -  if cart does not exist return a message cart does not exist
  // - 
  // -  

}