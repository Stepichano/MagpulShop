import React, { Component } from "react";
import CoruselBox from "../components/home-components/CoruselBox";
import Categories from "../components/home-components/Categories";

export default class Home extends Component {
  render() {
    return (
      <>
        <CoruselBox />
        <Categories />
      </>
    );
  }
}
