import React from "react";
import { Container, Row, Col } from "react-bootstrap";
import { Link } from "react-router-dom";

import {
  FaTelegram,
  FaVk,
  FaInstagram,
  FaPhone,
  FaEnvelope,
  FaMapMarkerAlt,
} from "react-icons/fa";
import "./Foot-style.css";

const location =
  "https://www.google.com/maps/place/%D0%A0%D1%83%D1%81%D1%81%D0%BA%D0%B0%D1%8F+%D1%83%D0%BB.,+35%2F1,+%D0%9D%D0%BE%D0%B2%D0%BE%D1%81%D0%B8%D0%B1%D0%B8%D1%80%D1%81%D0%BA,+%D0%9D%D0%BE%D0%B2%D0%BE%D1%81%D0%B8%D0%B1%D0%B8%D1%80%D1%81%D0%BA%D0%B0%D1%8F+%D0%BE%D0%B1%D0%BB.,+%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D1%8F,+630058/@54.846539,83.0537059,18.19z/data=!4m9!1m2!2m1!1zZ29vZ2xlINC60LDRgNGC0Ys!3m5!1s0x42dfc49e9b549b57:0x190a51849581874c!8m2!3d54.847372!4d83.0533733!16s%2Fg%2F11c1c1899s?entry=ttu";

const Footer = () => {
  return (
    <>
      <footer className="pt-md-2 pb-md-3 border-top foot">
        <Container>
          <Row>
            <Col className="col-4">
              <p>О компании</p>
              <Link className="row" to="/about">
                О нас
              </Link>
              <Link className="row" to="/contacts">
                Контакты
              </Link>
            </Col>
            <Col className="col-4 text-center">
              <p>Оставайтесь с нами</p>
              <Row>
                <a className="col" href="https://www.instagram.com/">
                  <FaInstagram />
                </a>
                <a className="col" href="https://m.vk.com/m.stepanovich5">
                  <FaVk />
                </a>
                <a className="col" href="https://www.telegram.com/">
                  <FaTelegram />
                </a>
              </Row>
            </Col>
            <Col>
              <p>Наши Контакты</p>
              <Row>
                <Col>
                  <FaPhone />
                  <span> +7 913 4795366</span>
                </Col>
              </Row>
              <Row>
                <Col>
                  <FaEnvelope />
                  <a
                    href="mailto:stepanovich@mer.ci.nsu.ru"
                    style={{
                      color: "white",
                      marginLeft: 7,
                    }}
                  >
                    stepanovich@mer.ci.nsu.ru
                  </a>
                </Col>
              </Row>
              <Row>
                <Col>
                  <FaMapMarkerAlt />
                  <a
                    href={location}
                    style={{
                      color: "yellow",
                      marginLeft: 7,
                    }}
                  >
                    Новосибирская область, г.Новосибирск, ул.Русская.35\1.
                  </a>
                </Col>
              </Row>
            </Col>
          </Row>
        </Container>
      </footer>
    </>
  );
};

export default Footer;
