import React, { Component } from 'react';
import ShopForm from './ShopForm';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
            <h1>Record a shopping trip</h1>
            <ShopForm />
      </div>
    );
  }
}
