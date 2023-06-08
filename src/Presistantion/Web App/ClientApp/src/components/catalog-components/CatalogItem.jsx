import {Button} from 'react-bootstrap';
import styles from "./Catalog.module.css";

function CatalogItem({ weapon }) {
  return (
    <>
      <div key={weapon.id} className={styles.item}>
        <div
          className={styles.image}
          style={{
            backgroundImage: `url(${weapon.image})`,
          }}
        ></div>
        <div className={styles.infoPrice}>
          <h3 className={styles.infoName}>{weapon.name}</h3>
          <p>
            {new Intl.NumberFormat("ru-RU", {
              style: "currency",
              currency: "RUB",
            }).format(weapon.price)}
          </p>
          <Button style={{
            backgroundColor: 'yellowgreen',
            width: 100,
            height: 40,

          }}>Add</Button>
        </div>
      </div>
    </>
  );
}

export default CatalogItem;
