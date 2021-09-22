import React, { Component } from 'react';
import Form from './Form';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello</h1>
            <p>Welcome to your new single-page application for managing shopping</p>
            <Form />
      </div>
    );
  }
}
