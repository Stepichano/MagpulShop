import React from "react";
import { Row, Container } from "react-bootstrap";
import { Link } from "react-router-dom";

export const Categories = () => {
  return (
    <>
      <Container>
        <Row>
          <div
            style={{
              color: "black",
              fontSize: 18,
              textAlign: "center",
            }}
          >
            <span style={{ fontSize: 24 }}>Что у нас есть в продаже</span>
            <img src="./Images/Категории.jpg" alt="" />
            <br />
            <Link to="./Catalog">Перейти в каталог</Link>
            <br />
            <span>
              Мы надеемся что вы найдете все необходимое внашем ассортименте
              продукции и оцените качестов наших услуг. Мы стремимся быть вашм
              надежным партнером в сфере снаряжения и оружия и с нетерпение
              мждем возможности помочь вм.
            </span>
          </div>
        </Row>
      </Container>
    </>
  );
};

export default Categories;
