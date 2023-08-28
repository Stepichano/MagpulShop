import axios from "axios";
export const ProductService = {
  async addUser(user) {
    const response = await axios.post(
      "http://localhost:44401/api/products/add",
      user
    );
    return response.data;
  },
};
