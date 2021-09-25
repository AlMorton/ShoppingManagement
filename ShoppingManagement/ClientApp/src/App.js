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
var react_1 = require("react");
var Home_1 = require("./components/Home");
var FetchData_1 = require("./components/FetchData");
var Counter_1 = require("./components/Counter");
require("./custom.css");
var App = /** @class */ (function (_super) {
    __extends(App, _super);
    function App() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    App.prototype.render = function () {
        return exact;
        path = '/';
        component = { Home: Home_1.Home } /  >
            path;
        '/counter';
        component = { Counter: Counter_1.Counter } /  >
            path;
        '/fetch-data';
        component = { FetchData: FetchData_1.FetchData } /  >
            /Layout>;
        ;
    };
    App.displayName = App.name;
    return App;
}(react_1.Component));
exports.default = App;
