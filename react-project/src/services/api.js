import axios from "axios";

const api = axios.create({
  baseURL: "https://eic-services.azurewebsites.net/api/",
  //baseURL: "https://localhost:44311/api",
});

export default api;