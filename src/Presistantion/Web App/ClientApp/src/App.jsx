import React, { Component } from "react";
import { Route, Routes } from "react-router-dom";
// import AppRoutes from './AppRoutes';
import "./styles/style.css";
import "./custom.css";

import Catalog from "./Pages/Catalog";
import Home from "./Pages/Home";
import Contacts from "./Pages/Contacts";
import About from "./Pages/About";
import Diskount from "./Pages/Diskount";
// import ProductDetail from "./components/ProductDetail-components/ProductDetail";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <>
        <Routes>
          <Route element={<Home />} path="/" />
          <Route element={<Catalog />} path="/Catalog" />
          <Route element={<Diskount />} path="/Diskount" />
          <Route element={<About />} path="/About" />
          <Route element={<Contacts />} path="/Contacts" />
          {/* <Route element={<ProductDetail />} path="/Product/:id" /> */}
          <Route path="*" element={<div>Not Found</div>} />
        </Routes>
      </>
    );
  }
}
