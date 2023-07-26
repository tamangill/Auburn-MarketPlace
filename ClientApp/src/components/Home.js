import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  state = {
    products: [],
  };

  async componentDidMount() {
    // Fetch product data from the backend API
    const response = await fetch('https://localhost:7004/api/Product');
    const data = await response.json();

    // Update the state with the fetched product data
    this.setState({ products: data });
  }

  render() {
    const { products } = this.state;

    return (
      <div>
        <h1>Welcome to our Online Store!</h1>
        {products.length === 0 ? (
          <p>No products available at the moment.</p>
        ) : (
          <div>
            <p>Check out our amazing products:</p>
            <ul>
              {products.map((product) => (
                <li key={product.productId}>
                  <h3>{product.name}</h3>
                  <p>Description: {product.description}</p>
                  <p>Price: ${product.price}</p>
                </li>
              ))}
            </ul>
          </div>
        )}
      </div>
    );
  }
}
