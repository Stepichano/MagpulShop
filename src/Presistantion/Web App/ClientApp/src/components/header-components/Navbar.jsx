import React from "react";
import { Container, Nav, Navbar, Row } from "react-bootstrap";
import "./Header-style.css";

const NaviBar = () => {
  return (
    <>
      <Navbar collapseOnSelect expand="md" bg="dark" variant="dark" >
        <Container>
              <Row className="justify-content-center">
            <Navbar.Brand href="./">
              <img
                src="./Images/SubLogo.jpg"
                height="30"
                width="30"
                alt="logo"
              />
              <>Magul</>
            </Navbar.Brand>
            <Navbar.Toggle aria-controls="responsive-navbar-nav"></Navbar.Toggle>
            <Navbar.Collapse id="responsive-navbar-nav">
              <Nav style={{fontSize: 22}}>
                <Nav.Link href="/">Home</Nav.Link>
                <Nav.Link href="/catalog">Catalog</Nav.Link>
                <Nav.Link href="/discount">Diskount</Nav.Link>
                <Nav.Link href="/about">About</Nav.Link>
                <Nav.Link href="/contacts">Contacts</Nav.Link>
              </Nav>
            </Navbar.Collapse>
          </Row>
        </Container>
      </Navbar>
    </>
  );
};

export default NaviBar;
