import React, { Component } from 'react';
import { Form, FormGroup, Label, Input } from 'reactstrap';

export class ShopForm extends Component {

    constructor(props) {
        super(props);
        console.log(props);
        this.submitted = '';
        
        this.state = {inputvalue: ''};
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleSubmit = () => {
        this.submitted = 'submitted';
    }

    handleChange(event) {       
        this.setState({ inputvalue: event.target.value });
    }

    render() {
        return (
            <div>
                <h2>{this.state.inputvalue}</h2>
                <Form onSubmit={this.handleSubmit}>
                    <FormGroup> 
                        <Label>Shop</Label>                        
                        <Input type="text" value={this.state.inputvalue} onChange={this.handleChange} />
                    </FormGroup>
                    <FormGroup>
                        <input type="submit" value="Submit" />
                    </FormGroup>
                </Form>
                <h2>{this.submitted}</h2>
            </div>
            )
    }
}
export default ShopForm;