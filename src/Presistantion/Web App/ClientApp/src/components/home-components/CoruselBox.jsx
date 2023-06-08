import React from "react";
import { Carousel, Container } from "react-bootstrap";
import "./Home-style.css";

const CoruselBox = () => {
  return (
    <>
      <Container>
        <Carousel>
          <Carousel.Item>
            <img
              className="d-block w-100 coruselItem"
              src="./Images/Corusel/Сражение.png"
              alt="img"
            ></img>
          </Carousel.Item>
          <Carousel.Item>
            <img
              className="d-block w-100 coruselItem"
              src="./Images/Corusel/discount.jpg"
              alt="img"
            ></img>
          </Carousel.Item>
          <Carousel.Item>
            <img
              className="d-block w-100 coruselItem"
              src="./Images/Corusel/НОВИНКИ.png"
              alt="img"
            ></img>
          </Carousel.Item>
        </Carousel>
      </Container>
    </>
  );
};

export default CoruselBox;
