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
exports.NavMenu = void 0;
var react_1 = require("react");
var reactstrap_1 = require("reactstrap");
var react_router_dom_1 = require("react-router-dom");
require("./NavMenu.css");
var NavMenu = /** @class */ (function (_super) {
    __extends(NavMenu, _super);
    function NavMenu(props) {
        var _this = _super.call(this, props) || this;
        _this.toggleNavbar = _this.toggleNavbar.bind(_this);
        _this.state = {
            collapsed: true
        };
        return _this;
    }
    NavMenu.prototype.toggleNavbar = function () {
        this.setState({
            collapsed: !this.state.collapsed
        });
    };
    NavMenu.prototype.render = function () {
        return className = "navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3";
        light >
            tag;
        {
            react_router_dom_1.Link;
        }
        to = "/" > ShoppingManagement < /NavbarBrand>
            < reactstrap_1.NavbarToggler;
        onClick = { this: .toggleNavbar };
        className = "mr-2" /  >
            className;
        "d-sm-inline-flex flex-sm-row-reverse";
        isOpen = {};
        this.state.collapsed;
    };
    NavMenu.displayName = NavMenu.name;
    return NavMenu;
}(react_1.Component));
exports.NavMenu = NavMenu;
 >
    className;
"navbar-nav flex-grow" >
    tag;
{
    react_router_dom_1.Link;
}
className = "text-dark";
to = "/" > Home < /NavLink>
    < /NavItem>
    < reactstrap_1.NavItem >
    tag;
{
    react_router_dom_1.Link;
}
className = "text-dark";
to = "/counter" > Counter < /NavLink>
    < /NavItem>
    < reactstrap_1.NavItem >
    tag;
{
    react_router_dom_1.Link;
}
className = "text-dark";
to = "/fetch-data" > Fetch;
data < /NavLink>
    < /NavItem>               
    < /ul>
    < /Collapse>
    < /Container>
    < /Navbar>
    < /header>;
;
