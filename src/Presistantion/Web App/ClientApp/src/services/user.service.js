import axios from "axios";

export const UserService = {
  async registerUser(userData) {
    const response = await axios.post(
      "http://localhost:44401/api/users/register",
      userData
    );
    return response.data;
  },
};
