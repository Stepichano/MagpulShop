import React, { useEffect } from "react";
import { useParams } from "react-router-dom";

const ProductDetail = () => {
  const { id } = useParams();

  useEffect(() => {
    if (!id) return;
        
  }, [id]);

  return <div>ProductDetail</div>;
};

export default ProductDetail;
