import axios from "axios";

const api = axios.create({
  baseURL: "https://eic-services.azurewebsites.net/api/",
<<<<<<< HEAD
  // baseURL: "https://localhost:44311/api",
=======
  //baseURL: "https://localhost:44311/api",
>>>>>>> 74bbf4e (Adding diff color for friday Schedules)
});

export default api;