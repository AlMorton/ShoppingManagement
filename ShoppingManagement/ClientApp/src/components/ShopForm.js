"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.ShopForm = void 0;
var react_1 = require("react");
var reactstrap_1 = require("reactstrap");
var ShopForm = /** @class */ (function (_super) {
    __extends(ShopForm, _super);
    function ShopForm(props) {
        var _this = _super.call(this, props) || this;
        _this.handleSubmit = function () {
            _this.submitted = 'submitted';
        };
        console.log(props);
        _this.submitted = '';
        _this.state = { inputvalue: '' };
        _this.handleChange = _this.handleChange.bind(_this);
        _this.handleSubmit = _this.handleSubmit.bind(_this);
        return _this;
    }
    ShopForm.prototype.handleChange = function (event) {
        this.setState({ inputvalue: event.target.value });
    };
    ShopForm.prototype.render = function () {
        return ({ this: .state.inputvalue } < /h2>
            < reactstrap_1.Form);
        onSubmit = { this: .handleSubmit } >
            Shop < /Label>                        
            < reactstrap_1.Input;
        type = "text";
        value = { this: .state.inputvalue };
        onChange = { this: .handleChange } /  >
            color;
        "primary" > Add;
        new shop < /Button>{' '}
            < /FormGroup>
            < reactstrap_1.FormGroup >
            type;
        "submit";
        value = "Submit" /  >
            /FormGroup>
            < /Form>
            < h2 > { this: .submitted } < /h2>
            < /div>;
    };
    return ShopForm;
}(react_1.Component));
exports.ShopForm = ShopForm;
exports.default = ShopForm;
