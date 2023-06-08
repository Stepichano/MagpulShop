// eslint-disable-next-line
import { useMemo, useState } from "react";
import CatalogItem from "../components/catalog-components/CatalogItem";
import { weapons } from "./weapons.data";
import { Container } from "react-bootstrap";

function Catalog() {
// const [filter, /*setFilter*/] = useState("");

  const filterWeapons = useMemo(() => weapons, [/*filter*/]);
  console.log("render");

  return (
    <>
      <Container>
        {filterWeapons.length ? (
          <div className="row col">
            {filterWeapons.map((weapon) => (
              <CatalogItem key={weapon.id} weapon={weapon}></CatalogItem>
            ))}
          </div>
        ) : (
          <p>Пусто</p>
        )}
      </Container>
    </>
  );
}

export default Catalog;
