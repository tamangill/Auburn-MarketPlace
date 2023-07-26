import React, { Component } from 'react';
import './css/home.css';
export class Home extends Component {
  static displayName = Home.name;

  state = {
    products: [],
    loading: true,
  };

  async componentDidMount() {
    const response = await fetch('https://localhost:7004/api/Product');
    const data = await response.json();
    this.setState({ products: data, loading: false });
  }

  render() {
    const { products, loading } = this.state;

    return (
      <div className="container">
        <h1 className="my-4"></h1>
        {loading ? (
          <p>Loading...</p>
        ) : products.length === 0 ? (
          <p>No products available at the moment.</p>
        ) : (
          <div className="row">
            {products.map((product) => (
              <div key={product.productId} className="col-md-4 mb-4">
                <div className="card h-100 card-hover-shadow">
                  <img
                    src={product.imageUrl}
                    className="card-img-top"
                    alt={product.name}
                  />
                  <div className="card-body">
                    <h5 className="card-title">{product.name}</h5>
                    <p className="card-text">{product.description}</p>
                    <p className="card-text">Price: ${product.price}</p>
                    <a href={`/product-details/${product.productId}`} className="btn btn-primary btn-buy">
                      Buy Now
                    </a>
                  </div>
                </div>
              </div>
            ))}
          </div>
        )}
      </div>
    );
  }
}