import React, { Component } from 'react';

export class Form extends Component {

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
                <form onSubmit={this.handleSubmit}>
                    <label>
                        Shop:
                        <input type="text" value={this.state.inputvalue} onChange={this.handleChange} />
                    </label>
                    <input type="submit" value="Submit" />
                </form>
                <h2>{this.submitted}</h2>
            </div>
            )

    }
}
export default Form;