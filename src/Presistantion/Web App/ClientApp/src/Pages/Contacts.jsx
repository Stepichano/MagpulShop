import React from "react";
import { Container, Row, Col } from "react-bootstrap";
import {
  TelephoneFill,
  EnvelopeAtFill,
  ClockFill,
} from "react-bootstrap-icons";
import { FaMapMarkerAlt } from "react-icons/fa";
import MapsGoogle from "../components/contacts-components/MapsGoogle";
import "./Contact-style.css";

const Contacts = () => {
  return (
    <>
      <Container
        className="justify-content-centr"
        style={{
          color: "black",
          paddingTop: 50,
        }}
      >
        <span
          style={{
            fontSize: 26,
            marginLeft: 100,
          }}
        >
          Контакты интернет-магазина "Magpul"
        </span>
        <Row>
          <Col>
            <Row>
              <FaMapMarkerAlt className="icons col" />
              <p className="col-10">
                <span className="fw-bold">Адрес</span>
                <br />
                <span>Н.О, г.Новосибирск, ул.Русская.35\1</span>
              </p>
            </Row>
            <Row>
              <TelephoneFill className="icons col" />
              <p className="col-10">
                <span className="fw-bold">Телефон</span>
                <br />
                <span>+7 913 479 53 66</span>
              </p>
            </Row>
            <Row>
              <EnvelopeAtFill className="icons col" />
              <p className="col-10">
                <span className="fw-bold">E-mail</span>
                <br />
                <span>stepanovich@mer.ci.nsu.ru</span>
              </p>
            </Row>
            <Row>
              <ClockFill className="icons col" />
              <p className="col-10">
                <span className="fw-bold">Режим работы</span>
                <br />
                <span>круглосуточно, мы рабы</span>
              </p>
            </Row>
          </Col>
          <Col>
            <MapsGoogle />
          </Col>
        </Row>
      </Container>
    </>
  );
};

export default Contacts;
