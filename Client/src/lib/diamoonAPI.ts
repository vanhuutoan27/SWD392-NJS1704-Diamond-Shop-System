import axios from "axios"

const diamoonAPI = axios.create({
  baseURL: "https://localhost:7212/api/v1",
  timeout: 3000,
  headers: {
    "Content-Type": "application/json"
  }
})

diamoonAPI.interceptors.request.use(
  (config) => {
    if (!config.headers["Authorization"]) {
      const token = document.cookie
        .split("; ")
        .find((row) => row.startsWith("accessToken="))
      if (token) {
        const accessToken = token.split("=")[1]
        config.headers["Authorization"] = `Bearer ${accessToken}`
      }
    }
    return config
  },
  (error) => {
    return Promise.reject(error)
  }
)

diamoonAPI.interceptors.response.use(
  (response) => {
    return response
  },
  (error) => {
    return Promise.reject(error)
  }
)

export default diamoonAPI
