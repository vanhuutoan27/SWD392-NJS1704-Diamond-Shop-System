import axios from "axios";

const diamoonAPI = axios.create({
  baseURL: "https://localhost:7212/api/v1",
  timeout: 3000,
  headers: {
    "Content-Type": "application/json",
  },
});

diamoonAPI.interceptors.request.use(
  (config) => {
    return config;
  },
  (error) => {
  return Promise.reject(error);
  },
);

diamoonAPI.interceptors.response.use(
  (response) => {
    return response;
  },
  (error) => {
    return Promise.reject(error);
  },
);

export default diamoonAPI;
