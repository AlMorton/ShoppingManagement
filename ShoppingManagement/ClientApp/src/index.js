"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
require("bootstrap/dist/css/bootstrap.css");
var react_dom_1 = __importDefault(require("react-dom"));
var registerServiceWorker_1 = __importDefault(require("./registerServiceWorker"));
var baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
var rootElement = document.getElementById('root');
react_dom_1.default.render(basename, { baseUrl: baseUrl } >
    />
    < /BrowserRouter>,, rootElement);
registerServiceWorker_1.default();
