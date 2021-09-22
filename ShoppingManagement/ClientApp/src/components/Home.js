import React, { Component } from 'react';
import ShopForm from './ShopForm';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello</h1>
            <p>Welcome to your new single-page application for managing shopping</p>
            <ShopForm />
      </div>
    );
  }
}
