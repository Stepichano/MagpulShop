// eslint-disable-next-line
import { useMemo, useState } from "react";
import CatalogItem from "../components/catalog-components/CatalogItem";
import { weapons } from "./weapons.data";
import { Container } from "react-bootstrap";
import { ProductService } from "../services/product.service";

function Catalog() {
  // const [filter, /*setFilter*/] = useState("");
  const handleClick = async () => {
    const response = await ProductService.addUser({
      CountProduct: 2,
      Name: "G332",
      Price: 2343,
    });
    if (!response) {
      return <p>ErrorHttp</p>;
    }
    console.log(response.status);
  };

  const filterWeapons = useMemo(
    () => weapons,
    [
      /*filter*/
    ]
  );
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

        <button onClick={handleClick}></button>
      </Container>
    </>
  );
}

export default Catalog;
