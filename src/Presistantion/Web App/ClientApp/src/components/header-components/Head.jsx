import React, { useState } from "react";
import { Navbar, Container } from "react-bootstrap";
import FormAuthorization from "./FormAuthorization";
import "./Header-style.css";



const Head = () => {
  const [show, setShow] = useState(false);
  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);


  return (
    <>
      <div
        className="upperHeader"
        style={{
          backgroundImage: `url(./Images/HeadImage.jpg)`,
          backgroundSize: "cover",
          backgroundPosition: "center",
          backgroundRepeat: "no-repeat",
        }}
      >
        <Container>
          <div className="row text-center" style={{ alignItems: "center" }}>
            <Navbar.Brand
              className="logo col-4"
              style={{
                backgroundImage: `url(./Images/Logo.jpg)`,
                maxWidth: 100,
              }}
            ></Navbar.Brand>
            <span className="col-4">+7 913 479 53 66</span>
            <div className="cartItem col-2">
              <p>Корзина</p>
              <img
                href="./Index.html"
                src="./Images/Cart.jpg"
                className="carItem"
                alt="img"
              />
            </div>
            <div className="col-2">
              <p onClick={handleShow}>Вход и Регистрация</p>
              <img
                src="./Images/Profile.png"
                alt="img"
                className="authorizationItem"
              />
            </div>
          </div>
              <FormAuthorization show={show} handleClose={handleClose}/>
        </Container>
      </div>

    </>
  );
};

export default Head;
